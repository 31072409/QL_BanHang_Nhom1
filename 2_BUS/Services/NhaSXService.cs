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
    public class NhaSXServices : INhaSXService
    {
        INhaSXRepository _iNhaSXRepository;
        public NhaSXServices()
        {
            _iNhaSXRepository = new NhaSXRepository();
        }

        public string Add(NhaSXView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSX()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                
            };
            if (_iNhaSXRepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(NhaSXView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSX()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten=obj.Ten,
            };
            if (_iNhaSXRepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        

       

        public List<NhaSXView> Show()
        {
            List<NhaSXView> lst = new List<NhaSXView>();
            lst = (from a in _iNhaSXRepository.GetAll()
                   select new NhaSXView
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ten=a.Ten
                   }).ToList();
            return lst;
        }

        public string Update(NhaSXView obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSX()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten=obj.Ten
            };
            if (_iNhaSXRepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }

        
    }
}
