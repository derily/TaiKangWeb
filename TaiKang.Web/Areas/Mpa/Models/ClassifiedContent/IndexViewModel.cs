using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.ClassifiedContent
{
    public class IndexViewModel: ListResultDto<ClassifiedContentDto>
    {
        public IndexViewModel(ListResultDto<ClassifiedContentDto> output)
        {
            output.MapTo(this);
        }
    }
}