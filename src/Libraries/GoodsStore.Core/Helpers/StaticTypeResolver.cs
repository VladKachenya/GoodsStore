using System;

namespace GoodsStore.Core.Helpers
{
    public static class StaticTypeResolver
    {
        private static IServiceProvider _serviceProvider;

        public static void SetServiseProvaider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T Resolve<T>() where T : class
        {
            return (T)Resolve(typeof(T));
        }

        public static object Resolve(Type type)
        {
            return _serviceProvider.GetService(type);
        }
    }
}