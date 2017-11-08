using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaiKang.Common.Dto;

namespace TaiKang.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetEditionsForCombobox();

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        string GetDefaultEditionName();
    }
}