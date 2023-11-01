using Microsoft.EntityFrameworkCore;
using N66_Task1.Domain;

namespace N66_Task1.Persistance.DataContexts;

public class AppDataContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Server=localhost;Database=test;User=postgres;Password=boburjon6767");
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyFirstEfCore;Username=postgres;Password=boburjon6767");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Book>().HasOne<Author>().WithMany();

        base.OnModelCreating(modelBuilder);

    }
}
