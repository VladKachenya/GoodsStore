using Autofac;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.AppInfrastructure;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Core.Specifications;

namespace GoodsStore.Web.Framework.AppInfrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<CatalogItemFilterSpecification>().As<ISpecification<CatalogItemBase>>();
        }

        public int Order { get; } = 1;
    }
}