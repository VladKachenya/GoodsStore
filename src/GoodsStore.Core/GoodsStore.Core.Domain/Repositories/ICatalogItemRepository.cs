using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Core.Domain.Repositories
{
    public interface ICatalogItemRepository<TCatalogItem> : IRepository<TCatalogItem> where TCatalogItem : CatalogItem
    {
        
    }

    public interface ICatalogItemRepository 
    {
        Task<CatalogItem> GetById(int id);
        Task<IReadOnlyList<CatalogItem>> List(object specification);
        Task<int> Count(object specification);
    }
}