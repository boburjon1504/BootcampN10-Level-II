using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N62_HT_1.Models;
using N62_HT_1.Services.Interfaces;

namespace N62_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public ValueTask<bool> Register([FromBody] RegistrationDetails user)
        {
            return _authService.RegisterAsync(user);
        }

        [HttpPost("login")]
        public ValueTask<string> Login([FromBody] LoginDetails user)
        {
            return _authService.LoginAsync(user);
        }
    }
}
