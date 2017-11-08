using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Tk.Dto;

namespace TaiKang.Tk
{
    public interface IBannerAppService:ICrudAppService<BannerDto>
    {
    }
}
