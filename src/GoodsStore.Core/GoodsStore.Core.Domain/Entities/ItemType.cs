using GoodsStore.Core.Domain.Entities.Base;
using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Helpers;

namespace GoodsStore.Core.Domain.Entities
{
    public class ItemType :BaseEntity
    {
        public string UnitName { get; set; }
        public string TypeDiscriminator { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<BrandItemType> BrandItemTypes { get; set; }
    }
}