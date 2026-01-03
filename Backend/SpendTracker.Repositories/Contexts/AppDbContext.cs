using Microsoft.EntityFrameworkCore;
using SpendTracker.Entities.Models;
using System.Reflection;

namespace SpendTracker.Repositories.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Category> Categories { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
