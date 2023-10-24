using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N53_HT_1.Models;
using N53_HT_1.Services;

namespace N53_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonusController : ControllerBase
    {
        private readonly BonusService _bonusService;
        public BonusController(BonusService bonusService)
        {
            _bonusService = bonusService;
        }

        [HttpPost]
        public string SaveBonus(Order order)
        {
            return _bonusService.SaveBonus(order);
        }
    }
}
