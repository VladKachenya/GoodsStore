using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Hosting;

namespace GoodsStore.App.CompositionRoot.AppConfiguration
{
    public interface IAppConfigurator
    {
        /// <summary>
        /// Add and configure services
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        /// <returns>Service provider</returns>
        IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration);

        /// <summary>
        /// Configure HTTP request pipeline
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        void ConfigureRequestPipeline(IApplicationBuilder application, IHostingEnvironment environment);
    }
}