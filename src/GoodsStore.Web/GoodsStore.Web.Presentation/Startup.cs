using GoodsStore.App.CompositionRoot.AppConfiguration.Extentions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GoodsStore.Web.Presentation
{
    public class Startup
    {
        private IHostingEnvironment _hostingEnvironment;
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            return services.ConfigureApplicationServices(_configuration, _hostingEnvironment);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.ConfigureRequestPipeline(env);
        }
    }
}
