using GoodsStore.Core.Entities.Base;

namespace GoodsStore.Core.Entities
{
    public class ItemType :BaseEntity
    {
        public string TypeName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}