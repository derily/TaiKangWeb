using System.Threading.Tasks;
using Abp.Application.Services;
using TaiKang.Sessions.Dto;

namespace TaiKang.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
