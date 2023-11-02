using N67HomeTask.Domain.Entities;
using N67HomeTask.Domain.Entitiesk;

namespace N67HomeTask.Application.Common.Services;

public interface ICourseService
{
    IQueryable<Course> Get();
    IQueryable<Course> Get(IEnumerable<Guid> ids);
    ValueTask<Course> GetByIdAsync(Guid id);
    ValueTask<Course> Create(Course course);
    ValueTask<User> AddStudent(User student, Guid courseId);
    ValueTask<User> AddTeacher(User teacher, Guid courseId);
}
