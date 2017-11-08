using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaiKang.Tk.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Jobs
{
    [AutoMapFrom(typeof(GetJobForEditOutput))]
    public class CreateOrEditJobModalViewModel:GetJobForEditOutput
    {
        public bool IsEditMode
        {
            get { return Id.HasValue; }
        }
        public CreateOrEditJobModalViewModel(GetJobForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}