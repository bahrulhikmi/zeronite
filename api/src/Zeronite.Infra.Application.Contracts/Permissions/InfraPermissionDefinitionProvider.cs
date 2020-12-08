using Zeronite.Infra.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zeronite.Infra.Permissions
{
    public class InfraPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(InfraPermissions.GroupName);

            var permission = myGroup.AddPermission(InfraPermissions.Books.Default, L("Permission:Books"));
            permission.AddChild(InfraPermissions.Books.Create, L("Permission:Books.Create"));
            permission.AddChild(InfraPermissions.Books.Edit, L("Permission:Books.Edit"));
            //Define your own permissions here. Example:
            //myGroup.AddPermission(InfraPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<InfraResource>(name);
        }
    }
}
