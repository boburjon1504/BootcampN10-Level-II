using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IEntityBaseService<User> _userService;

        public UsersController(IEntityBaseService<User> userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetAll() =>
            Ok(_userService.Get());
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)=>
            Ok(await _userService.GetByIdAsync(id));

        [HttpPost]

        public async Task<IActionResult> CreateUser([FromBody] User user) =>
            Ok(await _userService.CreateAsync(user));
    }
}
