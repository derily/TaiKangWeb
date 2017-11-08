using System.Web.Mvc;

namespace TaiKang.Web.Controllers
{
    public class AboutController : TaiKangControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}