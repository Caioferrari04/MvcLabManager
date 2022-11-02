using Microsoft.EntityFrameworkCore;

namespace MvcLabManager.Models;

public class Context : DbContext 
{
    public Context(DbContextOptions<Context> options) : base(options)
    { }

    // protected override void OnModelCreating(ModelBuilder modelBuilder) 
    // {
    //     modelBuilder.Entity<Computer>().Property(c => c.Id).ValueGeneratedOnAdd();
    // }

    public DbSet<Computer> Computers { get; set; }

    public DbSet<Lab> Labs { get; set; }
}