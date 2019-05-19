using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Web.Framework.Factories;
using GoodsStore.Web.Framework.Factories.ParametrsGenerators;
using GoodsStore.Web.Framework.Models.Parametrs;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.App
{
    public class WebFrameworkDependenciesRegistrar : IDependenciesRegistrar 
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<PhraseParametr, IPhraseParametr>();
            containerBuilder.RegisterType<RangeParametr, IRangeParametr>();
            containerBuilder.RegisterType<SelectableListParametr, ISelectableListParametr>();

            containerBuilder.RegisterType<CatalogItemParametersFactory, ICatalogItemParametersFactory>();
            containerBuilder.RegisterType<ParametrFactory, IParametrFactory>();

            containerBuilder.RegisterType<RefrigeratorParametrsesGenerator, IParametrsGenerator>();
            containerBuilder.RegisterType<MobilePhoneParametrsGenerator, IParametrsGenerator>();
        }
    }
}