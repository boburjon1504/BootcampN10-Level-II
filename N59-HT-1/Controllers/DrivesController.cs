using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N59_HT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(DriveInfo.GetDrives().Select(dr => new StorageDrive
            {
                Name = dr.Name.Substring(0,dr.Name.IndexOf(":")),
                Path = dr.Name,
                Format = dr.DriveFormat,
                TotalSize = dr.TotalSize,
                TotalFreeSpace = dr.TotalFreeSpace,
            }));

        }
    }
}
