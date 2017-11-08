using Abp.Application.Services;
using TaiKang.Tenants.Dashboard.Dto;

namespace TaiKang.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
