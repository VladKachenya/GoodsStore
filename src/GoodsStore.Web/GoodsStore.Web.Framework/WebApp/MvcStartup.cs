using GoodsStore.App.Infrastructure.App;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using React.AspNet;


namespace GoodsStore.Web.Framework.WebApp
{
    public class MvcStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}");
                routes.MapRoute(
                    "goods-catalog",
                    "Goods/{typeDiscriminator}",
                    new { controller = "Goods", action = "Index" });

                routes.MapRoute(
                    "goods-catalog-item",
                    "Goods/{typeDiscriminator}/{id}",
                    new { controller = "Goods", action = "Item" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public int Order => 1000;
    }
}