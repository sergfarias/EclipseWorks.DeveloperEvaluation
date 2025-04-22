using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
namespace EclipseWorks.DeveloperEvaluation.ORM;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Domain.Entities.Task> Tasks { get; set; }
    public DbSet<History> Histories { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Project>().ToTable("Projects");
        modelBuilder.Entity<Domain.Entities.Task>().ToTable("Tasks");
        modelBuilder.Entity<History>().ToTable("Histories");
    }
}
