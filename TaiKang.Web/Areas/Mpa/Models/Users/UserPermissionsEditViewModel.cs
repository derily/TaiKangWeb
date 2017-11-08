using Abp.AutoMapper;
using TaiKang.Authorization.Users;
using TaiKang.Authorization.Users.Dto;
using TaiKang.Web.Areas.Mpa.Models.Common;

namespace TaiKang.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}