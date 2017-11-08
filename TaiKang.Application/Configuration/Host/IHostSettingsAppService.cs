using System.Threading.Tasks;
using Abp.Application.Services;
using TaiKang.Configuration.Host.Dto;

namespace TaiKang.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
