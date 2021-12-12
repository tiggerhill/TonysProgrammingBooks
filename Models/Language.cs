using System.ComponentModel.DataAnnotations;

namespace TonysProgrammingBooks.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        
        [Required(ErrorMessage= "Please select a programming language.")]
        public string LanguageName { get; set; }
    }
}
