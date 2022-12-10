using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        public bool Add(SanPham obj);
        public bool Update(SanPham obj);
        public bool Delete(SanPham obj);
        public List<SanPham> GetAll();
    }
}
