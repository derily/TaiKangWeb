using Abp.Notifications;
using TaiKang.Dto;

namespace TaiKang.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}