using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Product
{
    [AutoMapFrom(typeof(ProductDto))]
    public class CreateOrEditModalViewModel:ProductDto
    {

        public bool IsEditMode
        {
            get { return Id != 0; }
        }
        public CreateOrEditModalViewModel(ProductDto output)
        {
            output.MapTo(this);
        }
    }
}