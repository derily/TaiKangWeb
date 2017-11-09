using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk
{
    [Table("ClassifiedContent",Schema ="Tk")]
    public class ClassifiedContent: FullAuditedEntity
    {
        
        public Classify ClassifyName { get; set; }
        public string Content { get; set; }
    }

    public enum Classify
    {
        [Display(Name ="人才招聘")]
        EmployPageContent=1,
        [Display(Name = "芦荟哪些事")]
        AboutAloePageContent =2
    }
}
