using GoodsStore.App.CompositionRoot.AppConfiguration;

namespace GoodsStore.App.CompositionRoot
{
    public class AppConfiguratorContext
    {
        protected static IAppConfigurator _current;

        public static IAppConfigurator Current => _current ?? (_current = new GoodsStoreConfigurator());
    }
}