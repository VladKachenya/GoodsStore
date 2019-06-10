using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate;

namespace GoodsStore.Core.Infrastructure.Services
{
    public interface IComparisonBasketSevice
    {
        Task AddItemToBasket(int basketId, int catalogItemId, string discriminator);
        Task AddItemToBasket(string userId, int catalogItemId, string discriminator);

        Task DeleteItemFromBasket(int basketId, int catalogItemId);
        Task<ComparisonBasket> GetOrCreateBasketForUser(string userId);
        Task<int> GetBasketItemCount(string userId);
        Task DeleteBasketAsync(int basketId);

        // TransferBasketAsync при логине должен вызыватся этот метод чтобы перенести корзину покупок
    }
}