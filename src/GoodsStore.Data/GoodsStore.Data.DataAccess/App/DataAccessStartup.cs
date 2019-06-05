using GoodsStore.App.Infrastructure.App;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Data.DataAccess.App
{
    public class DataAccessStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GoodsStoreDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("CatalogConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
        }

        public int Order => 100;
    }
}