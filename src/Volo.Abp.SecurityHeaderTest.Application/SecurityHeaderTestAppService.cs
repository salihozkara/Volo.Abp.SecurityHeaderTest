using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.SecurityHeaderTest.Localization;
using Volo.Abp.Application.Services;

namespace Volo.Abp.SecurityHeaderTest;

/* Inherit your application services from this class.
 */
public abstract class SecurityHeaderTestAppService : ApplicationService
{
    protected SecurityHeaderTestAppService()
    {
        LocalizationResource = typeof(SecurityHeaderTestResource);
    }
}
