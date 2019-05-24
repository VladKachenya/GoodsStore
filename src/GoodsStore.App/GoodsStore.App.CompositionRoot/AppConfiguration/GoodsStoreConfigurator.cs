﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using GoodsStore.App.CompositionRoot.IoC;
using GoodsStore.App.CompositionRoot.WebApp;
using GoodsStore.App.Infrastructure.App;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Logic.Filter;
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Core.Logic.Specifications;
using GoodsStore.Data.DataAccess.App;
using GoodsStore.Web.Framework.App;
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
using GoodsStore.App.CompositionRoot.App;
using GoodsStore.Core.Logic.Filter.ExpressionGenerators;

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

            //register all provided dependencies
            foreach (var dependencyRegistrar in GetDependenciesRegistrators())
            {
                dependencyRegistrar.Register(goodsStoreContainerBuilder);
            }

            //populate Autofac container builder with the set of registered service descriptors
            containerBuilder.Populate(services);

            IContainer container = null;

            // regester autofac container
            containerBuilder.Register(c => container).AsSelf().SingleInstance();
            containerBuilder.RegisterBuildCallback(c => container = c);

            //create service provider
            container = containerBuilder.Build();
            _serviceProvider = new AutofacServiceProvider(container);

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


        protected IEnumerable<IDependenciesRegistrar> GetDependenciesRegistrators()
        {
            yield return new DataAccessDependenciesRegistrar();
            yield return new WebViewModelDependenciesRegistrar();
            yield return new WebFrameworkDependenciesRegistrar();
            yield return new CoreDependenciesRegistrar();
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