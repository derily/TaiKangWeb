using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using TaiKang.Tk.Dto;
using Abp.Domain.Repositories;
using Abp.Application.Services;

namespace TaiKang.Tk
{
   public class BannerAppService : CrudAppService<Banner,BannerDto>, IBannerAppService
    {
        public BannerAppService(IRepository<Banner> repository):base(repository)
        {

        }

        //public override PagedResultDto<BannerDto> GetAll(PagedAndSortedResultRequestDto input)
        //{
        //    return base.GetAll(input);
        //}

        //public PagedResultDto<BannerDto> GetAllBanner()
        //{
        //}

    }
}
