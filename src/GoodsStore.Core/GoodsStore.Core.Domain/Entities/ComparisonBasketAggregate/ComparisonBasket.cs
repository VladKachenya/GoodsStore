using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate
{
    public class ComparisonBasket : BaseData
    {
        public string UserId { get; set; }
        private readonly List<ComparisonBasketItem> _items = new List<ComparisonBasketItem>();
        public virtual IReadOnlyCollection<ComparisonBasketItem> Items => _items.AsReadOnly();

        public void AddItem(int catalogItemId, string discriminator)
        {
            if (Items.All(i => i.CatalogItemId != catalogItemId))
            {
                _items.Add(new ComparisonBasketItem()
                {
                    CatalogItemId = catalogItemId,
                    Discriminator = discriminator
                });
                return;
            }
        }

        public void DeleteItem(int itemId)
        {
            var item = _items.SingleOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _items.Remove(item);
                return;
            }
        }
    }
}