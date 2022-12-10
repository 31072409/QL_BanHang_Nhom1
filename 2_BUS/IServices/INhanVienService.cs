using _1_DAL.Entities;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface INhanVienService
    {
        string Add(NhanVienView obj);
        string Update(NhanVienView obj);
        string Delete(NhanVienView obj);
        List<NhanVienView> Show();
        List<NhanVien> GetDataFromDB();
        List<NhanVienView> Find(string a);
    }
}
