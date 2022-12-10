using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF_Configuration
{
    public class HoaDonConfiguartion : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(50);
            builder.HasOne<KhachHang>(x => x.KhachHang)
                .WithMany(x => x.HoaDon).HasForeignKey(x => x.IdKH);
            builder.HasOne<NhanVien>(x => x.NhanVien)
                .WithMany(x => x.HoaDon).HasForeignKey(x => x.IdNV);

            builder.Property(x => x.TrangThai).HasDefaultValue(0);
            builder.Property(x => x.TongTien);
            builder.Property(x => x.NgayTao);

            builder.Property(x => x.NgayThanhToan);
        }
    }
}
