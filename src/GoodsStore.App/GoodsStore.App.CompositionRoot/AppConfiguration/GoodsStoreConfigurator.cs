using Autofac;
using Autofac.Extensions.DependencyInjection;
using GoodsStore.App.CompositionRoot.IoC;
using GoodsStore.App.CompositionRoot.WebApp;
using GoodsStore.App.Infrastructure.App;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Core.Specifications;
using GoodsStore.Data.DataAccess.App;
using GoodsStore.Web.Framework.WebApp;
using GoodsStore.Web.Infrastructure.WebApp;
using GoodsStore.Web.ViewModel.App;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.App.CompositionRoot.AppConfiguration
{
    public class GoodsStoreConfigurator : IAppConfigurator
    {
        #region Properties
        private IServiceProvider _serviceProvider { get; set; }
        private IEnumerable<IGoodsStoreStartup> _startups { get; }
        #endregion

        public GoodsStoreConfigurator()
        {
            _startups = GetStartups();
        }

        #region Implementation of IAppConfigurator

        public IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();
            var goodsStoreContainerBuilder = new GoodsStoreContainerBuilder(containerBuilder);

            foreach (var startup in _startups.OrderBy(s => s.Order))
            {
                startup.ConfigureServices(services, configuration);
            }

            //register core types
            RegisterDomainTypes(containerBuilder);

            //register all provided dependencies
            foreach (var dependencyRegistrar in GetDependenciesRegistrators())
            {
                dependencyRegistrar.Register(goodsStoreContainerBuilder);
            }

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            //create service provider
            _serviceProvider = new AutofacServiceProvider(containerBuilder.Build());

            return _serviceProvider;
        }

        public void ConfigureRequestPipeline(IApplicationBuilder application, IHostingEnvironment environment)
        {
            foreach (var startup in _startups.OrderBy(s => s.Order))
            {
                startup.Configure(application, environment);
            }
        }
        #endregion


        #region Utilities

        protected void RegisterDomainTypes(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CatalogItemFilterSpecification>().As<ISpecification<CatalogItem>>();
        }


        protected IEnumerable<IDependenciesRegistrar> GetDependenciesRegistrators()
        {
            yield return new DataAccessDependenciesRegistrar();
            yield return new WebViewModelDependenciesRegistrar();
        }

        protected IEnumerable<IGoodsStoreStartup> GetStartups()
        {
            yield return new ErrorHandlerStartup();
            yield return new GoodsStoreDbStartup();
            yield return new MvcStartup();
        }


        #endregion
    }
}