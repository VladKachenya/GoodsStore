using Autofac;
using Autofac.Extensions.DependencyInjection;
using GoodsStore.Core.Interfaces.AppInfrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GoodsStore.Core.AppInfrastructure
{
    public class GoodsStoreConfigurator : IAppConfigurator
    {
        #region Properties
        private IServiceProvider _serviceProvider { get; set; }
        #endregion

        #region Implementation of I AppConfigurator

        public IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //find startup configurations provided by other assemblies
            var typeFinder = new GoodsStoreTypeFinder(); ;
            var startupConfigurations = typeFinder.FindClassesOfType<IAppStartup>();
            //create and sort instances of startup configurations
            var instances = startupConfigurations
                .Select(startup => (IAppStartup)Activator.CreateInstance(startup))
                .OrderBy(startup => startup.Order);

            //configure services
            foreach (var instance in instances)
            {
                instance.ConfigureServices(services, configuration);
            }

            //register dependencies
            RegisterDependencies(services, typeFinder);
            return _serviceProvider;
        }

        public void ConfigureRequestPipeline(IApplicationBuilder application)
        {
            var typeFinder = _serviceProvider.GetService<ITypeFinder>();
            var startupConfigurations = typeFinder.FindClassesOfType<IAppStartup>();
            var instances = startupConfigurations
                .Select(startup => (IAppStartup)Activator.CreateInstance(startup))
                .OrderBy(startup => startup.Order);

            //configure request pipeline
            foreach (var instance in instances)
            {
                instance.Configure(application);
            }
        }
        #endregion


        #region Utilities

        protected virtual IServiceProvider RegisterDependencies(IServiceCollection services, ITypeFinder typeFinder)
        {
            var containerBuilder = new ContainerBuilder();

            //register engine
            containerBuilder.RegisterInstance(this).As<IAppConfigurator>().SingleInstance();

            //register type finder
            containerBuilder.RegisterInstance(typeFinder).As<ITypeFinder>().SingleInstance();

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            //find dependency registrars provided by other assemblies
            var dependencyRegistrars = typeFinder.FindClassesOfType<IDependencyRegistrar>();

            //create and sort instances of dependency registrars
            var instances = dependencyRegistrars
                .Select(dependencyRegistrar => (IDependencyRegistrar)Activator.CreateInstance(dependencyRegistrar))
                .OrderBy(dependencyRegistrar => dependencyRegistrar.Order);

            //register all provided dependencies
            foreach (var dependencyRegistrar in instances)
            {
                dependencyRegistrar.Register(containerBuilder, typeFinder);
            }

            //create service provider
            _serviceProvider = new AutofacServiceProvider(containerBuilder.Build());

            return _serviceProvider;
        }

        #endregion
    }
}