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
    public class GroupEntityConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(gr => gr.GrId);
            builder.Property(gr => gr.GrName)
                .HasMaxLength(50);
            builder.Property(gr => gr.GrTemp)
                .HasPrecision(5, 1);
        }
    }
}
