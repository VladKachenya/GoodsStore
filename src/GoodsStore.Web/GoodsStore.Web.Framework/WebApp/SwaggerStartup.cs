using GoodsStore.App.Infrastructure.App;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Web.Framework.WebApp
{
    public class SwaggerStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Goods store API" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Goods store API");
            });
        }

        public int Order => 999;
    }
}