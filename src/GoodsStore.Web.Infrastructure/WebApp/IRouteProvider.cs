using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.Infrastructure.WebApp
{
    public interface IRouteProvider
    {
        void RegisterRoutes(IRouteBuilder routeBuilder);

        int Priority { get; }
    }
}