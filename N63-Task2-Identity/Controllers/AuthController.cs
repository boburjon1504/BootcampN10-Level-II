using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N63_Task2_Identity.Models.Dtos;
using N63_Task2_Identity.Service;

namespace N63_Task2_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationDetails registrationDetails)
        {
            var result = await _authService.RegisterAsync(registrationDetails);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDetails loginDetails)
        {
            var result = await _authService.LoginAsync(loginDetails);
            return Ok(result);
        }
    }
}
