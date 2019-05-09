using GoodsStore.Core.Interfaces.AppInfrastructure;
using GoodsStore.Infrastructure.Data;
using GoodsStore.Web.Framework.AppInfrastructure.Extentions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
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

            application.UseGoodsStoreMvc();
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogDbContext>();
            services.AddMvc();
        }
    }
}