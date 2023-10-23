using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMarket_50.Models;
using OnlineMarket_50.Services.Interfaces;

namespace OnlineMarket_50.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        public UsersController(IUserService userService,IOrderService orderService)
        {
            _orderService = orderService;
            _userService = userService; 
        }

        [HttpGet("Get all")]
        public List<User> GetAll()
        {
            return _userService.GetAll();
        }
        [HttpGet("{id}")]
        public async ValueTask<IActionResult> Get(Guid id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }
    }
}
