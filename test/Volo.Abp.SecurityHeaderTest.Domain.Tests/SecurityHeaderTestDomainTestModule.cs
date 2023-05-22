using Volo.Abp.SecurityHeaderTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Volo.Abp.SecurityHeaderTest;

[DependsOn(
    typeof(SecurityHeaderTestEntityFrameworkCoreTestModule)
    )]
public class SecurityHeaderTestDomainTestModule : AbpModule
{

}
