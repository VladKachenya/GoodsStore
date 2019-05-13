using GoodsStore.Core.Entities.Base;
using System.Threading.Tasks;

namespace GoodsStore.Core.Interfaces.Repositories
{
    public interface IProductRpository<TProductEntit> : IAsyncRepository<TProductEntit> where TProductEntit : ProductBaseEntity
    {
        Task<TProductEntit> GetProductById(int id);
    }
}