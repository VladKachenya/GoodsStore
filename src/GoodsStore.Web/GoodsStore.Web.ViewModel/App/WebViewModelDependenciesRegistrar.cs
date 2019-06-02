using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Converters;
using GoodsStore.Web.ViewModel.Factories;
using GoodsStore.Web.ViewModel.Factories.ParametrsGenerators;
using GoodsStore.Web.ViewModel.Factories.TableItemsGenerator;
using GoodsStore.Web.ViewModel.Interfaces.Converters;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Interfaces.Servicies;
using GoodsStore.Web.ViewModel.Servicies;

namespace GoodsStore.Web.ViewModel.App
{
    public class WebViewModelDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            // Factories registration
            containerBuilder.RegisterType<CategoryModelFactory, ICategoryModelFactory>();
            containerBuilder.RegisterType<CatalogItemModelFactory, ICatalogItemModelFactory>();
            containerBuilder.RegisterType<GoodsIndexModelFactory, IGoodsIndexModelFactory>();
            containerBuilder.RegisterType<ModelFilterToPredictionConverter, IModelFilterToPredictionConverter>();

            // Parametr generators
            containerBuilder.RegisterType<RefrigeratorParametrsesGenerator, IParametrsGenerator>();
            containerBuilder.RegisterType<MobilePhoneParametrsGenerator, IParametrsGenerator>();

            // Table items generators
            containerBuilder.RegisterType<RefrigeratorTableItemsGenerator, ITableItemsGenerator>();

            // Servicies registration
            containerBuilder.RegisterType<CategoryModelService, ICategoryModelService>();
        }
    }
}