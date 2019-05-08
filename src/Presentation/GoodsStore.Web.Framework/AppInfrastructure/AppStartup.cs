using GoodsStore.Core.Interfaces.AppInfrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Web.Framework.AppInfrastructure
{
    public class AppStartup : IAppStartup
    {
        public int Order => 20;
        public void Configure(IApplicationBuilder application)
        {
            application.UseHttpsRedirection();
            application.UseStaticFiles();
            application.UseCookiePolicy();

            application.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc();

        }
    }
}