using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using TaiKang.Authorization.Users;

namespace TaiKang.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}