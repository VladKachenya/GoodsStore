using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Factories;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Models;
using GoodsStore.Web.Framework.Models.FilterParametrs;

namespace GoodsStore.Web.Framework.App
{
    public class WebFrameworkDependenciesRegistrar : IDependenciesRegistrar 
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            // Filter parametrs
            containerBuilder.RegisterType<PhraseFilterParametr, IPhraseFilterParametr>();
            containerBuilder.RegisterType<RangeFilterParametr, IRangeFilterParametr>();
            containerBuilder.RegisterType<SelectableListFilterParametr, ISelectableListFilterParametr>();

            // Factories
            containerBuilder.RegisterType<ParametrFactory, IParametrFactory>();

            containerBuilder.RegisterGeneric(typeof(GeneratorsDictionary<>), typeof(IGeneratorsDictionary<>));

            containerBuilder.RegisterType<BaseCatalogItemParametrsGenerator<CatalogItem>, IParametrsGenerator>();
            containerBuilder.RegisterType<BaseTableItemsGenerator, ITableItemsGenerator>();

            containerBuilder.RegisterType<TableItem, ITableItem>();
        }
    }
}