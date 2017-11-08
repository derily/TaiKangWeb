using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaiKang.Authorization;
using TaiKang.Tk;
using TaiKang.Web.Areas.Mpa.Models.Jobs;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    public class JobController : TaiKangControllerBase
    {
        private readonly IJobChanceAppService _jobChanceService;

        public JobController(IJobChanceAppService service)
        {
            _jobChanceService = service;
        }
        public ActionResult Index()
        {
            return View();
        }


        [AbpMvcAuthorize(AppPermissions.Pages_TaiKang_JobChance_Create, AppPermissions.Pages_TaiKang_JobChance_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
            var output = await _jobChanceService.GetJobForEdit(new NullableIdDto<int> { Id = id });
            var viewModel = new CreateOrEditJobModalViewModel(output);
            return PartialView("_CreateOrEditModal", viewModel);
        }
    }
}