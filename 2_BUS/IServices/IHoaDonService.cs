using _1_DAL.Entities;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDon obj);
        string Update(HoaDonView obj);
        string Delete(HoaDonView obj);
        string Updatehd(HoaDon obj);
        List<HoaDonView> Show();
        List<HoaDon> GetDataFromDB();
    }
}
