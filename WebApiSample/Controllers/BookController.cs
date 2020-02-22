using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private static List<Book> books = new List<Book>
        {
            new Book {Id = 1, Name = @"New Qiita", IsRent = false},
            new Book {Id = 2, Name = @"TryAgain鈴木のYouTube", IsRent = false}
        };

        [HttpGet]
        public ActionResult<List<Book>> GetAll()
          => books;

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(long id)
        {
            var book = books.Find(i => i.Id == id);
            if (book == null)
                return NotFound();
            return book;
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            book.Id = books.Max(i => i.Id) + 1;
            books.Add(book);

            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook(long id, Book book)
        {
            var target = books.Find(i => i.Id == id);
            if (target == null)
                return NotFound();

            target.Name = book.Name;
            target.IsRent = book.IsRent;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(long id)
        {
            var n = books.RemoveAll(i => i.Id == id);
            if (n == 0)
                return NotFound();
            return NoContent();
        }

    }
}