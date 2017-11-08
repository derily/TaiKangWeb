using TaiKang.Dto;

namespace TaiKang.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}