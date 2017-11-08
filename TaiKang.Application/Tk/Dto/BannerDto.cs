using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace TaiKang.Tk.Dto
{
    [AutoMap(typeof(Banner))]
    public class BannerDto :EntityDto
    {
        public string BannerImage { get; set; }
        public string BannerTitle { get; set; }
        public bool Enabled { get; set; }
        public int OrderNo { get; set; }
    }
}
