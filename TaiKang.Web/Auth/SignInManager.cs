using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using Microsoft.Owin.Security;
using TaiKang.Authorization.Roles;
using TaiKang.Authorization.Users;
using TaiKang.MultiTenancy;

namespace TaiKang.Web.Auth
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager, 
            IAuthenticationManager authenticationManager, 
            ISettingManager settingManager,
            IUnitOfWorkManager unitOfWorkManager) 
            : base(
                  userManager, 
                  authenticationManager,
                  settingManager,
                  unitOfWorkManager)
        {
        }
    }
}