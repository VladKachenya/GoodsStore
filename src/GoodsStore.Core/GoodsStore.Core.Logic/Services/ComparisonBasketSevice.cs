using GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Infrastructure.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStore.Core.Logic.Services
{
    public class ComparisonBasketSevice : IComparisonBasketSevice
    {
        private readonly IRepository<ComparisonBasket> _comparisonBasketRepository;
        private readonly IRepository<ComparisonBasketItem> _comparisonBasketItemRepository;
        private readonly Func<ISpecification<ComparisonBasket>> _comparisonBasketSpecificationFunc;
        private Func<string, ISpecification<ComparisonBasket>> _getBasketByUserSpecificationFunc;


        public ComparisonBasketSevice(
            IRepository<ComparisonBasket> comparisonBasketRepository,
            IRepository<ComparisonBasketItem> comparisonBasketItemRepository,
            Func<ISpecification<ComparisonBasket>> comparisonBasketSpecificationFunc
            )
        {
            _comparisonBasketRepository = comparisonBasketRepository;
            _comparisonBasketItemRepository = comparisonBasketItemRepository;
            _comparisonBasketSpecificationFunc = comparisonBasketSpecificationFunc;
            _getBasketByUserSpecificationFunc =
                userId => _comparisonBasketSpecificationFunc().ConfigyreSpecificaton(cb => cb.UserId == userId);
        }

        public async Task AddItemToBasket(int basketId, int catalogItemId, string discriminator)
        {
            var basket = await _comparisonBasketRepository.GetById(basketId);

            basket.AddItem(catalogItemId, discriminator);
            await _comparisonBasketRepository.Update(basket);
        }

        public async Task AddItemToBasket(string userId, int catalogItemId, string discriminator)
        {
            var spec = _getBasketByUserSpecificationFunc(userId);
            var basket = await _comparisonBasketRepository.GetFirstOrDefault(spec);

            basket.AddItem(catalogItemId, discriminator);

            await _comparisonBasketRepository.Update(basket);
        }


        public async Task DeleteItemFromBasket(int basketId, int catalogItemId)
        {
            // It need test
            var basket = await _comparisonBasketRepository.GetById(basketId);

            var item = basket.Items.SingleOrDefault(i => i.Id == basketId);
            await _comparisonBasketItemRepository.Delete(item);

            await _comparisonBasketRepository.Update(basket);
        }

        public async Task<ComparisonBasket> GetOrCreateBasketForUser(string userId)
        {
            var spec = _getBasketByUserSpecificationFunc(userId);
            var basket = await _comparisonBasketRepository.GetFirstOrDefault(spec);

            if (basket == null)
            {
                return await CreateBasketForUser(userId);
            }

            return basket;
        }

        public async Task<int> GetBasketItemCount(string userId)
        {
            var spec = _getBasketByUserSpecificationFunc(userId);
            var basket = await _comparisonBasketRepository.GetFirstOrDefault(spec);

            if (basket != null)
            {
                return basket.Items.Count;
            }
            return 0;
        }

        public async Task DeleteBasket(int basketId)
        {
            var basket = await _comparisonBasketRepository.GetById(basketId);
            await DeleteBasket(basket);

        }

        public async Task DeleteBasket(string userId)
        {
            var spec = _getBasketByUserSpecificationFunc(userId);
            var basket = await _comparisonBasketRepository.GetFirstOrDefault(spec);
            await DeleteBasket(basket);

        }

        #region Utilities
        private async Task<ComparisonBasket> CreateBasketForUser(string userId)
        {
            var basket = new ComparisonBasket() { UserId = userId };
            await _comparisonBasketRepository.Add(basket);
            return basket;
        }

        private async Task DeleteBasket(ComparisonBasket basket)
        {
            if (basket != null)
            {
                //foreach (var comparisonBasketItem in basket.Items.ToList())
                //{
                //    await _comparisonBasketItemRepository.Delete(comparisonBasketItem);
                //    basket.DeleteItem(comparisonBasketItem.Id);
                //}

                await _comparisonBasketRepository.Delete(basket);
            }
        }

        #endregion
    }
}