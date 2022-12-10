using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_BUS.Services
{
    public class KhachHangService:IKhachHangService
    {
        IKhachHangRepository _ikhachhangrepository;
        public KhachHangService()
        {
            _ikhachhangrepository = new KhachHangRepository();
        }

        public string Add(KhachHangView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<KhachHangView> Find(string a)
        {
            if (a == null)
            {
                return Show();
            }
            return Show().Where(c => c.SDT.Contains(a)).ToList();
        }

        public List<KhachHang> GetDataFromDB()
        {
            return _ikhachhangrepository.GetAll();
        }

        public List<KhachHangView> Show()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst = (from a in _ikhachhangrepository.GetAll()
                   select new KhachHangView
                   {
                       Id = a.Id,
                       MaKH = a.Ma,
                       HoTen = a.HoTen,
                       SDT = a.SDT,
                       NgaySinh = (DateTime)a.NgaySinh,
                       DiaChi = a.DiaChi,
                       GioiTinh = a.GioiTinh,
                       TrangThai = (int)a.TrangThai,
                       GhiChu = a.GhiChu,
                   }).ToList();
            return lst;
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
