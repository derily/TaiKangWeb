using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaiKang.Auditing.Dto;
using TaiKang.Dto;

namespace TaiKang.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}