using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.SecurityHeaderTest.Data;

/* This is used if database provider does't define
 * ISecurityHeaderTestDbSchemaMigrator implementation.
 */
public class NullSecurityHeaderTestDbSchemaMigrator : ISecurityHeaderTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
