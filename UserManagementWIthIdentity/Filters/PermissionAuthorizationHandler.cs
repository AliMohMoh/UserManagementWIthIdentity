using Microsoft.AspNetCore.Authorization;
using UserManagementWIthIdentity.Contants;

namespace UserManagementWIthIdentity.Filters;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    public PermissionAuthorizationHandler()
    {

    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        if (context.User == null)
            return;

        var canAccess = context.User.Claims.Any(c => c.Type == Permissions.PermissionsName.ToString() && c.Value == requirement.Permission && c.Issuer == "LOCAL AUTHORITY");

        if (canAccess)
        {
            context.Succeed(requirement);
            return;
        }
    }
}