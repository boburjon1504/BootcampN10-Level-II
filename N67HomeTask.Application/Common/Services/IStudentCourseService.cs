using N67HomeTask.Domain.Entities;
using N67HomeTask.Domain.Entitiesk;

namespace N67HomeTask.Application.Common.Services;

public interface IStudentCourseService
{
    ValueTask<IEnumerable<User>> GetCourseStudentsById(Guid courseId);
    ValueTask<IEnumerable<Course>> GetStudentCoursesById(Guid strudentId);

    ValueTask<StudentCourse> Create(StudentCourse studentCourse);

}
