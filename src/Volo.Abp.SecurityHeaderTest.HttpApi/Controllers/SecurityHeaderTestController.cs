using Volo.Abp.SecurityHeaderTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Volo.Abp.SecurityHeaderTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SecurityHeaderTestController : AbpControllerBase
{
    protected SecurityHeaderTestController()
    {
        LocalizationResource = typeof(SecurityHeaderTestResource);
    }
}
