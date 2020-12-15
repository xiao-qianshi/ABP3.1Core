using Abp.Authorization;
using LYP.BH.Authorization.Roles;
using LYP.BH.Authorization.Users;

namespace LYP.BH.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
