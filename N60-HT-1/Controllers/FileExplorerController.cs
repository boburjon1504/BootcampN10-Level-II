using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N60_HT_1.FilterModels;
using N60_HT_1.Services;

namespace N60_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileExplorerController : ControllerBase
    {
        private readonly FileService fileService;

        public FileExplorerController(FileService fileService)
        {
            this.fileService = fileService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] StorageFilterModel filter)
        {
            return Ok(fileService.GetFiles(filter));
        }
    }
}
