using Autofac;

namespace GoodsStore.Core.Interfaces.AppInfrastructure
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        int Order { get; }
    }
}