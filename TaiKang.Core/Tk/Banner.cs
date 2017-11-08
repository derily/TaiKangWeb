using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk
{
    [Table("Banner",Schema ="Tk")]
    public class Banner : FullAuditedEntity
    {
        public string BannerImage { get; set; }
        public string BannerTitle { get; set; }
        public bool Enabled { get; set; }
        public int OrderNo { get; set; }

        public Banner()
        {
            CreationTime = Clock.Now;
        }
    }
    
}
