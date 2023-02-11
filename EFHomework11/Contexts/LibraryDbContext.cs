using EFHomework11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Contexts;

public class LibraryDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

        var connectionString = configuration.GetConnectionString("conStr");

        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    public DbSet<Student> Students { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Press> Presses { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Lib> Libs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<S_Card> S_Cards { get; set; }
    public DbSet<T_Card> T_Cards { get; set; }
}
