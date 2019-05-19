using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Data.DataAccess.Repositories;
using GoodsStore.Data.Infrastructure.Data;

namespace GoodsStore.Data.DataAccess.App
{
    public class DataAccessDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<GoodsStoreDbContext, IDbContext>();

            containerBuilder.RegisterType<CategoryRepository, ICategoryRepository>();
            containerBuilder.RegisterType<CatalogItemRepository, ICatalogItemRepository>();

            containerBuilder.RegisterGeneric(typeof(EfRepository<>), typeof(IRepository<>));
            containerBuilder.RegisterGeneric(typeof(SpecificationEvaluator<>), typeof(ISpecificationEvaluator<>));
        }
    }
}