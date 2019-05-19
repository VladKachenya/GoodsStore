using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Entities.Helpers;

namespace GoodsStore.Core.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public virtual List<BrandItemType> BrandItemTypes { get; set; }
    }
}