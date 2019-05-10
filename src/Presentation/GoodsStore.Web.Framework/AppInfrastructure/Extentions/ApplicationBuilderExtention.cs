using GoodsStore.Core.AppInfrastructure;
using GoodsStore.Core.Helpers;
using GoodsStore.Web.Framework.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace GoodsStore.Web.Framework.AppInfrastructure.Extentions
{
    public static class ApplicationBuilderExtention
    {
        public static void ConfigureRequestPipeline(this IApplicationBuilder application, IHostingEnvironment hostingEnvironment)
        {
            AppConfiguratorContext.Current.ConfigureRequestPipeline(application);
        }

        public static void UseGoodsStoreMvc(this IApplicationBuilder application)
        {
            application.UseMvc(routeBuilder =>
            {
                //register all routes
                StaticTypeResolver.Resolve<IRoutePublisher>().RegisterRoutes(routeBuilder);
            });
        }
    }
}