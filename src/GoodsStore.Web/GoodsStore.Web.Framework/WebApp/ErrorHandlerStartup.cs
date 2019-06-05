using GoodsStore.App.Infrastructure.App;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Web.Framework.WebApp
{
    public class ErrorHandlerStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //throw new System.NotImplementedException();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
        }

        public int Order => 0;
    }
}