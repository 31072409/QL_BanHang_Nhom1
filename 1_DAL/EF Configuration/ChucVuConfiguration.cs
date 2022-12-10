using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class ChucvuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(50);
            builder.Property(x => x.Ten).HasMaxLength(50)
                   .IsUnicode();
        }
    }
}
