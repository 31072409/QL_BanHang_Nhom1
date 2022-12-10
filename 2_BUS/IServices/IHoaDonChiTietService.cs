using _1_DAL.Entities;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IHoaDonChiTietService
    {
        string Add(HoaDonChiTiet obj);
        string Update(HoaDonChiTietView obj);
        string Delete(HoaDonChiTietView obj);
        List<HoaDonChiTietView> Show();
        List<HoaDonChiTiet> GetDataFromDB();
    }
}
