using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using TaiKang.Authorization;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : TaiKangControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}