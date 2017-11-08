using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TaiKang.Web.Areas.Mpa.Models.Common.Modals;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : TaiKangControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}