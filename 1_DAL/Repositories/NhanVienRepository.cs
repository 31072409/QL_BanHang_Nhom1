using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class NhanVienRepository:INhanVienRepository
    {
        Nhom1DbContext _db;
        public NhanVienRepository()
        {
            _db = new Nhom1DbContext();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _db.NhanViens.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var temp = _db.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            _db.NhanViens.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _db.NhanViens.ToList();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var temp = _db.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ho = obj.Ho;
            temp.TenDem = obj.TenDem;
            temp.Ten = obj.Ten;
            temp.GioiTinh = obj.GioiTinh;
            temp.NgaySinh = obj.NgaySinh;
            temp.DiaChi = obj.DiaChi;
            temp.SDT = obj.SDT;
            temp.Email = obj.Email;
            temp.MatKhau = obj.MatKhau;
            temp.TrangThai = obj.TrangThai;
            temp.IdCV = obj.IdCV;
            _db.NhanViens.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
