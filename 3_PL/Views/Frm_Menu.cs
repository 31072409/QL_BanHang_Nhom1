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
    public partial class Frm_Menu : Form
    {
        INhanVienService _invservice;
        public Frm_Menu()
        {
            InitializeComponent();
            _invservice = new NhanVienService();
        }
        public Frm_Menu(string chucvu, string tennv)
        {
            InitializeComponent();
            _invservice = new NhanVienService();
            lb_chucvu.Text = chucvu;
            lb_ten.Text = tennv;
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            if (lb_chucvu.Text == "Quản Lý")
            {
                btn_banhang.Enabled = true;
                btn_khachhang.Enabled = true;
                btn_nhanvien.Enabled = true;
                btn_sp.Enabled = true;
                btn_chucvu.Enabled = true;
                btn_nsx.Enabled = true;
            }
            else
            {

                btn_banhang.Enabled = true;
                btn_khachhang.Enabled = true;
                btn_nhanvien.Enabled = false;
                btn_sp.Enabled = true;
                btn_chucvu.Enabled = false;
                btn_nsx.Enabled = true;
            }
        }
        private Form currentFormChild;
        public void OpenChildForm(Form childform)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pl_body.Controls.Add(childform);
            pl_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_QLSanPham());
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BanHang());
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_QLKhachHang());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_QLNhanVien());
        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ChucVu());
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NhaSX());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_HoaDon());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap frmloin = new Frm_DangNhap();
                frmloin.ShowDialog();
            }
        }
    }
}
