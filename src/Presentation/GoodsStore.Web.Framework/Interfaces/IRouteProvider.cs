using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.Framework.Interfaces
{
    public interface IRouteProvider
    {
        void RegisterRoutes(IRouteBuilder routeBuilder);
        int Priority { get; }
    }
}