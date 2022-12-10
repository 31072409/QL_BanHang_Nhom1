using _1_DAL.EF_Configuration;
using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF
{
    public class Nhom1DbContext:DbContext
    {
        public Nhom1DbContext()
        {

        }
        public Nhom1DbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChucvuConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguartion());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfigurationbuilder());
            modelBuilder.ApplyConfiguration(new NhaSXConfiguartion());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguation());

        }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<NhaSX> NhaSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            optionsBuilder.UseSqlServer(@"Data Source=PC-DAT\SQLEXPRESS02;Initial Catalog=nhom1;Integrated Security=True");
        }
    }
}
