namespace GoodsStore.Core.Domain.Specifications
{
    public interface ICatalogItemFiltringSpecification<T> : ISpecification<T>
    {
        ISpecification<T> ConfigyreSpecificaton(IDynamicFilter<T> dynamicFilter);
    }

    public interface ICatalogItemFiltringSpecification : IPagingConfigurator
    {
        ICatalogItemFiltringSpecification ConfigyreSpecificaton(object filter);
    }
}