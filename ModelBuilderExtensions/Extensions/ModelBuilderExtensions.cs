using Microsoft.EntityFrameworkCore;

namespace ModelBuilderExtensions.Extensions;

public static class ModelBuilderExtensions
{
    public static void SetCollation(this ModelBuilder modelBuilder, string collation)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(string))
                    modelBuilder.Entity(entityType.Name)
                                .Property(property.Name)
                                .HasCollation(collation);
            }
        }
    }
}