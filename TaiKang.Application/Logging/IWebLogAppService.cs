using Abp.Application.Services;
using TaiKang.Dto;
using TaiKang.Logging.Dto;

namespace TaiKang.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
