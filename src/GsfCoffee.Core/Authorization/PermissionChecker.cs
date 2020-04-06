using Abp.Authorization;
using GsfCoffee.Authorization.Roles;
using GsfCoffee.Authorization.Users;

namespace GsfCoffee.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
