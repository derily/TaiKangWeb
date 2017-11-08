using Abp.Domain.Services;

namespace TaiKang
{
    public abstract class TaiKangDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TaiKangDomainServiceBase()
        {
            LocalizationSourceName = TaiKangConsts.LocalizationSourceName;
        }
    }
}
