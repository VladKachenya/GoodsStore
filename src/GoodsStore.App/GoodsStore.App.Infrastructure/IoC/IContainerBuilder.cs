using System;

namespace GoodsStore.App.Infrastructure.IoC
{
    public interface IContainerBuilder
    {
        void RegisterType(Type tTo, bool isSingleton = false);
        void RegisterGeneric(Type tTo, Type tFrom);

        void RegisterType<TTo, TFrom>(bool isSingleton = false) where TTo : TFrom;
        void RegisterType<TTo>(bool isSingleton = false);

        void RegisterType<TTo, TFrom>(string key, bool isSingleton = false) where TTo : TFrom;
    }
}