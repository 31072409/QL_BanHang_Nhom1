using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class HoaDonChiTiet
    {
        public Guid IdSP { get; set; }
        public Guid IdHD { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }
       
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
    }
}
