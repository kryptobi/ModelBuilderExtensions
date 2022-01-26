using Microsoft.EntityFrameworkCore;
using ModelBuilderExtensions.Extensions;

namespace ModelBuilderExtensions.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SetCollation("utf8mb4_general_ci");
    }
}