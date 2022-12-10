using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _2_BUS.Services
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        IHoaDonChiTietRepository _ihoadonchitietrepository;
        ISanPhamRepository _isanphamrepository;
        IHoaDonRepository _ihoadonrepository;
        public HoaDonChiTietService()
        {
            _ihoadonchitietrepository = new HoaDonChiTietRepository();
            _isanphamrepository = new SanPhamRepository();
            _ihoadonrepository = new HoaDonRepository();
        }
        public string Add(HoaDonChiTiet obj)
        {
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
                DonGia = (decimal)obj.DonGia,

            };
            if (_ihoadonchitietrepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(HoaDonChiTietView obj)
        {
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
                DonGia = (decimal)obj.DonGia,
            };
            if (_ihoadonchitietrepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<HoaDonChiTiet> GetDataFromDB()
        {
            return _ihoadonchitietrepository.GetAll();
        }

        public List<HoaDonChiTietView> Show()
        {
            List<HoaDonChiTietView> lst = new List<HoaDonChiTietView>();
            lst = (from a in _ihoadonchitietrepository.GetAll()
                   join b in _ihoadonrepository.GetAll() on a.IdHD equals b.Id
                   join c in _isanphamrepository.GetAll() on a.IdSP equals c.Id
                   select new HoaDonChiTietView
                   {
                       IdSP = b.Id,
                       IdHD = c.Id,
                       MaSP = b.Ma,
                       MaHD = c.Ma,
                       SoLuong = (int)a.SoLuong,
                       DonGia = (decimal)a.DonGia,
                   }).ToList();
            return lst;
        }

        public string Update(HoaDonChiTietView obj)
        {
            if (obj == null) return "Thất bại";

            var a = new HoaDonChiTiet()
            {
                IdSP = obj.IdSP,
                IdHD = obj.IdHD,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
            };
            if (_ihoadonchitietrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
