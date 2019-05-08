using GoodsStore.Core.Interfaces.AppInfrastructure;

namespace GoodsStore.Core.AppInfrastructure
{
    public class AppConfiguratorContext
    {
        protected static IAppConfigurator _current;

        public static IAppConfigurator Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new GoodsStoreConfigurator();
                }
                return _current;
            }
        }
    }
}