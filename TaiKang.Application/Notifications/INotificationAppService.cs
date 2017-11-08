using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaiKang.Notifications.Dto;

namespace TaiKang.Notifications
{
    public interface INotificationAppService : IApplicationService
    {
        Task<GetNotificationsOutput> GetUserNotifications(GetUserNotificationsInput input);

        Task SetAllNotificationsAsRead();

        Task SetNotificationAsRead(EntityDto<Guid> input);

        Task<GetNotificationSettingsOutput> GetNotificationSettings();
        
        Task UpdateNotificationSettings(UpdateNotificationSettingsInput input);
    }
}