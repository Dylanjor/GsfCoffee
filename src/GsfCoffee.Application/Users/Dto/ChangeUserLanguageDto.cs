using System.ComponentModel.DataAnnotations;

namespace GsfCoffee.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}