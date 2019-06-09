using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities.BasketAggregate
{
    public class BasketItem : BaseData
    {
        public string Discriminator { get; set; }
        public int CatalogItemId { get; set; }
    }
}