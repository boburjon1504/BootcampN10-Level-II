using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N67HomeTask.Application.Common.Services;
using N67HomeTask.Domain.Entities;

namespace N67HomeTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesCountroller : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesCountroller(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_courseService.Get());
        [HttpPost]
        public IActionResult Create([FromBody] Course course) => Ok(_courseService.Create(course));

        [HttpPost("{courseId:Guid}/addstudent")]
        public IActionResult AddStudent([FromRoute] Guid courseId, [FromBody] User student) => Ok(_courseService.AddStudent(student,courseId));
        [HttpPost("{courseId:Guid}/addteacher")]
        public IActionResult AddTeacher([FromRoute] Guid courseId,[FromBody] User teacher) => Ok(_courseService.AddTeacher(teacher,courseId));


    }
}
