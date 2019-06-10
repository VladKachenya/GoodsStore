using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate
{
    public class ComparisonBasketItem : BaseData
    {
        public string Discriminator { get; set; }
        public int CatalogItemId { get; set; }
    }
}