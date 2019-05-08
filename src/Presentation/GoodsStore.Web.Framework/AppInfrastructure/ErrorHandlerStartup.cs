using GoodsStore.Core.Interfaces.AppInfrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Web.Framework.AppInfrastructure
{
    public class ErrorHandlerStartup : IAppStartup
    {
        public int Order  => 0;
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseDeveloperExceptionPage();
        }

        
    }
}