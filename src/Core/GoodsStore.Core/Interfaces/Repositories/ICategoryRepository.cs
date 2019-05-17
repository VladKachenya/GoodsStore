using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;

namespace GoodsStore.Core.Interfaces.Repositories
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<IReadOnlyList<Category>> ListAllIncludesCatalogItems();
    }
}