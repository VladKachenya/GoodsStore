using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.Framework.Interfaces.WebApp
{
    public interface IRouteProvider
    {
        void RegisterRoutes(IRouteBuilder routeBuilder);

    }
}