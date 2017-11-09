using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaiKang.Tk
{
    [Table("Material",Schema ="Tk")]
    public class Material:Entity, ICreationAudited,IHasCreationTime, IModificationAudited,IHasModificationTime
    {
        public string Name { get; set; }
        public string Function { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public DateTime CreationTime { get ; set ; }
        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get; set; }
        public long? CreatorUserId { get ; set ; }
    }
}
