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

        // DONE:  rename ClassContext, ClasssModel, Items as appropriate

        // EXAMPLE of how to Seed Data:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    BookTitle = "Murach's ASP.NET Core MVC",
                    BookAuthor = "Delamater and Murach",
                    LanguageId = 1
                });
            modelBuilder.Entity<Language>().HasData(
                new Language { LanguageId = 1, LanguageName = "C#" });
        }
    }
}
