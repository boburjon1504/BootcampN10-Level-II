using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N58_HT_1.Models;
using N58_HT_1.Service;

namespace N58_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebRootController : ControllerBase
    {
        private readonly WebBroker _webBroker;
        public WebRootController(WebBroker webBroker)
        {
            _webBroker = webBroker;
        }
        [HttpGet("root/entries")]
        public IActionResult Get()
        {
            var storages = new List<IStorageInfo>();
            var files = _webBroker.GetFiles();
            var directories = _webBroker.GetDirectories();
            storages.AddRange(files);
            storages.AddRange(directories);
            return Ok(storages);

        }
    }
}
