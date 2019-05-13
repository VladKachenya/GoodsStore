using System;
using GoodsStore.Data.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.App.CompositionRoot.AppConfiguration.Extentions
{
    public static class ConfigureApplicationExtenion
    {
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            services.AddDbContext<GoodsStoreDbContext>();
            return AppConfiguratorContext.Current.ConfigureServices(services, configuration);
        }

        public static void ConfigureRequestPipeline(this IApplicationBuilder application, IHostingEnvironment hostingEnvironment)
        {
            AppConfiguratorContext.Current.ConfigureRequestPipeline(application, hostingEnvironment);
        }
    }
}