using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto:EntityDto
    {
        public string ProductName { get; set; }
        public string Desc { get; set; }
        public string Functions { get; set; }
        public string BuyLink { get; set; }

        public bool Domestic { get; set; }

        public bool Exportable { get; set; }


        public string CarouselImg { get; set; }
        public string DetailImg1 { get; set; }

        public string DetailImg2 { get; set; }
        public string DetailImg3 { get; set; }
    }
}
