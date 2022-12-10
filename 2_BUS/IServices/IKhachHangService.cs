using _1_DAL.Entities;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IKhachHangService
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> Show();
        List<KhachHangView> Find(string a);
        List<KhachHang> GetDataFromDB();
    }
}
