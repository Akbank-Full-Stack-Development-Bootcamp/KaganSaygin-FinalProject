using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_publisherService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var publisher = _publisherService.GetById(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return Ok(publisher);
        }

        [HttpPost]
        public IActionResult Add(Publisher publisher)
        {
            var addedPublisher = _publisherService.Add(publisher);
            return Created("", publisher);
        }

        [HttpPut]
        public IActionResult Update(Publisher publisher)
        {
            var updatePublisher = _publisherService.GetById(publisher.Id);
            if (updatePublisher == null)
            {
                return NoContent();
            }
            _publisherService.Update(publisher);
            return Ok(publisher);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var publisher = _publisherService.GetById(id);
            if (publisher == null)
            {
                return NotFound();
            }
            _publisherService.Delete(id);
            return Ok();
        }
    }
}