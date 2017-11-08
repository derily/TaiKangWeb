using System.Collections.Generic;
using TaiKang.Authorization.Users.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}