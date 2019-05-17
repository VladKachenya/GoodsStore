using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Core.Interfaces.Repositories
{
    public interface ICatalogItemRepository : IAsyncRepository<CatalogItem>
    {
        Task<IReadOnlyList<CatalogItem>> ListIncludesItemTypeAndBrand(ISpecification<CatalogItem> spec);
    }
}