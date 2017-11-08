using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : TaiKangControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}