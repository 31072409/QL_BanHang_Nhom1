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
    public class ChucVuService : IChucVuService
    {
        IChucVuRepository _ichucvurepository;
        public ChucVuService()
        {
            _ichucvurepository = new ChucVuRepository();
        }
        public string Add(ChucVuView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst = (from a in _ichucvurepository.GetAll()
                   select new ChucVuView
                   {
                       Id=a.Id,
                       Ma=a.Ma,
                       Ten=a.Ten,
                   }).ToList();
            return lst;
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
