using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace TaiKang.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// Add your methods to this class common for all controllers.
    /// </summary>
    public abstract class TaiKangControllerBase : AbpController
    {
        protected TaiKangControllerBase()
        {
            LocalizationSourceName = TaiKangConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}