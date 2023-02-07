using Microsoft.EntityFrameworkCore;

namespace Persistance.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}