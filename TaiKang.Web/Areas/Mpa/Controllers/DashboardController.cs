using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TaiKang.Authorization;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : TaiKangControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}