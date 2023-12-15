// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Add other configurations, DbSet properties, etc.

    // No need for OnConfiguring as the DbContextOptions will be provided through dependency injection
}
