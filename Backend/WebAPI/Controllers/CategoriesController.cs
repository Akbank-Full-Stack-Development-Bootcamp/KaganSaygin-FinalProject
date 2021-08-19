using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            var addedCategory = _categoryService.Add(category);
            return Created("", category);
        }

        [HttpPut]
        public IActionResult Update(Category category)
        {
            var updateCategory = _categoryService.GetById(category.Id);
            if (updateCategory == null)
            {
                return NoContent();
            }
            _categoryService.Update(category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            _categoryService.Delete(id);
            return Ok();
        }
    }
}