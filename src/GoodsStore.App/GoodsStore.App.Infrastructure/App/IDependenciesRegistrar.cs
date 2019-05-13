using GoodsStore.App.Infrastructure.IoC;

namespace GoodsStore.App.Infrastructure.App
{
    public interface IDependenciesRegistrar
    {
        void Register(IContainerBuilder containerBuilder);
    }
}