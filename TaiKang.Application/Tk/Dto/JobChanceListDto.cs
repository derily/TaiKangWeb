using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKang.Tk.Dto
{
    [AutoMapFrom(typeof(JobChance))]
    public class JobChanceListDto : EntityDto<int>, IPassivable, IHasCreationTime
    {
        public string JobName { get; set; }
        public bool IsActive { get ; set; }
        public DateTime CreationTime { get ; set; }
    }
}
