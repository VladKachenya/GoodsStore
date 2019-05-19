using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Core.Domain.Specifications
{
    public class CatalogItemFilterSpecification : BaseSpecification<CatalogItem>, ICatalogItemFilterSpecification
    {
        //public CatalogItemFilterSpecification(IEnumerable<int> brandIds, IEnumerable<int> typeIds, int skip, int take)
        //    : this(brandIds, typeIds)
        //{
        //    ApplyPaging(skip, take);
        //}

        //public CatalogItemFilterSpecification(IEnumerable<int> brandIds, IEnumerable<int> typeIds)
        //    : base(i => (brandIds == null || !brandIds.Any() || brandIds.Any(b => i.BrandId == b))
        //                && (typeIds == null || !typeIds.Any() || typeIds.Any(b => i.ItemTypeId == b)))
        //{

        //}
    }
}