using GoodsStore.Data.DataAccess;
using GoodsStore.Web.Infrastructure.WebApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GoodsStore.App.CompositionRoot.WebApp
{
    public class GoodsStoreDbStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GoodsStoreDbContext>();
            //add EF services
            services.AddEntityFrameworkSqlServer();
        }

        public void Configure(IApplicationBuilder application, IHostingEnvironment environment)
        {

        }

        public int Order => 10;
    }
}