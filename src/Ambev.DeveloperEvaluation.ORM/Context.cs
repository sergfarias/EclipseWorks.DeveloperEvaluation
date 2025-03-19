using Microsoft.EntityFrameworkCore;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.ORM;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Branch> Branchs { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Branch>().ToTable("Branchs");
        modelBuilder.Entity<Product>().ToTable("Products");
        modelBuilder.Entity<Customer>().ToTable("Customers");
        modelBuilder.Entity<Sale>().ToTable("Sales");
        modelBuilder.Entity<SaleItem>().ToTable("SaleItems");
       }
}
