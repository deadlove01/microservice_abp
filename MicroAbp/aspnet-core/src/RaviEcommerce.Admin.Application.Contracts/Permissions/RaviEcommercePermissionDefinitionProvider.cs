using RaviEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RaviEcommerce.Permissions;

public class RaviEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RaviEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RaviEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RaviEcommerceResource>(name);
    }
}
