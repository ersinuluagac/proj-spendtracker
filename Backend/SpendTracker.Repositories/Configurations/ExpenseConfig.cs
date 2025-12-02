using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpendTracker.Entities.Entities;

namespace SpendTracker.Repositories.Configurations;

public class ExpenseConfig : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Amount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.ExpenseDate)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
    }
}
