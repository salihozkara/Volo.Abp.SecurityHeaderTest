using Volo.Abp.SecurityHeaderTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Volo.Abp.SecurityHeaderTest.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SecurityHeaderTestPageModel : AbpPageModel
{
    protected SecurityHeaderTestPageModel()
    {
        LocalizationResourceType = typeof(SecurityHeaderTestResource);
    }
}
