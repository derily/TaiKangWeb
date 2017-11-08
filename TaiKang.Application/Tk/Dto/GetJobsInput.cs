using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Dto;

namespace TaiKang.Tk.Dto
{
    public class GetJobsInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "CreationTime";
            }
        }
    }
}
