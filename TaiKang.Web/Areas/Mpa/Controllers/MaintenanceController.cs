using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TaiKang.Authorization;
using TaiKang.Caching;
using TaiKang.Web.Areas.Mpa.Models.Maintenance;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : TaiKangControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items
            };

            return View(model);
        }
    }
}