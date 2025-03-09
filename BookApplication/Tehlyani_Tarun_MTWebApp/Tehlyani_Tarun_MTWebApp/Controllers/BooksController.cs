using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tehlyani_Tarun_MTWebApp.Models;
using Tehlyani_Tarun_MTWebApp.Services;

namespace Tehlyani_Tarun_MTWebApp.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            List<Book> book = await _bookService.GetBooks();
            return View(book);
        }

        // GET: BooksController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Book book = await _bookService.GetBook(id);
            return View(book);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(book);
                }
                bool isCreated = await _bookService.AddBook(book);
                if (isCreated)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }
            catch
            {
                return View(book);
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Book book)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(book);
                }
                bool isCreated = await _bookService.UpdateBook(book);
                if (isCreated)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }
            catch
            {
                return View(book);
            }
        }

        // GET: BooksController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Book book = await _bookService.GetBook(id);

            return View(book);
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Book book)
        {
            try
            {
                bool isDeleted = await _bookService.DeleteBook(id);
                if (isDeleted)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }
            catch
            {
                return View(book);
            }
        }
    }
}
