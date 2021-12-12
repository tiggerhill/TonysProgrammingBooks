using System.ComponentModel.DataAnnotations;

namespace TonysProgrammingBooks.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a book title.")]
        public string BookTitle { get; set; }
        
        [Required(ErrorMessage = "Please enter author's name/s.")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "Please specify the programming language.")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
