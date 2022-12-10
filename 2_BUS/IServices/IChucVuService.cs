using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IChucVuService
    {
        string Add(ChucVuView obj);
        string Update(ChucVuView obj);
        string Delete(ChucVuView obj);
        List<ChucVuView> GetAll();
    }
}
