using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Banner
{
    [AutoMapFrom(typeof(BannerDto))]
    public class CreateOrEditModalViewModel:BannerDto
    {

        public bool IsEditMode
        {
            get { return Id!=0; }
        }
        public CreateOrEditModalViewModel(BannerDto output)
        {
            output.MapTo(this);
        }
    }
}