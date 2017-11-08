using Abp.UI;
using Abp.Web.Models;
using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaiKang.Authorization;
using TaiKang.Tk;
using TaiKang.Tk.Dto;
using TaiKang.Utillity;
using TaiKang.Web.Areas.Mpa.Models.Banner;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_TaiKang_BannerManager)]
    public class BannerManagerController : TaiKangControllerBase
    {
        private readonly IBannerAppService_ _bannerAppService;
        private readonly IAppFolders _appFolders;
        public BannerManagerController(IBannerAppService_ bannerAppService, IAppFolders appFolders)
        {
            _bannerAppService = bannerAppService;
            _appFolders = appFolders;
        }
        // GET: Mpa/BannerManager
        public async Task<ActionResult> Index()
        {
            var item=await  _bannerAppService.GetAll(new Abp.Application.Services.Dto.PagedAndSortedResultRequestDto());
            var model = new IndexViewModel(item);
            return View(model);
        }

        //public PartialViewResult CreateBannerModal()
        //{
          
        //    return PartialView("_CreateOrEditBannerModal");
        //}

        public JsonResult UploadBannerImage()
        {
            try
            {
                //Check input
                if (Request.Files.Count <= 0 || Request.Files[0] == null)
                {
                    throw new UserFriendlyException(L("ProfilePicture_Change_Error"));
                }

                var file = Request.Files[0];

                if (file.ContentLength > 1048576) //1MB.
                {
                    throw new UserFriendlyException(L("ProfilePicture_Warn_SizeLimit"));
                }

                //Check file type & format
                //var fileImage = Image.FromStream(file.InputStream);
                //var acceptedFormats = new List<ImageFormat>
                //{
                //    ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Gif
                //};

                //if (!acceptedFormats.Contains(fileImage.RawFormat))
                //{
                //    throw new ApplicationException("Uploaded file is not an accepted image file !");
                //}

                //Delete old temp profile pictures
                //AppFileHelper.DeleteFilesInFolderIfExists(_appFolders.TempFileDownloadFolder, "userProfileImage_" + AbpSession.GetUserId());

                //Save new picture
                var fileInfo = new FileInfo(file.FileName);
                var tempFileName =Md5.Encryption(file.FileName) + fileInfo.Extension;
                var tempFilePath = Path.Combine(_appFolders.WebSiteImageFolder, tempFileName);
                file.SaveAs(tempFilePath);

                using (var bmpImage = new Bitmap(tempFilePath))
                {
                    return Json(new AjaxResponse(new { fileName = tempFileName, width = bmpImage.Width, height = bmpImage.Height }));
                }
            }
            catch (UserFriendlyException ex)
            {
                return Json(new AjaxResponse(new ErrorInfo(ex.Message)));
            }
        }

        [AbpMvcAuthorize(AppPermissions.Pages_TaiKang_BannerManager_Create, AppPermissions.Pages_TaiKang_BannerManager_Edit)]
        public async Task<PartialViewResult> CreateBannerModal(int? id)
        {
            //if (id.HasValue)
            //{
            //    var output = await _bannerAppService.Get(new BannerDto { Id =id.Value});
            //    return PartialView("_CreateOrEditBannerModal", output);
            //}
            //else
            //{
            //    var banner = new BannerDto();
            //    return PartialView("_CreateOrEditBannerModal", banner);
            //}
            BannerDto banner = new BannerDto();
            if (id.HasValue)
            {
                banner=await _bannerAppService.Get(new BannerDto { Id = id.Value });//由于这里bannerAppService直接使用了CrudAppService的方法
            }
            var viewModel = new CreateOrEditModalViewModel(banner);
            return PartialView("_CreateOrEditBannerModal", viewModel);
        }
    }
}