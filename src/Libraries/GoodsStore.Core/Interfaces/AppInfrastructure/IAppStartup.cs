using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsStore.Core.Interfaces.AppInfrastructure
{
    public interface IAppStartup
    {
        int Order { get; }
        void Configure(IApplicationBuilder application);

        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
    }
}