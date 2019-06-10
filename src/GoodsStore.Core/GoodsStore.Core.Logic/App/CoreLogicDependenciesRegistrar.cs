using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Infrastructure.Hepers;
using GoodsStore.Core.Infrastructure.Services;
using GoodsStore.Core.Logic.Filter;
using GoodsStore.Core.Logic.Filter.ExpressionGenerators;
using GoodsStore.Core.Logic.Helpers;
using GoodsStore.Core.Logic.Services;
using GoodsStore.Core.Logic.Specifications;

namespace GoodsStore.Core.Logic.App
{
    public class CoreLogicDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterGeneric(typeof(CatalogItemFilter<>), typeof(IDynamicFilter<>));

            containerBuilder.RegisterType<FilterConfigurator, IFilterConfigurator>();
            containerBuilder.RegisterType<PropertyNameValidator, IPropertyNameValidator>();

            containerBuilder.RegisterType<CatalogItemTypeDictionary>(true);

            //expression generators
            containerBuilder.RegisterType<ContainsExpressionGenerator, IExpressionGenerator>();
            containerBuilder.RegisterType<FromRangeExpressionGenerator, IExpressionGenerator>();
            containerBuilder.RegisterType<IncludeInGorupExpressionGenerator, IExpressionGenerator>();

            containerBuilder.RegisterGeneric(typeof(Specification<>), typeof(ISpecification<>));
            containerBuilder.RegisterGeneric(typeof(CatalogItemFiltringSpecification<>), typeof(ICatalogItemFiltringSpecification<>));

            //Servicies
            containerBuilder.RegisterType<ComparisonBasketSevice, IComparisonBasketSevice>();
        }
    }
}