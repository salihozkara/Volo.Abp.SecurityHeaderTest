using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Volo.Abp.SecurityHeaderTest;

public class SecurityHeaderTestWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SecurityHeaderTestWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
