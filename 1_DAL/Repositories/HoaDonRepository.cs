using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        Nhom1DbContext _db;
        public HoaDonRepository()
        {
            _db = new Nhom1DbContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _db.HoaDons.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _db.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            _db.HoaDons.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _db.HoaDons.ToList();
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _db.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            temp.IdKH = obj.IdKH;
            temp.IdNV = obj.IdNV;
            temp.Ma = obj.Ma;
            temp.NgayTao = obj.NgayTao;
            temp.NgayThanhToan = obj.NgayThanhToan;
            temp.TrangThai = obj.TrangThai;
            _db.HoaDons.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
