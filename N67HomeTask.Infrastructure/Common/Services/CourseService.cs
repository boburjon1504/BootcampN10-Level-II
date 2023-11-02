using Microsoft.VisualBasic;
using N67HomeTask.Application.Common.Services;
using N67HomeTask.Domain.Entities;
using N67HomeTask.Domain.Entitiesk;
using N67HomeTask.Persistence.DataAccess;
using System.Runtime.InteropServices;

namespace N67HomeTask.Infrastructure.Common.Services;

public class CourseService : ICourseService
{
    private readonly AppDataContext _dbContext;
    private readonly IUserService _userService;
    private readonly IRoleService _roleService;
    public CourseService(AppDataContext dbContext, IUserService userService, IRoleService roleService)
    {
        _dbContext = dbContext;
        _userService = userService;
        _roleService = roleService;
    }

    public IQueryable<Course> Get()
    {
        return _dbContext.Courses;
    }

    public IQueryable<Course> Get(IEnumerable<Guid> ids)
    {
        return _dbContext.Courses.Where(course => ids.Contains(course.Id));
    }

    public ValueTask<Course> GetByIdAsync(Guid id)
    {
        return new(_dbContext.Courses.FirstOrDefault(course => course.Id == id));
    }
   
    public async ValueTask<User> AddStudent(User student, Guid courseId)
    {
        var user = await _userService.Create(student);
        var userRole = await _dbContext.Roles.AddAsync(new Role
        {
            UserId = user.Id,
            Name = "Student"
        });
         var a = await _dbContext.AddAsync(new StudentCourse { CourseId = courseId ,StudentId = user.Id});
        var course =  await GetByIdAsync(courseId);
       
        course.StudentsCount += 1;
        
        _dbContext.Update(course);

        await _dbContext.SaveChangesAsync();
        return user;

    }

    public async ValueTask<User> AddTeacher(User teacher, Guid courseId)
    {
        var user = await _userService.Create(teacher);
        var userRole = await _dbContext.Roles.AddAsync(new Role
        {
            UserId = teacher.Id,
            Name = "Teacher"
        });

        var course = await GetByIdAsync(courseId);
        course.TeacherId = user.Id;

        _dbContext.Update(course);
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async ValueTask<Course> Create(Course course)
    {
        var coursee = await _dbContext.Courses.AddAsync(course);
        await _dbContext.SaveChangesAsync();

        return coursee.Entity;
    }
}
