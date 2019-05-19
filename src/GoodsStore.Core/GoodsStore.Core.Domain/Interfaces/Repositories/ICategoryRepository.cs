using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;

namespace GoodsStore.Core.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IReadOnlyList<Category>> ListAllIncludesCatalogItems();
    }
}