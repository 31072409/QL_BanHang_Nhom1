using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class Frm_QuenMK : Form
    {
        INhanVienService _inhanvienservice;
        INhanVienRepository _inhanvienrep;
        public Frm_QuenMK()
        {
            InitializeComponent();
            _inhanvienservice=new NhanVienService();
            _inhanvienrep = new NhanVienRepository();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var user = _inhanvienrep.GetAll().First(c => c.Email == txt_email.Text);
            if (user == null)
            {   
                MessageBox.Show("Tài khoản không tồn tại ");
                return;
            }
            {
                if (txt_mk.Text != "")
                {
                    if (txt_mkm.Text == txt_mk.Text)
                    {
                        user.Email = txt_email.Text;
                        user.MatKhau = txt_mk.Text;
                        _inhanvienrep.Update(user);
                        MessageBox.Show("Thành Công ");
                    }
                    else if (txt_mk.Text != txt_mkm.Text)
                    {

                        MessageBox.Show("Mật khẩu không chính xác ");
                    }
                }
                else if (txt_mk.Text == "")
                {
                    MessageBox.Show("Nhập mật khẩu đã ");
                }
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap dn = new Frm_DangNhap();
            dn.ShowDialog();
        }
    }
}
