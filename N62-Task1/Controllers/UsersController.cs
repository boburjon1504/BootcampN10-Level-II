using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N62_Task1.DTOs;
using N62_Task1.Model;
using N62_Task1.Service;

namespace N62_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.Get().Adapt<List<UserViewModel>>());
        }
        [HttpPost]
        public IActionResult Create([FromBody] UserForCreation user)
        {
            var newUser = user.Adapt<User>();
            newUser.Id = Guid.NewGuid();
            newUser.CreatedAt = DateTime.Now;
            newUser.UpdatedAt = DateTime.Now;
            var createdUser = _userService.Create(newUser);
            return Ok(createdUser.Adapt<UserViewModel>());
        }
    }
}
