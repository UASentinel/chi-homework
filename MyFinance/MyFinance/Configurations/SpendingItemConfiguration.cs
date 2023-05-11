using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFinance.Models;

namespace MyFinance.Configurations
{
    public class SpendingItemConfiguration : IEntityTypeConfiguration<Spending>
    {
        public void Configure(EntityTypeBuilder<Spending> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Sum)
                .HasPrecision(10, 2)
                .IsRequired();
            builder.Property(s => s.Comment)
                .HasMaxLength(200)
                .IsRequired(false);
            builder.Property(s => s.DateTime)
                .IsRequired();
            builder.Property(s => s.CategoryId)
                .IsRequired();
        }
    }
}
