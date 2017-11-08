using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk.Dto
{
    public class GetAllBannerInput:PagedAndSortedResultRequestDto
    {
        public bool Enabled { get; set; } 
    }
}
