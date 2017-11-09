using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using TaiKang.Tk.Dto;
using Abp.Domain.Repositories;
using Abp.AutoMapper;

namespace TaiKang.Tk
{
    public class JobChanceAppService :TaiKangAppServiceBase, IJobChanceAppService
    {
        private readonly IRepository<JobChance> _jobRepository;
        public JobChanceAppService(IRepository<JobChance> repository)
        {
            _jobRepository = repository;
        }

        public async Task<GetJobForEditOutput> GetJobForEdit(NullableIdDto<int> input)
        {
            var output = new GetJobForEditOutput();
            if (!input.Id.HasValue)
            {
                //创建视图模型处理
            }
            else
            {
                var job = await _jobRepository.GetAsync(input.Id.Value);
                output=job.MapTo<GetJobForEditOutput>();
            }
            return output;
        }

        public async Task<PagedResultDto<JobChanceListDto>> GetJobs(GetJobsInput input)
        {
            var jobs =await  _jobRepository.GetAllListAsync();
            int jobsCount =await _jobRepository.CountAsync();
            var jobListDtos = jobs.MapTo<List<JobChanceListDto>>();
            return new PagedResultDto<JobChanceListDto>(jobsCount, jobListDtos);
        }

        public async Task CreateOrUpdateJob(CreateOrUpdateJobInput input)
        {
            //if (input.Id.HasValue)
            //{
            //    await UpdateJobAsync(input);
            //}
            //else
            //{
            //    await CreateJobAsync(input);
            //}
            await _jobRepository.InsertOrUpdateAsync(input.MapTo<JobChance>());
        }

        public async Task DeleteJob(int id)
        {
            await _jobRepository.DeleteAsync(id);
        }

        //private Task CreateJobAsync(CreateOrUpdateJobInput input)
        //{
        //    
        //}

        //private Task UpdateJobAsync(CreateOrUpdateJobInput input)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
