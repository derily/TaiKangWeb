using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.ClassifiedContent
{
    [AutoMapFrom(typeof(ClassifiedContentDto))]
    public class CreateOrEditModalViewModel:ClassifiedContentDto
    {
        public bool IsEditMode
        {
            get { return Id != 0; }
        }
        public CreateOrEditModalViewModel(ClassifiedContentDto output)
        {
            output.MapTo(this);
        }
    }
}