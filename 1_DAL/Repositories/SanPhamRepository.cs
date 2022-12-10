using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        Nhom1DbContext _db;
        public SanPhamRepository()
        {
            _db = new Nhom1DbContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _db.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var temp = _db.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
            _db.SanPhams.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _db.SanPhams.ToList();
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var temp = _db.SanPhams.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.GiaNhap = obj.GiaNhap;
            temp.GiaBan = obj.GiaBan;
            temp.SoLuongTon = obj.SoLuongTon;
            temp.MoTa = obj.MoTa;
            temp.TrangThai = obj.TrangThai;
            temp.IdNSX = obj.IdNSX;
            _db.SanPhams.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
