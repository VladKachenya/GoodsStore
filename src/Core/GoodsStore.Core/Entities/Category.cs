using GoodsStore.Core.Entities.Base;
using System.Collections.Generic;

namespace GoodsStore.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            ItemTypes = new List<ItemType>();
        }
        public virtual List<ItemType> ItemTypes { get; set; }
    }
}