﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TaiKang.Tk.Dto;

namespace TaiKang.Tk
{
    public interface IProductAppService:IAsyncCrudAppService<ProductDto>
    {
    }
}
