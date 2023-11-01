using Microsoft.EntityFrameworkCore;
using N66_HT_1.Models.Entities;

namespace N66_HT_1.Persistence.DataAccess
{
    public class AppDataContext : DbContext
    {
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;DataBase=N66HomeTask;Username=postgres;Password=boburjon6767");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
