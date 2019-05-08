using GoodsStore.Core.AppInfrastructure;
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
    }
}