using System.Reflection;
using System.Security.Permissions;

namespace UserManagementWIthIdentity.Contants;

public static class Permissions
{
    public const string PermissionsName = "Permission";
    public static List<string> GeneratePermissionsList(string module)
    {
        return new List<string>()
            {
                $"{PermissionsName}.{module}.View",
                $"{PermissionsName}.{module}.Create",
                $"{PermissionsName}.{module}.Edit",
                $"{PermissionsName}.{module}.Delete"
            };
    }

    public static List<string> GenerateAllPermissions()
    {
        var allPermissions = new List<string>();

        var modules = Enum.GetValues(typeof(Modules));

        foreach (var module in modules)
            allPermissions.AddRange(GeneratePermissionsList(module.ToString()));

        return allPermissions;
    }

    public static class Products
    {
        public const string View = $"{PermissionsName}.Products.View";
        public const string Create = $"{PermissionsName}.Products.Create";
        public const string Edit = $"{PermissionsName}.Products.Edit";
        public const string Delete = $"{PermissionsName}.Products.Delete";
    }
}

