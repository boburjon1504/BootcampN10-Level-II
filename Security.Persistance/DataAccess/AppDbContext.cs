using Microsoft.EntityFrameworkCore;
using Security.Domain.Entities;
namespace Security.Persistance.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
  
}
