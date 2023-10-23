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
        
        [HttpGet("driva/{fileName}")]
        public IActionResult Get([FromRoute] string fileName)
        {
            return Ok(_searchFile.Search(@"D:\", fileName));
        }
    }
}
