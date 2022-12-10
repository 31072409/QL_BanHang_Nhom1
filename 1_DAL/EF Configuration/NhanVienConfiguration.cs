using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(50);
            builder.HasOne<ChucVu>(x => x.Chucvu).WithMany(x => x.NhanVien).HasForeignKey(x => x.IdCV);
            builder.Property(x => x.Ten).HasMaxLength(50)
                   .IsUnicode();
            builder.Property(x => x.Ho).HasMaxLength(50)
                   .IsUnicode();
            builder.Property(x => x.TenDem).HasMaxLength(50)
                   .IsUnicode();
            builder.Property(x => x.SDT).HasMaxLength(11);
            builder.Property(x => x.DiaChi).HasMaxLength(50)
                   .IsUnicode();
            
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.MatKhau).HasMaxLength(50);
            builder.Property(x => x.NgaySinh);
        }
    }
}
