namespace N67HomeTask.Application.Common.Services;

public interface IRoleService
{
    IEnumerable<Guid> GetStudents();
    IEnumerable<Guid> GetTeachers();
}
