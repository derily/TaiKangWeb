using Abp.Authorization;
using TaiKang.Authorization.Roles;
using TaiKang.Authorization.Users;
using TaiKang.MultiTenancy;

namespace TaiKang.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
