using System.ComponentModel.DataAnnotations;

namespace LYP.BH.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}