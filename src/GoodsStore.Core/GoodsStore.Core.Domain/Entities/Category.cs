using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities
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