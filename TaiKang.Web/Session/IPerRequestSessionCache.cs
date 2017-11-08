using System.Threading.Tasks;
using TaiKang.Sessions.Dto;

namespace TaiKang.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
