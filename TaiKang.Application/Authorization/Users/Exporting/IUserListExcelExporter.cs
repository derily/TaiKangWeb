using System.Collections.Generic;
using TaiKang.Authorization.Users.Dto;
using TaiKang.Dto;

namespace TaiKang.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}