using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.SecurityHeaderTest.Web;

[Dependency(ReplaceServices = true)]
public class SecurityHeaderTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SecurityHeaderTest";
}
