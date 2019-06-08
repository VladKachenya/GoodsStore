using System;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Core.Logic.Specifications
{
    public class CatalogItemFiltringSpecification<T> : Specification<T>, ICatalogItemFiltringSpecification<T>, ICatalogItemFiltringSpecification
    {

        public ICatalogItemFiltringSpecification ConfigyreSpecificaton(object filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException();
            }
            if (!(filter is IDynamicFilter<T>))
            {
                throw new ArgumentException($"Argument must be the {nameof(IDynamicFilter<T>)} type!");
            }
            var dynamicFilter = filter as IDynamicFilter<T>;
            return ConfigyreSpecificaton(dynamicFilter) as ICatalogItemFiltringSpecification;
        }

        public ISpecification<T> ConfigyreSpecificaton(IDynamicFilter<T> dynamicFilter)
        {
            return base.ConfigyreSpecificaton(dynamicFilter.GetLambda());
        }
    }
}