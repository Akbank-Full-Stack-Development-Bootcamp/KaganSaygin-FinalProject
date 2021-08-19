using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookService.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("GetByAuthorBooks/{id}")]
        public IActionResult GetByAuthorBooks(int id)
        {
            var book = _bookService.GetByAuthor(id);
            if (book.Count < 1)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("GetByPublisherBooks/{id}")]
        public IActionResult GetByPublisherBooks(int id)
        {
            var book = _bookService.GetByPublisher(id);
            if (book.Count < 1)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("GetByCategoryBooks/{id}")]
        public IActionResult GetByCategoryBooks(int id)
        {
            var book = _bookService.GetByCategory(id);
            if (book.Count < 1)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("Search/{name}")]
        public IActionResult Search(string name)
        {
            var book = _bookService.Search(name);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            var addedbook = _bookService.Add(book);
            return Created("", book);
        }

        [HttpPut]
        public IActionResult Update(Book book)
        {
            var updatebook = _bookService.GetById(book.Id);
            if (updatebook == null)
            {
                return NoContent();
            }
            _bookService.Update(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            _bookService.Delete(id);
            return Ok();
        }
    }
}