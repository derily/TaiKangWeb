using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaiKang.Authorization.Permissions.Dto;

namespace TaiKang.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
