using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace TaiKang.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}