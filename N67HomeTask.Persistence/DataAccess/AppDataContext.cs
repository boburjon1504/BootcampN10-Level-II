using Microsoft.EntityFrameworkCore;
using N67HomeTask.Domain.Entities;
using N67HomeTask.Domain.Entitiesk;

namespace N67HomeTask.Persistence.DataAccess;

public class AppDataContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<StudentCourse> Students => Set<StudentCourse>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<UserSettings> UserSettings => Set<UserSettings>();
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDataContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

}
