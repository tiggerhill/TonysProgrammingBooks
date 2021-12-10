using Microsoft.AspNetCore.Mvc;
using TonysProgrammingBooks.Models;
using System.Linq;

namespace TonysProgrammingBooks.Controllers
{
    public class BookController : Controller
    {

        // Page 151

        private BookContext context { get; set; }
        public BookController(BookContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Languages = context.Languages.OrderBy(l => l.LanguageName).ToList();
            return View("Edit", new Book());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var book = context.Books.Find(id);
            return View(book);
        }
        
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                if (book.BookId == 0)
                {
                    context.Books.Add(book);
                }
                else
                {
                    context.Books.Update(book);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (book.BookId == 0) ? "Add" : "Edit";
                return View(book);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = context.Books.Find(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
