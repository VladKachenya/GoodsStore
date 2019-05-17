using System;
using System.Linq.Expressions;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Core.Specifications
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