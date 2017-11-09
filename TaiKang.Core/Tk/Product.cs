using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk
{
    [Table("Product",Schema ="Tk")]
    public class Product: FullAuditedEntity
    {
        public string ProductName { get; set; }
        public string Desc { get; set; }
        public string Functions { get; set; }
        public string BuyLink { get; set; }

        public virtual ICollection<Material> Materials { get; set; }

        /// <summary>
        /// 内销标记
        /// </summary>
        public bool Domestic { get; set; }

        /// <summary>
        /// 外销标记
        /// </summary>
        public bool Exportable { get; set; }


        public string CarouselImg { get; set; }
        public string DetailImg1 { get; set; }

        public string DetailImg2 { get; set; }
        public string DetailImg3 { get; set; }

    }
}
