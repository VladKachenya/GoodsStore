using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.Framework.Interfaces
{
    public interface IRoutePublisher
    {
        void RegisterRoutes(IRouteBuilder routeBuilder);

    }
}