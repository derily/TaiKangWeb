using System.Collections.Generic;

namespace TaiKang.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}