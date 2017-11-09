using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaiKang.Tk;
using TaiKang.Tk.Dto;
using TaiKang.Web.Areas.Mpa.Models.Product;
using TaiKang.Web.Controllers;

namespace TaiKang.Web.Areas.Mpa.Controllers
{
    public class ProductController : TaiKangControllerBase
    {
        private readonly IProductAppService _productService;
        public ProductController(IProductAppService service)
        {
            _productService = service;
        }
        // GET: Mpa/Product
        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
            ProductDto product = new ProductDto();
            if (id.HasValue)
            {
                product = await _productService.Get(new BannerDto { Id = id.Value });
            }
            var viewModel = new CreateOrEditModalViewModel(product);
            return PartialView("_CreateOrEditProductModal", viewModel);
        }
    }
}