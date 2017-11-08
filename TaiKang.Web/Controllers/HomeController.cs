using System.Web.Mvc;

namespace TaiKang.Web.Controllers
{
    public class HomeController : TaiKangControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}