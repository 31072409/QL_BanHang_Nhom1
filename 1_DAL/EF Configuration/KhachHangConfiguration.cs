using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class KhachHangConfigurationbuilder : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(50);
            builder.Property(x => x.HoTen).HasMaxLength(100) .IsUnicode();
            builder.Property(x => x.NgaySinh);
            builder.Property(x => x.SDT).HasMaxLength(11);
            builder.Property(x => x.DiaChi).HasMaxLength(50)
                   .IsUnicode();
            builder.Property(x => x.GioiTinh).HasMaxLength(5)
                   .IsUnicode();
            builder.Property(x => x.GhiChu).HasMaxLength(50)
            .IsUnicode();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
