using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_HoaDon : Form
    {
        IHoaDonService _ihoadonservice;
        INhanVienService _inhanvienservice;
        IKhachHangService _ikhachhangservice;
        Guid _id;
        public Frm_HoaDon()
        {
            InitializeComponent();
            _ihoadonservice =new HoaDonService();
            _inhanvienservice =new NhanVienService();
            _ikhachhangservice = new KhachHangService();
            LoadData(); LoadNV(); LoadKH();
        }
        public void LoadNV()
        {
            cmb_nv.Items.Clear();
            foreach (var item in _inhanvienservice.Show())
            {
                cmb_nv.Items.Add(item.Ho + "" + item.TenDem + "" + item.Ten);
            }
            cmb_nv.SelectedIndex = 0;
        }
        public void LoadKH()
        {
            cmb_kh.Items.Clear();
            foreach (var item in _ikhachhangservice.Show())
            {
                cmb_kh.Items.Add(item.HoTen);
            }
            cmb_kh.SelectedIndex = 0;
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Khách hàng";
            dataGridView1.Columns[2].Name = "Nhân viên";
            dataGridView1.Columns[3].Name = "Ngày tạo";
            dataGridView1.Columns[4].Name = "Ngày thanh toán";
            dataGridView1.Columns[5].Name = "Tổng tiền";
            dataGridView1.Columns[6].Name = "Trạng thái";
            foreach (var item in _ihoadonservice.Show())
            {
                dataGridView1.Rows.Add(item.Id, item.TenKH, item.TenNV, item.NgayTao, item.NgayThanhToan, item.TongTien, item.TrangThai == 1 ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }
    }
}
