using GoodsStore.App.Infrastructure.App;
using GoodsStore.Data.Identity.IdentityEntities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Data.Identity.App
{
    public class IdentityStartup : IGoodsStoreStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GoodsStoreIdentetyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<GoodsStoreUser, GoodsStoreRole>()
                .AddEntityFrameworkStores<GoodsStoreIdentetyDbContext>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            app.UseAuthentication();
        }

        public int Order => 100;
    }
}