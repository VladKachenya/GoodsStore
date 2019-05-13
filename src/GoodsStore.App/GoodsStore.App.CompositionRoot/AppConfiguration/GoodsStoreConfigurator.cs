using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using GoodsStore.App.CompositionRoot.IoC;
using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Core.Specifications;
using GoodsStore.Data.DataAccess;
using GoodsStore.Data.DataAccess.App;
using GoodsStore.Data.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.App.CompositionRoot.AppConfiguration
{
    public class GoodsStoreConfigurator : IAppConfigurator
    {
        #region Properties
        private IServiceProvider _serviceProvider { get; set; }
        #endregion

        #region Implementation of IAppConfigurator

        public IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();
            var goodsStoreContainerBuilder = new GoodsStoreContainerBuilder(containerBuilder);

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            //register core types
            RegisterDomainTypes(containerBuilder);

            //register all provided dependencies
            foreach (var dependencyRegistrar in RegisterModules())
            {
                dependencyRegistrar.Register(goodsStoreContainerBuilder);
            }

            //create service provider
            _serviceProvider = new AutofacServiceProvider(containerBuilder.Build());

            return _serviceProvider;
        }

        public void ConfigureRequestPipeline(IApplicationBuilder application, IHostingEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
            }

            application.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
        #endregion


        #region Utilities

        protected virtual void RegisterDomainTypes(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CatalogItemFilterSpecification>().As<ISpecification<CatalogItem>>();

            //containerBuilder.RegisterType<RoutePublisher>().As<IRoutePublisher>().SingleInstance();
        }

        protected virtual IEnumerable<IDependenciesRegistrar> RegisterModules()
        {
            yield return new DataAccessDependenciesRegistrar();
        }
        #endregion
    }
}