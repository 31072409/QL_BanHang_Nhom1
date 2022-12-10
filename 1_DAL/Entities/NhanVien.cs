using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid? IdCV { get; set; }
        public string? Ma { get; set; }
        public string? Ho { get; set; }
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
       
        public int? TrangThai { get; set; }
        public ChucVu? Chucvu { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
