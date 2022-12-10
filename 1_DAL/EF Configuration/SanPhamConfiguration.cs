using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class SanPhamConfiguation : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(50).IsRequired();
            builder.HasOne<NhaSX>(x => x.NSX).WithMany(x => x.SanPham).HasForeignKey(x => x.IdNSX);
            builder.Property(x => x.MoTa).HasMaxLength(100).IsUnicode();
            builder.HasCheckConstraint("SL", "SoLuongTon >= 0")
                 .Property(x => x.SoLuongTon); ;
            builder.Property(x => x.Ten).HasMaxLength(100)
                   .IsUnicode();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
            builder.Property(x => x.GiaNhap);
            builder.Property(x => x.GiaBan); ;
        }
    }
}
