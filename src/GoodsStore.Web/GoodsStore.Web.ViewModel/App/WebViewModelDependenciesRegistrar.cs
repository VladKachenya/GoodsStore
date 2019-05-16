using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Web.ViewModel.Factories;
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


            // Servicies registration
            containerBuilder.RegisterType<CategoryModelService, ICategoryModelService>();
        }
    }
}