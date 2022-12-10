using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        public bool Add(HoaDon obj);
        public bool Update(HoaDon obj);
        public bool Delete(HoaDon obj);
        public List<HoaDon> GetAll();
    }
}
