using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class KhachHangView
    {
        public Guid Id { get; set; }
        public string? MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? GioiTinh { get; set; }
        public int TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }
}
