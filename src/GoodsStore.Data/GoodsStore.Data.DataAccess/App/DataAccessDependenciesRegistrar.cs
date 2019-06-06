using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Data.DataAccess.Repositories;
using GoodsStore.Data.DataAccess.Specifications;
using GoodsStore.Data.Infrastructure.Data;

namespace GoodsStore.Data.DataAccess.App
{
    public class DataAccessDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<GoodsStoreDbContext, IDbContext>();
            containerBuilder.RegisterType<CategoryRepository, ICategoryRepository>();
            containerBuilder.RegisterGeneric(typeof(CatalogItemRepository<>), typeof(ICatalogItemRepository<>));

            containerBuilder.RegisterGeneric(typeof(EfRepository<>), typeof(IRepository<>));
            containerBuilder.RegisterGeneric(typeof(SpecificationEvaluator<>), typeof(ISpecificationEvaluator<>));

            containerBuilder.RegisterGeneric(typeof(Specification<>), typeof(ISpecification<>));
            containerBuilder.RegisterGeneric(typeof(CatalogItemFiltringSpecification<>), typeof(ICatalogItemFiltringSpecification<>));
        }
    }
}