using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TonysProgrammingBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace TonysProgrammingBooks.Controllers
{
    public class HomeController : Controller
    {
        private BookContext context { get; set; }
        public HomeController(BookContext ctx) { context = ctx; }
        public IActionResult Index()
        {
            var books = context.Books
                .Include(l => l.Language)
                .OrderBy(b => b.BookTitle)
                .ToList();
            
            return View(books);
        }
    }
}
