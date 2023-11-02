using N67HomeTask.Application.Common.Services;
using N67HomeTask.Domain.Entities;
using N67HomeTask.Domain.Entitiesk;
using N67HomeTask.Persistence.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N67HomeTask.Infrastructure.Common.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly IUserService _userService;
        private readonly ICourseService _courseService;
        private readonly AppDataContext _dbContext;
        private readonly IRoleService _roleService;
        public StudentCourseService(IUserService userService, ICourseService courseService
            , AppDataContext dbContext, IRoleService roleService)
        {
            _userService = userService;
            _courseService = courseService;
            _dbContext = dbContext;
            _roleService = roleService;
        }

        public async ValueTask<StudentCourse> Create(StudentCourse studentCourse)
        {
            await _dbContext.AddAsync(studentCourse);

            await _dbContext.SaveChangesAsync();

            return studentCourse;
        }

        public ValueTask<IEnumerable<User>> GetCourseStudentsById(Guid courseId)
        {
            var studentsIds = _roleService.GetStudents().ToList();

            var studentCourse = _dbContext.Students
                .Where(student => student.CourseId == courseId).Select(s => s.StudentId);


            var stud = studentsIds.Where(st => studentCourse.Any(id => id == st));
            //.Select(s => s.StudentId);

            return new(_userService.Get(stud));
        }

        public ValueTask<IEnumerable<Course>> GetStudentCoursesById(Guid strudentId)
        {
            var courses = _dbContext.Students
                .Where(student => student.StudentId == strudentId)
                .Select(s => s.CourseId);

            return new(_courseService.Get(courses));

        }
    }
}
