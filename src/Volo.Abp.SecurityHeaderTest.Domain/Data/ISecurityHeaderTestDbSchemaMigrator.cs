using System.Threading.Tasks;

namespace Volo.Abp.SecurityHeaderTest.Data;

public interface ISecurityHeaderTestDbSchemaMigrator
{
    Task MigrateAsync();
}
