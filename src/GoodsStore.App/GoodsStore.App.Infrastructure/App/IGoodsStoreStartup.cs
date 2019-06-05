using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.App.Infrastructure.App
{
    public interface IGoodsStoreStartup
    {
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);

        void Configure(IApplicationBuilder app, IHostingEnvironment environment);

        int Order { get; }
    }
}