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
    public partial class Frm_QLKhachHang : Form
    {
        IKhachHangService _khachHangService;
        Guid _id;
        public Frm_QLKhachHang()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            LoadData();
        }

       
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 10;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ TÊN";
            dtg_hienthi.Columns[4].Name = "SỐ ĐIỆN THOẠI";
            dtg_hienthi.Columns[5].Name = "NGÀY SINH";
            dtg_hienthi.Columns[6].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[7].Name = "GIỚI TÍNH";
            dtg_hienthi.Columns[8].Name = "TRẠNG THÁI";
            dtg_hienthi.Columns[9].Name = "GHI CHÚ";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _khachHangService.Show())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaKH, item.HoTen, item.SDT=="0"?"Khách vãng lai":item.SDT, item.NgaySinh, item.DiaChi, item.GioiTinh, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", item.GhiChu);
            }
        }
        private void TimKiem(string a)
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 10;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ TÊN";
            dtg_hienthi.Columns[4].Name = "SỐ ĐIỆN THOẠI";
            dtg_hienthi.Columns[5].Name = "NGÀY SINH";
            dtg_hienthi.Columns[6].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[7].Name = "GIỚI TÍNH";
            dtg_hienthi.Columns[8].Name = "TRẠNG THÁI";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _khachHangService.Find(a))
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaKH, item.HoTen, item.SDT == "0" ? "Khách vãng lai" : item.SDT, item.NgaySinh, item.DiaChi, item.GioiTinh, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public KhachHangView GetData()
        {
            KhachHangView kh = new KhachHangView()
            {
                Id = Guid.Empty,
                MaKH = txt_ma.Text,
                HoTen = txt_hoten.Text,
                SDT = txt_sdt.Text,
                NgaySinh = dateTimePicker1.Value,
                DiaChi = txt_diachi.Text,
                GioiTinh = cbb_gioitinh.Text,
                TrangThai = Convert.ToInt32(rbn_hoatdong.Checked),
            };
            return kh;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_khachHangService.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_khachHangService.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_khachHangService.Delete(temp));
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem(txt_timkiem.Text);
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _khachHangService.Show().FirstOrDefault(c => c.Id == _id);
            txt_ma.Text = temp.MaKH;
            txt_hoten.Text = temp.HoTen;
            txt_sdt.Text = temp.SDT;
            dateTimePicker1.Value = temp.NgaySinh;
            txt_diachi.Text = temp.DiaChi;
            cbb_gioitinh.Text = temp.GioiTinh;
            if (temp.TrangThai == 1)
            {
                rbn_hoatdong.Checked = true;
                return;
            }
            rbn_khonghd.Checked = true;
            txt_ghichu.Text = temp.GhiChu;
        }
    }
}
