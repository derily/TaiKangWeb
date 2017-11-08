using Abp.Domain.Repositories;
using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaiKang.Authorization;
using TaiKang.Tk;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_TaiKang_CompanyIndroduce)]
    public class CompanyIntroduceController : TaiKangControllerBase
    {
        private readonly IRepository<CompanyIntroduce> _companyIntroduceRepository;
        public CompanyIntroduceController(IRepository<CompanyIntroduce> companyIntroduceRepostory)
        {
            _companyIntroduceRepository = companyIntroduceRepostory;

        }
        // GET: Mpa/Organ
        public ActionResult Index()
        {
            var introduce = _companyIntroduceRepository.Get(1);
            return View(introduce);
        }

        public async Task<ActionResult> Save(CompanyIntroduce input)
        {
            await _companyIntroduceRepository.UpdateAsync(input);
            return RedirectToAction("Index");
        }
    }
}