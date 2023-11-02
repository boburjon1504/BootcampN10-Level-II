using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N63_HT_1.Models;
using N63_HT_1.Services;

namespace N63_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageFileController : ControllerBase
    {
        private readonly StorageFileService _storageFileService;

        public StorageFileController(StorageFileService storageFileService)
        {
            _storageFileService = storageFileService;
        }

        [HttpPost]
        public IActionResult Upload([FromForm] StorageFile file)
        {
            return Ok(_storageFileService.UploadFile(file));
        }
    }
}
