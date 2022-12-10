using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface INhaSXService
    {
        string Add(NhaSXView obj);
        string Update(NhaSXView obj);
        string Delete(NhaSXView obj);
        List<NhaSXView> Show();
    }
}
