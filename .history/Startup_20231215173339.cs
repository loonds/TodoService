// Startup.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Use in-memory database
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("InMemoryDatabase"));

        // Register other services, controllers, etc.
    }

    // Other methods in Startup.cs
}
