using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        public bool Add(HoaDonChiTiet obj);
        public bool Update(HoaDonChiTiet obj);
        public bool Delete(HoaDonChiTiet obj);
        public List<HoaDonChiTiet> GetAll();
    }
}
