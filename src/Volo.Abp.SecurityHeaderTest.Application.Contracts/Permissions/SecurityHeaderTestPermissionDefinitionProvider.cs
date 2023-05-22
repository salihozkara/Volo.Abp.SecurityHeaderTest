using Volo.Abp.SecurityHeaderTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Volo.Abp.SecurityHeaderTest.Permissions;

public class SecurityHeaderTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SecurityHeaderTestPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SecurityHeaderTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SecurityHeaderTestResource>(name);
    }
}
