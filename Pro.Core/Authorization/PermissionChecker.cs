using Abp.Authorization;
using Pro.Authorization.Roles;
using Pro.Authorization.Users;

namespace Pro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
