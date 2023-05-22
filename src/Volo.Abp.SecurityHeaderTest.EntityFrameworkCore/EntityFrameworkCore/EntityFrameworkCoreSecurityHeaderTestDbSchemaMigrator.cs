using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.SecurityHeaderTest.Data;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.SecurityHeaderTest.EntityFrameworkCore;

public class EntityFrameworkCoreSecurityHeaderTestDbSchemaMigrator
    : ISecurityHeaderTestDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSecurityHeaderTestDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SecurityHeaderTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SecurityHeaderTestDbContext>()
            .Database
            .MigrateAsync();
    }
}
