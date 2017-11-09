using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Tk.Dto;

namespace TaiKang.Tk
{
    public class ClassifiedContentAppService: AsyncCrudAppService<ClassifiedContent,ClassifiedContentDto>, IClassifiedContentAppService
    {
        public ClassifiedContentAppService(IRepository<ClassifiedContent> repository):base(repository)
        {

        }
    }
}
