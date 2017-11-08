using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk
{
    [Table("JobChance", Schema = "Tk")]
    public class JobChance: FullAuditedEntity, IPassivable
    {
        /// <summary>
        /// 职位名称
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 职位描述
        /// </summary>
        public string JobDescription { get; set; }
        /// <summary>
        /// 职位要求
        /// </summary>
        public string Requirements { get; set; }

        /// <summary>
        /// 职责
        /// </summary>
        public string Responsibilities { get; set; }
        public bool IsActive { get ; set ; }
    }
}
