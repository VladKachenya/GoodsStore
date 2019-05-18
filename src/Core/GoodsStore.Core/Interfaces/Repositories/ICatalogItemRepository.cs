using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Core.Interfaces.Repositories
{
    public interface ICatalogItemRepository : IRepository<CatalogItem>
    {
        Task<IReadOnlyList<CatalogItem>> ListIncludesItemTypeAndBrand(ISpecification<CatalogItem> spec);
    }
}