using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.App.CompositionRoot.Extentions
{
    public static class ConfigureApplicationExtenion
    {
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            return AppConfiguratorContext.Current.ConfigureServices(services, configuration);
        }

        public static void ConfigureRequestPipeline(this IApplicationBuilder application, IHostingEnvironment hostingEnvironment)
        {
            AppConfiguratorContext.Current.ConfigureRequestPipeline(application, hostingEnvironment);
        }
    }
}