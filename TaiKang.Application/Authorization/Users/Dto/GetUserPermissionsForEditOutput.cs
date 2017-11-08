using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TaiKang.Authorization.Permissions.Dto;

namespace TaiKang.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}