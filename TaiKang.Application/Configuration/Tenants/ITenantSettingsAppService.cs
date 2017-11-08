using System.Threading.Tasks;
using Abp.Application.Services;
using TaiKang.Configuration.Tenants.Dto;

namespace TaiKang.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
