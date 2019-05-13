using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Core.Specifications
{
    public class CatalogItemFilterSpecification : BaseSpecification<CatalogItem>, ICatalogItemFilterSpecification
    {
        public CatalogItemFilterSpecification(IEnumerable<int> brandIds, IEnumerable<int> typeIds, int skip, int take)
            : this(brandIds, typeIds)
        {
            ApplyPaging(skip, take);
        }

        public CatalogItemFilterSpecification(IEnumerable<int> brandIds, IEnumerable<int> typeIds)
            : base(i => (brandIds == null || !brandIds.Any() || brandIds.Any(b => i.BrandId == b))
                        && (typeIds == null || !typeIds.Any() || typeIds.Any(b => i.ItemTypeId == b)))
        {

        }
    }
}