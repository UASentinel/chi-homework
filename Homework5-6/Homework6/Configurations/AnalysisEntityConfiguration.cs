using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework6.Configurations
{
    public class AnalysisEntityConfiguration : IEntityTypeConfiguration<Analysis>
    {
        public void Configure(EntityTypeBuilder<Analysis> builder)
        {
            builder.HasKey(an => an.AnId);
            builder.Property(an => an.AnName)
                .HasMaxLength(50);
            builder.Property(an => an.AnCost)
                .HasPrecision(10, 2);
            builder.Property(an => an.AnPrice)
                .HasPrecision(10, 2);
            builder.Property(an => an.AnGroupId)
                .IsRequired();
        }
    }
}
