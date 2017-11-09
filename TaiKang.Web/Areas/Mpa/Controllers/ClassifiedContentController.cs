using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaiKang.Tk;
using TaiKang.Tk.Dto;
using TaiKang.Web.Areas.Mpa.Models.ClassifiedContent;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    public class ClassifiedContentController : TaiKangControllerBase
    {
        private readonly IClassifiedContentAppService _contentAppService;
        public ClassifiedContentController(IClassifiedContentAppService service)
        {
            _contentAppService = service;
        }
        // GET: Mpa/ClassifiedContent
        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> CreateContentModal(int? id)
        {
            ClassifiedContentDto content = new ClassifiedContentDto();
            if (id.HasValue)
            {
                content =await _contentAppService.Get(new ClassifiedContentDto { Id = id.Value });
            }
            var viewModel = new CreateOrEditModalViewModel(content);
            return PartialView("_CreateOrEditContentModal", viewModel);
        }
    }
}