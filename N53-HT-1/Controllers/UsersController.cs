using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N53_HT_1.Services;

namespace N53_HT_1.Controllers
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
        public IActionResult Get() => Ok(_userService.Get());
    }
}
