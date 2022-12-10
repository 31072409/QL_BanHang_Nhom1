using _1_DAL.Entities;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface ISanPhamService
    {
        string Add(SanPhamView obj);
        string Update(SanPhamView obj);
        string UpdateSP(SanPham obj);
        string Delete(SanPhamView obj);
        List<SanPhamView> Show();
        List<SanPhamView> Find(string a);
        List<SanPham> GetDataFromDB();
    }
}
