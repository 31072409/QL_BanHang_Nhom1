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
    public partial class Frm_QLNhanVien : Form
    {
        INhanVienService _nhanVienService;
        IChucVuService _chucVuService;
        Guid _id;
        public Frm_QLNhanVien()
        {
            InitializeComponent();
            _nhanVienService = new NhanVienService();
            _chucVuService = new ChucVuService();
            LoadChucVu();
            LoadData();
        }
        public void LoadChucVu()
        {
            foreach (var item in _chucVuService.GetAll())
            {
                cbb_chucvu.Items.Add(item.Ten);
            }
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 13;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ VÀ TÊN";
            dtg_hienthi.Columns[4].Name = "GIỚI TÍNH";
            dtg_hienthi.Columns[5].Name = "NGÀY SINH";
            dtg_hienthi.Columns[6].Name = "SĐT";
            dtg_hienthi.Columns[7].Name = "EMAIL";
            dtg_hienthi.Columns[8].Name = "MẬT KHẨU";
            dtg_hienthi.Columns[9].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[10].Name = "TÊN CHỨC VỤ";
            dtg_hienthi.Columns[11].Name = "TRẠNG THÁI";
            dtg_hienthi.Columns[12].Name = "GHI CHÚ";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _nhanVienService.Show())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaNV, item.Ho + " " + item.TenDem + " " + item.Ten, item.GioiTinh, item.NgaySinh, item.SDT, item.Email, item.MatKhau, item.DiaChi, item.TenCV, item.TrangThai == 1 ? "Đang làm việc" : "Đã nghỉ việc", item.GhiChu);
            }
        }
        private void TimKiem(string a)
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 13;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ VÀ TÊN";
            dtg_hienthi.Columns[4].Name = "GIỚI TÍNH";
            dtg_hienthi.Columns[5].Name = "NGÀY SINH";
            dtg_hienthi.Columns[6].Name = "SĐT";
            dtg_hienthi.Columns[7].Name = "EMAIL";
            dtg_hienthi.Columns[8].Name = "MẬT KHẨU";
            dtg_hienthi.Columns[9].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[10].Name = "TÊN CHỨC VỤ";
            dtg_hienthi.Columns[11].Name = "TRẠNG THÁI";
            dtg_hienthi.Columns[12].Name = "GHI CHÚ";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _nhanVienService.Find(a))
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaNV, item.Ho + " " + item.TenDem + " " + item.Ten, item.GioiTinh, item.NgaySinh, item.SDT, item.Email, item.MatKhau, item.DiaChi, item.TenCV, item.TrangThai == 1 ? "Đang làm việc" : "Đã nghỉ việc", item.GhiChu);
            }
        }
        public NhanVienView GetData()
        {
            NhanVienView nv = new NhanVienView()
            {
                Id = Guid.Empty,
                IdCV = _chucVuService.GetAll().FirstOrDefault(c => c.Ten == cbb_chucvu.Text).Id,
                MaNV = txt_manhanvien.Text,
                Ho = txt_ho.Text,
                TenDem = txt_tendem.Text,
                Ten = txt_ten.Text,
                GioiTinh = cbb_gioitinh.Text,
                NgaySinh = dtp_ngaysinh.Value,
                DiaChi = txt_diachi.Text,
                SDT = txt_sdt.Text,
                Email = txt_email.Text,
                MatKhau = txt_matkhau.Text,
                TenCV = cbb_chucvu.Text,
                TrangThai = Convert.ToInt32(rbn_danglamviec.Checked),
                GhiChu = txt_ghichu.Text,
            };
            return nv;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_nhanVienService.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhanVienService.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhanVienService.Delete(temp));
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem(txt_timkiem.Text);
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _nhanVienService.Show().FirstOrDefault(c => c.Id == _id);
            txt_manhanvien.Text = temp.MaNV;
            txt_ho.Text = temp.Ho;
            txt_tendem.Text = temp.TenDem;
            txt_ten.Text = temp.Ten;
            cbb_gioitinh.Text = temp.GioiTinh;
            txt_diachi.Text = temp.DiaChi;
            dtp_ngaysinh.Value = temp.NgaySinh;
            txt_sdt.Text = temp.SDT;
            txt_email.Text = temp.Email;
            txt_matkhau.Text = temp.MatKhau;
            cbb_chucvu.SelectedIndex = cbb_chucvu.FindStringExact(_chucVuService.GetAll().FirstOrDefault(c => c.Id == temp.IdCV).Ten.ToString());
            if (temp.TrangThai == 1)
            {
                rbn_danglamviec.Checked = true;
                return;
            }
            rbn_danghiviec.Checked = true;
            txt_ghichu.Text = temp.GhiChu;
        }
    }
}
