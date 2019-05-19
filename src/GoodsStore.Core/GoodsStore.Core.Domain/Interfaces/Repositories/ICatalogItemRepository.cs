using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Core.Domain.Interfaces.Repositories
{
    public interface ICatalogItemRepository : IRepository<CatalogItem>
    {
        Task<IReadOnlyList<CatalogItem>> ListIncludesItemTypeAndBrand(ISpecification<CatalogItem> spec);
    }
}