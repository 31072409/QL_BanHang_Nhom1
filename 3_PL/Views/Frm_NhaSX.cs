using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_NhaSX : Form
    {
        INhaSXService _nhaSXServices;
        private Guid _id;
        public Frm_NhaSX()
        {
            InitializeComponent();
            _nhaSXServices = new NhaSXServices();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 4;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "NƠI SẢN XUẤT";
            
            dtg_hienthi.Rows.Clear();
            foreach (var item in _nhaSXServices.Show())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.Ma, item.Ten);
            }
        }
        public NhaSXView GetData()
        {
            NhaSXView nsx = new NhaSXView()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                Ten = txt_noisx.Text,
                
            };
            return nsx;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_nhaSXServices.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhaSXServices.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhaSXServices.Delete(temp));
            LoadData();
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _nhaSXServices.Show().FirstOrDefault(c => c.Id == _id);
            txt_ma.Text = temp.Ma;
            txt_noisx.Text = temp.Ten;
        }
    }
}
