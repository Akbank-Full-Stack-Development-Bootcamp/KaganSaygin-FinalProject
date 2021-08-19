using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_authorService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var author = _authorService.GetById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            var addedAuthor = _authorService.Add(author);
            return Created("", author);
        }

        [HttpPut]
        public IActionResult Update(Author author)
        {
            var updateAuthor = _authorService.GetById(author.Id);
            if (updateAuthor == null)
            {
                return NoContent();
            }
            _authorService.Update(author);
            return Ok(author);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _authorService.GetById(id);
            if (author == null)
            {
                return NotFound();
            }
            _authorService.Delete(id);
            return Ok();
        }
    }
}