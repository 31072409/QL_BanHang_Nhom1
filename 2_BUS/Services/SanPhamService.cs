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
    public class SanPhamServices : ISanPhamService
    {
        ISanPhamRepository _iSanPhamRepository;
        INhaSXRepository _iNhaSXRepository;
        public SanPhamServices()
        {
            _iSanPhamRepository = new SanPhamRepository();
            _iNhaSXRepository = new NhaSXRepository();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

       

        public List<SanPhamView> Show()
        {
            List<SanPhamView> lst = new List<SanPhamView>();
            lst = (from a in _iSanPhamRepository.GetAll()
                   join b in _iNhaSXRepository.GetAll()
                   on a.IdNSX equals b.Id
                   select new SanPhamView
                   {
                       Id = a.Id,
                       IdNSX = b.Id,
                       MaSP = a.Ma,
                       TenSP = a.Ten,
                       GiaNhap =(decimal) a.GiaNhap,
                       GiaBan =(decimal) a.GiaBan,
                       SoLuongTon =(int) a.SoLuongTon,
                       MoTa = a.MoTa,
                       TrangThai =(int)a.TrangThai,
                       NoiSX = b.Ten,
                   }).ToList();
            return lst;
        }

        public List<SanPhamView> Find(string a)
        {
            if (a == null)
            {
                return Show();
            }
            return Show().Where(c => c.MaSP.Contains(a)).ToList();
        }

       

        public List<SanPham> GetDataFromDB()
        {
            return _iSanPhamRepository.GetAll();
        }

       

        public string UpdateSP(SanPham obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.Ma,
                Ten = obj.Ten,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }

        
    }
}
