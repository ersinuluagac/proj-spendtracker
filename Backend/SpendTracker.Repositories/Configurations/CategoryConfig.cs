using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpendTracker.Entities.Models;


namespace SpendTracker.Repositories.Configurations;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETDATE()");

        builder.HasMany(c => c.Expenses)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Category
            {
                Id = 1,
                Title = "Diğer",
                CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false
            }
        );
    }
}
