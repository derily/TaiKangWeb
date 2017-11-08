using Abp.Domain.Entities;
using Abp.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaiKang.Tk
{
    [Table("CompanyIntroduce",Schema ="Tk")]
    public class CompanyIntroduce : Entity<int>, IModificationAudited, IHasModificationTime
    {
        public string CompanyName { get; set; }
        public string BrandStory { get; set; }
        public string Qualification { get; set; }
        public string Introduce { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get; set ; }

    }
}
