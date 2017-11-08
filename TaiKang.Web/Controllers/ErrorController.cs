using System.Web.Mvc;
using Abp.Auditing;

namespace TaiKang.Web.Controllers
{
    public class ErrorController : TaiKangControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}