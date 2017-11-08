using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace TaiKang.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
