using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Tk.Dto;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;

namespace TaiKang.Tk
{
    class BannerAppService_:AsyncCrudAppService<Banner,BannerDto>,IBannerAppService_
    {
        public BannerAppService_(IRepository<Banner> repository) : base(repository)
        {

        }

        //protected override IQueryable<Banner> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        //{
        //    return base.CreateFilteredQuery(input);
        //}
        //protected override IQueryable<Banner> CreateFilteredQuery(GetAllBannerInput input)
        //{
        //    return base.CreateFilteredQuery(input).WhereIf(input.Enabled,t=>t.BannerImage!="").AsQueryable<Banner>;
        //}

        //protected override IQueryable<Banner> CreateFilteredQuery(GetAllBannerInput input)
        //{
        //return base.CreateFilteredQuery(input)
        //    .WhereIf(input.Enabled, t => t.State == input.State.Value);
        //}
    }
}
