using Volo.Abp.Modularity;

namespace Volo.Abp.SecurityHeaderTest;

[DependsOn(
    typeof(SecurityHeaderTestApplicationModule),
    typeof(SecurityHeaderTestDomainTestModule)
    )]
public class SecurityHeaderTestApplicationTestModule : AbpModule
{

}
