using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N66_HT_1.Models;
using N66_HT_1.Models.Entities;
using N66_HT_1.Services.Interfaces;

namespace N66_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_authorService.Get());

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var user = await _authorService.GetByIdAsync(id);
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AuthorForCreation auuthor)
        {
            var author = auuthor.Adapt<Author>();
            var user = await _authorService.CreatAsync(author);

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Author auuthor)
        {

            var user = await _authorService.UpdateAsync(auuthor);

            return Ok(user);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var user = await _authorService.DeleteAsync(id);

            return Ok(user);
        }

    }
}
