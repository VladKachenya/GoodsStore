using GoodsStore.Core.Entities.Base;

namespace GoodsStore.Core.Entities
{
    public class ItemType :BaseEntity
    {
        public string UnitName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}