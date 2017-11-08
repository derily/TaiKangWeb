using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Tk.Dto;

namespace TaiKang.Tk
{
    public interface IJobChanceAppService: IApplicationService
    {
        Task<PagedResultDto<JobChanceListDto>> GetJobs(GetJobsInput input);
        Task<GetJobForEditOutput> GetJobForEdit(NullableIdDto<int> input);
        Task CreateOrUpdateJob(CreateOrUpdateJobInput input);
    }
}
