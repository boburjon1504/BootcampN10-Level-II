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
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_bookService.Get());

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var bookk = await _bookService.GetByIdAsync(id);
            return Ok(bookk);
        }
        [HttpGet("{authorId:Guid}/getByAuthorId")]
        public async Task<IActionResult> GetByAuthorId([FromRoute] Guid authorId)
        {
            var bookk = await _bookService.GetByAuthorIdAsync(authorId);
            return Ok(bookk);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BookForCreation book)
        {
            var newBook = book.Adapt<Book>();
            var bookk = await _bookService.CreatAsync(newBook);

            return Ok(bookk);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Book book)
        {
            var bookk = await _bookService.UpdateAsync(book);

            return Ok(bookk);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var bookk = await _bookService.DeleteAsync(id);

            return Ok(bookk);
        }
    }
}
