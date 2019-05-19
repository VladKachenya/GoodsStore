using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Core.Domain.Specifications
{
    public class CatalogItemSelectionSpecification : BaseSpecification<CatalogItem>, ICatalogItemSelectionSpecification
    {
        //public CatalogItemSelectionSpecification(int typeId, int skip = 0, int take = 6) 
        //    : base(ci => ci.ItemTypeId == typeId)
        //{
        //    ApplyPaging(skip, take);
        //}
    }
}