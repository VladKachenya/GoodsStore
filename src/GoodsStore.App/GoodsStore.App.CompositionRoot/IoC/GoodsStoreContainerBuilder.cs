using System;
using Autofac;
using GoodsStore.App.Infrastructure.IoC;

namespace GoodsStore.App.CompositionRoot.IoC
{
    public class GoodsStoreContainerBuilder : IContainerBuilder
    {
        private readonly ContainerBuilder _containerBuilder;

        public GoodsStoreContainerBuilder(ContainerBuilder containerBuilder)
        {
            _containerBuilder = containerBuilder;
        }
        public void RegisterType(Type t, bool isSingleton = false)
        {
            var res = _containerBuilder.RegisterType(t).AsSelf();
            if (isSingleton) res.SingleInstance();
        }
        public void RegisterGeneric(Type tFrom, Type tTo)
        {
            _containerBuilder.RegisterGeneric(tFrom).As(tTo);
        }


        public void RegisterType<TFrom, TTo>(bool isSingleton = false) where TTo : TFrom
        {
            var res = _containerBuilder.RegisterType<TTo>().As<TFrom>();
            if (isSingleton) res.SingleInstance();
        }

        public void RegisterType<T>(bool isSingleton = false)
        {
            RegisterType(typeof(T), isSingleton);
        }

        public void RegisterType<TFrom, TTo>(string key, bool isSingleton = false) where TTo : TFrom
        {
            var res = _containerBuilder.RegisterType<TTo>().As<TFrom>().Keyed<string>(key);
            if (isSingleton) res.SingleInstance();
        }

       
    }
}