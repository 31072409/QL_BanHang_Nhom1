using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid Id { get; set; }
        public Guid? IdKH { get; set; }
        public Guid? IdNV { get; set; }
        public string? Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public decimal? TongTien { get; set; }
        public string? TenKH { get; set; }
        public string? TenNV { get; set; }
        public int? TrangThai { get; set; }
        public string? SDTKH { get; set; }
    }
}
