using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N65_HT_1.Models;
using N65_HT_1.Service;

namespace N65_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly VerificationTokenService verificationTokenService;

        public UsersController(VerificationTokenService verificationTokenService)
        {
            this.verificationTokenService = verificationTokenService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]User user)
        {
            return Ok(verificationTokenService.GetToken(user));
        }
        [HttpPost("{token}")]
        public IActionResult Create([FromRoute]string token)
        {
            return Ok(verificationTokenService.Decode(token));
        }
    }
}
