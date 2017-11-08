using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Banner
{
    [AutoMapFrom(typeof(ListResultDto<BannerDto>))]
    public class IndexViewModel:ListResultDto<BannerDto>
    {
        public IndexViewModel(ListResultDto<BannerDto> output)
        {
            output.MapTo(this);
        }
    }
}