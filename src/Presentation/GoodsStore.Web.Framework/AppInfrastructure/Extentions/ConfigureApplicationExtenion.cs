using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using GoodsStore.Core.AppInfrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Web.Framework.AppInfrastructure.Extentions
{
    public static class ConfigureApplicationExtenion
    {
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            return AppConfiguratorContext.Current.ConfigureServices(services, configuration);
        }
    }
}