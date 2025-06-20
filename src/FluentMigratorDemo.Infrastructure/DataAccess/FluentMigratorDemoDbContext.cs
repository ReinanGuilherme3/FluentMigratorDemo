using Microsoft.EntityFrameworkCore;

namespace FluentMigratorDemo.Infrastructure.DataAccess;

public class FluentMigratorDemoDbContext : DbContext
{
    public FluentMigratorDemoDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
