using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class NhanVienView
    {
        public Guid Id { get; set; }
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public Guid IdCV { get; set; }
        public string TenCV { get; set; }
    }
}
