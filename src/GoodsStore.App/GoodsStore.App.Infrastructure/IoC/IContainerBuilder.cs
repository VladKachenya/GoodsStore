using System;

namespace GoodsStore.App.Infrastructure.IoC
{
    public interface IContainerBuilder
    {
        void RegisterType(Type t, bool isSingleton = false);
        void RegisterType<TFrom, TTo>(bool isSingleton = false) where TTo : TFrom;
        void RegisterType<T>(bool isSingleton = false);

        void RegisterType<TFrom, TTo>(string key, bool isSingleton = false) where TTo : TFrom;

        void RegisterGeneric(Type tFrom, Type tTo);
    }
}