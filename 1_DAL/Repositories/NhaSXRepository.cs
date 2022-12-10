using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class NhaSXRepository : INhaSXRepository
    {
        Nhom1DbContext _db;
        public NhaSXRepository()
        {
            _db = new Nhom1DbContext();
        }
        public bool Add(NhaSX obj)
        {
            if (obj == null) return false;
            _db.NhaSanXuats.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(NhaSX obj)
        {
            if (obj == null) return false;
            var temp = _db.NhaSanXuats.FirstOrDefault(x => x.Id == obj.Id);
            _db.NhaSanXuats.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<NhaSX> GetAll()
        {
            return _db.NhaSanXuats.ToList();
        }

        public bool Update(NhaSX obj)
        {
            if (obj == null) return false;
            var temp = _db.NhaSanXuats.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            _db.NhaSanXuats.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
