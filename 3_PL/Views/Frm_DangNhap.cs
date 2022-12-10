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
    public partial class Frm_DangNhap : Form
    {
        INhanVienService _inhanvienservice;
        IChucVuService _ichucvuservice;
        public Frm_DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            _inhanvienservice = new NhanVienService();
            _ichucvuservice = new ChucVuService();
            txt_email.Text = Properties.Settings.Default.tk;
            txt_mk.Text = Properties.Settings.Default.mk;
            GetAll();
        }
        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst = (from a in _inhanvienservice.Show()
                   join b in _ichucvuservice.GetAll()
                   on a.IdCV equals b.Id
                   select new ChucVuView()
                   {
                       Ma = b.Ma,
                       Ten = b.Ten,
                       Id = b.Id,
                   }).ToList();

            return lst;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int stt = 0;
            foreach (var x in _inhanvienservice.Show())
            {
                if (x.Email == txt_email.Text && x.MatKhau == txt_mk.Text)
                {
                    var name = GetAll().FirstOrDefault(c => c.Id == x.IdCV).Ten;
                    string hovaten = x.Ho + " " + x.TenDem + " " + x.Ten;
                    Frm_Menu menu = new Frm_Menu(name, hovaten);
                    stt = 1;
                    menu.ShowDialog();
                    break;
                }
            }
            if (stt != 1)
            {
                MessageBox.Show("Tài khoản không tồn tại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_QuenMK qmk = new Frm_QuenMK();

            qmk.ShowDialog();
        }
        public void Save()
        {
            if (ck_remember.Checked == true)
            {
                Properties.Settings.Default.tk = txt_email.Text;
                Properties.Settings.Default.mk = txt_mk.Text;
                Properties.Settings.Default.TKdaLogin = txt_email.Text;
                Properties.Settings.Default.MKdaLogin = txt_mk.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = txt_email.Text;
                Properties.Settings.Default.MKdaLogin = txt_mk.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
        }

        private void txt_mk_Click(object sender, EventArgs e)
        {
            txt_mk.Text = "";
        }

        private void ck_remember_CheckedChanged(object sender, EventArgs e)
        {
            Save();
        }
    }
}
