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

        public int LanguageId { get; set; }
    }
}
