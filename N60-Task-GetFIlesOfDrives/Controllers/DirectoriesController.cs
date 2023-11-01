using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N60_Task_GetFIlesOfDrives.Services;

namespace N60_Task_GetFIlesOfDrives.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoriesController : ControllerBase
    {
        private readonly SearchFile _searchFile;
        public DirectoriesController(SearchFile searchFile) => 
            _searchFile = searchFile;
        
        [HttpPost]
        public IActionResult Get([FromForm]Image fileName)
        {
            return Ok(_searchFile.Search(@"C:\Users\User\AppData\Roaming", ""));
        }
    }
}
