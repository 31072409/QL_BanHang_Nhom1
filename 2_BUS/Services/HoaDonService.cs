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
   
    public class HoaDonService : IHoaDonService
    {
        IHoaDonRepository _ihoadonrepository;
        IHoaDonChiTietRepository _ihoadonchitietrepository;
        IKhachHangRepository _ikhachhangrepository;
        INhanVienRepository _inhanvienrepository;
        public HoaDonService()
        {
            _ihoadonrepository = new HoaDonRepository();
            _ihoadonchitietrepository = new HoaDonChiTietRepository();
            _ikhachhangrepository = new KhachHangRepository();
            _inhanvienrepository = new NhanVienRepository();
        }
        
        public string Add(HoaDon obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HoaDon()
            {
                Id = obj.Id,
                Ma=obj.Ma,
                IdKH = obj.IdKH,
                IdNV = obj.IdNV,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                TrangThai = Convert.ToInt32(obj.TrangThai),
                TongTien=obj.TongTien,
            };
            if (_ihoadonrepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(HoaDonView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HoaDon()
            {
                Id = obj.Id,
                IdKH = obj.IdKH,
                IdNV = obj.IdNV,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                TrangThai = Convert.ToInt32(obj.TrangThai),
                TongTien=obj.TongTien,
            };
            if (_ihoadonrepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<HoaDon> GetDataFromDB()
        {
            return _ihoadonrepository.GetAll();
        }

        public List<HoaDonView> Show()
        {
            List<HoaDonView> lst = new List<HoaDonView>();
            lst = (from a in _ihoadonrepository.GetAll()
                   join b in _ikhachhangrepository.GetAll() on a.IdKH equals b.Id
                   join c in _inhanvienrepository.GetAll() on a.IdNV equals c.Id
                   select new HoaDonView()
                   {
                       Id = a.Id,
                       IdKH = b.Id,
                       IdNV = c.Id,
                       Ma = a.Ma,
                       NgayTao = a.NgayTao,
                       NgayThanhToan = a.NgayThanhToan,
                       TenNV = c.Ho + "" + c.TenDem + "" + c.Ten,
                       TenKH=b.HoTen,
                       SDTKH = b.SDT,
                       TongTien=a.TongTien
                   }).ToList();
            return lst;
        }

        public string Update(HoaDonView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HoaDon()
            {
                Id = obj.Id,
                IdKH = obj.IdKH,
                IdNV = obj.IdNV,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                TrangThai = Convert.ToInt32(obj.TrangThai),
                TongTien=obj.TongTien,
            };
            if (_ihoadonrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Updatehd(HoaDon obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HoaDon()
            {
                Id = obj.Id,
                IdKH = obj.IdKH,
                IdNV = obj.IdNV,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                TrangThai = Convert.ToInt32(obj.TrangThai),
                TongTien=obj.TongTien,
            };
            if (_ihoadonrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
