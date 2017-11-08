using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk.Dto
{
    [AutoMap(typeof(JobChance))]
    public class JobEditDto
    {
        public int? Id { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string Requirements { get; set; }
        public string Responsibilities { get; set; }
        public bool IsActive { get; set; }
    }
}
