using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities.BasketAggregate
{
    public class Basket : BaseData
    {
        public string UserId { get; set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public virtual IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();

        public void AddItem(int catalogItemId, string discriminator)
        {
            if (Items.All(i => i.CatalogItemId != catalogItemId))
            {
                _items.Add(new BasketItem()
                {
                    CatalogItemId = catalogItemId,
                    Discriminator = discriminator
                });
                return;
            }
        }
    }
}