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
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            var orders = _orderService.GetAll();

            var query = users.Join(orders,
                user => user.Id,
                order => order.UserId, (users, orders) => new
                {
                    Userr = users,
                    Orders = orders
                });
            return Ok(query);
        }
    }
}
