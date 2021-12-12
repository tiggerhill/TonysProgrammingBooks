using Microsoft.EntityFrameworkCore;

namespace TonysProgrammingBooks.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language 
                { 
                    LanguageId = 1, LanguageName = "C#" 
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    BookTitle = "Murach's ASP.NET Core MVC",
                    BookAuthor = "Delamater and Murach",
                    LanguageId = 1
                }); 
        }
    }
}
