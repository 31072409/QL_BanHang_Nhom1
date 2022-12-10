using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string? Ma { get; set; }
        public string? HoTen { get; set; }
        public string? SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? GioiTinh { get; set; }
        public int? TrangThai { get; set; }
        public string? GhiChu { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
