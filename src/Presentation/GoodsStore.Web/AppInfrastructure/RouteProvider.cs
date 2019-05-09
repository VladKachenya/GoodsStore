using GoodsStore.Web.Framework.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.AppInfrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("HomePage", "", new { controller = "Home", action = "Index" });
            routeBuilder.MapRoute("AboutPage", "about/", new { controller = "Home", action = "About" });
            routeBuilder.MapRoute("ContactPage", "contact/", new { controller = "Home", action = "Contact" });
            routeBuilder.MapRoute("PrivacyPage", "privacy/", new { controller = "Home", action = "Privacy" });



            //routeBuilder.MapRoute(
            //    name: "default",
            //    template: "{controller=Home}/{action=Index}/{id?}");
        }

        public int Priority => 0;
    }
}