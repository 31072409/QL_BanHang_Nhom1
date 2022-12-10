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
    public class NhanVienService:INhanVienService
    {
        INhanVienRepository _inhanvienrepository;
        IChucVuRepository _iChucVuRepository;
        public NhanVienService()
        {
            _inhanvienrepository = new NhanVienRepository();
            _iChucVuRepository = new ChucVuRepository();
        }

        public string Add(NhanVienView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                DiaChi = obj.DiaChi,
                

            };
            if (_inhanvienrepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(NhanVienView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                DiaChi = obj.DiaChi,
            };
            if (_inhanvienrepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<NhanVienView> Find(string a)
        {
            if (a == null)
            {
                return Show();
            }
            return Show().Where(c => c.MaNV.Contains(a)).ToList();
        }

        public List<NhanVien> GetDataFromDB()
        {
            return _inhanvienrepository.GetAll();
        }

        public List<NhanVienView> Show()
        {
            List<NhanVienView> lst = new List<NhanVienView>();
            lst = (from a in _inhanvienrepository.GetAll()
                   join b in _iChucVuRepository.GetAll()
                   on a.IdCV equals b.Id
                   select new NhanVienView()
                   {
                       Id = a.Id,
                       IdCV = b.Id,
                       MaNV = a.Ma,
                       Ho = a.Ho,
                       TenDem = a.TenDem,
                       Ten = a.Ten,
                       GioiTinh = a.GioiTinh,
                       NgaySinh =(DateTime) a.NgaySinh,
                       SDT = a.SDT,
                       Email = a.Email,
                       MatKhau = a.MatKhau,
                       TrangThai = (int)a.TrangThai,
                       TenCV = b.Ten,
                       DiaChi = a.DiaChi,
                   }).ToList();
            return lst;
        }

        public string Update(NhanVienView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                DiaChi = obj.DiaChi,
            };
            if (_inhanvienrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
