using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N52_HT_1.Models;
using N52_HT_1.Services;

namespace N52_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManagementService _userManagementService;
        public UsersController(UserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        [HttpGet]
        public IActionResult Get() =>
            Ok(_userManagementService.Get());
        [HttpPost]
        public IActionResult Create([FromBody] User user) =>
            Ok(_userManagementService.Create(user));
    }
}
