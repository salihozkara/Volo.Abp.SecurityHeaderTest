using Volo.Abp.SecurityHeaderTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Volo.Abp.SecurityHeaderTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SecurityHeaderTestEntityFrameworkCoreModule),
    typeof(SecurityHeaderTestApplicationContractsModule)
    )]
public class SecurityHeaderTestDbMigratorModule : AbpModule
{

}
