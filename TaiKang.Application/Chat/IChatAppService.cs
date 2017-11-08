using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaiKang.Chat.Dto;

namespace TaiKang.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
