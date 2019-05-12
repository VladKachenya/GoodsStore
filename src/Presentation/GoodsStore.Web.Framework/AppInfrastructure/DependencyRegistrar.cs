using Autofac;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces;
using GoodsStore.Core.Interfaces.AppInfrastructure;
using GoodsStore.Core.Interfaces.Data;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Core.Specifications;
using GoodsStore.Infrastructure.Data;
using GoodsStore.Infrastructure.Helpers;
using GoodsStore.Infrastructure.Repositories;
using GoodsStore.Web.Framework.Interfaces;
using GoodsStore.Web.Framework.Routing;

namespace GoodsStore.Web.Framework.AppInfrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<CatalogItemFilterSpecification>().As<ISpecification<CatalogItem>>();
            builder.RegisterType<RoutePublisher>().As<IRoutePublisher>().SingleInstance();
            builder.RegisterType<GoodsStoreDbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IAsyncRepository<>));
            builder.RegisterGeneric(typeof(SpecificationEvaluator<>)).As(typeof(ISpecificationEvaluator<>));
        }

        public int Order { get; } = 1;
    }
}