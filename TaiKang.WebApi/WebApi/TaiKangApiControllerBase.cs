using Abp.WebApi.Controllers;

namespace TaiKang.WebApi
{
    public abstract class TaiKangApiControllerBase : AbpApiController
    {
        protected TaiKangApiControllerBase()
        {
            LocalizationSourceName = TaiKangConsts.LocalizationSourceName;
        }
    }
}