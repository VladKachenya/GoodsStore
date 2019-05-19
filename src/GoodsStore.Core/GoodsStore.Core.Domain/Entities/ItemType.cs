using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities
{
    public class ItemType :BaseEntity
    {
        public string UnitName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}