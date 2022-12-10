using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid IdSP { get; set; }
        public Guid IdHD { get; set; }
        public string MaHD { get; set; }
        public int SoLuong { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
      
    }
}
