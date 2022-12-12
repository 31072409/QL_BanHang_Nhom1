using _1_DAL.Entities;
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
    public partial class Frm_BanHang : Form
    {

        ISanPhamService _isanphamservice;
        IHoaDonChiTietService _ihoadonchitietservice;
        IHoaDonService _ihoadonservice;
        IKhachHangService _ikhachhangservice;
        INhanVienService _inhanvienservice;
        List<HoaDonChiTietView> _lstHoaDonCT;
        Guid _idsp;
        Guid _idhd;
        KhachHang kh;
        string ma;
        public Frm_BanHang()
        {
            InitializeComponent();
            _isanphamservice = new SanPhamServices();
            _ihoadonchitietservice = new HoaDonChiTietService();
            _ihoadonservice = new HoaDonService();
            _ikhachhangservice = new KhachHangService();
            _inhanvienservice = new NhanVienService();
            _lstHoaDonCT = new List<HoaDonChiTietView>();
            kh = new KhachHang();
            LoadHoaDon();
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            dgrid_sanpham.Rows.Clear();
            dgrid_sanpham.ColumnCount = 4;
            dgrid_sanpham.Columns[0].Name = "Mã SP";
            dgrid_sanpham.Columns[1].Name = "Tên SP";
            dgrid_sanpham.Columns[2].Name = "Giá bán";
            dgrid_sanpham.Columns[3].Name = "Số lượng tồn";
            foreach (var item in _isanphamservice.Show())
            {
                if (item.SoLuongTon > 0)
                {
                    dgrid_sanpham.Rows.Add(item.MaSP, item.TenSP, item.GiaBan, item.SoLuongTon);
                }
            }
        }
        public void LoadGioHang()
        {
            dgrid_giohang.Rows.Clear();
            dgrid_giohang.ColumnCount = 5;
            dgrid_giohang.Columns[0].Name = "Mã SP";
            dgrid_giohang.Columns[1].Name = "Tên SP";
            dgrid_giohang.Columns[2].Name = "Số lượng";
            dgrid_giohang.Columns[3].Name = "Giá";
            dgrid_giohang.Columns[4].Name = "Thành tiền";
            foreach (var item in _lstHoaDonCT)
            {
                dgrid_giohang.Rows.Add(item.MaSP, item.TenSP, item.SoLuong, item.DonGia, (item.SoLuong * item.DonGia));
            }
        }
        public void AddGioHang(Guid _idsp)
        {
            var sp = _isanphamservice.Show().FirstOrDefault(x => x.Id == _idsp);
            var data = _lstHoaDonCT.FirstOrDefault(x => x.IdSP == sp.Id);
            if (data == null)
            {
                HoaDonChiTietView hdctview = new HoaDonChiTietView()
                {
                    IdSP = sp.Id,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = 1,
                    MaSP = sp.MaSP,
                };
                _lstHoaDonCT.Add(hdctview);
            }
            else
            {
                if (data.SoLuong <= sp.SoLuongTon)
                {
                    data.SoLuong++;
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã vượt quá số lượng cho phép");
                }
            }
            LoadGioHang();
        }

        private void dgrid_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r == -1) return;
            ma = (dgrid_sanpham.Rows[r].Cells[0].Value.ToString());
            var temp = _isanphamservice.Show().FirstOrDefault(x => x.MaSP == ma).Id;
            AddGioHang(temp);
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow r = dgrid_sanpham.Rows[e.RowIndex];
            //    _idsp = _isanphamservice.Show().FirstOrDefault(x => x.MaSP == r.Cells[0].Value.ToString()).Id;
            //    AddGioHang(_idsp);
            //}
        }

        private void dgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_giohang.Rows[e.RowIndex];
                _idsp = _isanphamservice.Show().FirstOrDefault(x => x.MaSP == r.Cells[0].Value.ToString()).Id;
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            if (_lstHoaDonCT.Any())
            {
                decimal z = 0;
                foreach (var item in _lstHoaDonCT)
                {
                    z += item.SoLuong * item.DonGia;
                }
                //Guid _idnv = _invservices.GetDB().FirstOrDefault(x => x.Email == Properties.Settings1.Default.TKdaLogin).Id;
                Guid _id = _inhanvienservice.Show().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).Id;
                kh = _ikhachhangservice.GetDataFromDB().FirstOrDefault(x => x.SDT == txt_sdt.Text);
                var a = _ihoadonservice.GetDataFromDB().Count;
                if (kh != null)
                {
                    HoaDon hd = new HoaDon()
                    {
                        NgayTao = DateTime.Now,
                        NgayThanhToan = DateTime.Now,
                        Ma = "HD" + ++a,
                        IdNV = _id,
                        IdKH = kh.Id,
                        TongTien = z,
                        TrangThai = 1,
                    };
                    _ihoadonservice.Add(hd);
                    var b = _ihoadonservice.GetDataFromDB().FirstOrDefault(x => x.Ma == hd.Ma);
                    foreach (var item in _lstHoaDonCT)
                    {
                        HoaDonChiTiet hdct = new HoaDonChiTiet()
                        {
                            IdHD = b.Id,
                            IdSP = item.IdSP,
                            DonGia = item.DonGia,
                            SoLuong = item.SoLuong,
                        };
                        _ihoadonchitietservice.Add(hdct);
                        var sp = _isanphamservice.GetDataFromDB().FirstOrDefault(x => x.Id == item.IdSP);
                        sp.SoLuongTon -= item.SoLuong;
                        _isanphamservice.UpdateSP(sp);
                    }
                    txt_ma.Text = hd.Ma;
                    txt_tongtien.Text = hd.TongTien.ToString();
                    txt_sdt.Text = "";
                    MessageBox.Show("Tạo hoá đơn thành công");
                    LoadSanPham();
                    LoadHoaDon();
                    _lstHoaDonCT = new List<HoaDonChiTietView>();
                    dgrid_giohang.Rows.Clear();
                }


            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm trong giỏ hàng");
            }
        }
        public void LoadHoaDon()
        {
            dgrid_hoadoncho.Rows.Clear();
            dgrid_hoadoncho.ColumnCount = 3;
            dgrid_hoadoncho.Columns[0].Name = "ID";
            dgrid_hoadoncho.Columns[0].Visible = false; ;
            dgrid_hoadoncho.Columns[1].Name = "Mã HD";
            dgrid_hoadoncho.Columns[2].Name = "Tổng tiền";
            var hdc = (from a in _ihoadonservice.GetDataFromDB()

                       where a.TrangThai == 1
                       select new { a });
            foreach (var item in hdc)
            {
                dgrid_hoadoncho.Rows.Add(item.a.Id, item.a.Ma, item.a.TongTien);
            }
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_tienkhachdua.Text, out int x))
            {
                txt_tienthua.Text = (decimal.Parse(txt_tienkhachdua.Text) - decimal.Parse(txt_tongtien.Text)).ToString();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text != "")
            {
                HoaDon hd = _ihoadonservice.GetDataFromDB().FirstOrDefault(x => x.Ma == txt_ma.Text && x.TrangThai == 1);
                if (hd == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                    txt_tongtien.Text = "0";
                }
                else
                {
                    var kh = _ikhachhangservice.GetDataFromDB().FirstOrDefault(x => x.Id == hd.IdKH);
                    hd.TrangThai = 2;
                    _ihoadonservice.Updatehd(hd);
                    LoadHoaDon();
                    dgrid_giohang.Rows.Clear();

                    if (Convert.ToDouble(txt_tienkhachdua.Text) < Convert.ToDouble(txt_tongtien.Text))
                    {
                        MessageBox.Show("Không hợp lệ");
                        return;
                    }

                }

            }

        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            if (_lstHoaDonCT.Any())
            {
                var item = _lstHoaDonCT.FirstOrDefault(x => x.IdSP == _idsp);
                _lstHoaDonCT.Remove(item);
                LoadGioHang();
            }
        }

        private void txt_sdt_Click(object sender, EventArgs e)
        {
            txt_sdt.Text = "";
        }

        private void dgrid_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int r = e.RowIndex;
                _idhd = Guid.Parse(dgrid_hoadoncho.CurrentRow.Cells[0].Value.ToString());

                txt_ma.Text = dgrid_hoadoncho.CurrentRow.Cells[1].Value.ToString();
                txt_tongtien.Text = dgrid_hoadoncho.CurrentRow.Cells[2].Value.ToString();
                var a = _ihoadonchitietservice.GetDataFromDB().Where(x => x.IdHD == _idhd);
                var b = _ihoadonservice.GetDataFromDB().FirstOrDefault(x => x.Id == _idhd).IdKH;
                var c = _ikhachhangservice.GetDataFromDB().FirstOrDefault(x => x.Id == b);
                txt_sdt.Text = c.SDT;
                _lstHoaDonCT = new List<HoaDonChiTietView>();
                foreach (var item in a)
                {
                    var sp = _isanphamservice.GetDataFromDB().FirstOrDefault(x => x.Id == item.IdSP);
                    HoaDonChiTietView hdctv = new HoaDonChiTietView()
                    {
                        IdSP = sp.Id,
                        TenSP = sp.Ten,
                        MaSP = sp.Ma,
                        DonGia = (decimal)sp.GiaBan,
                        SoLuong = (int)a.FirstOrDefault(x => x.IdSP == sp.Id).SoLuong,

                    };
                    _lstHoaDonCT.Add(hdctv);
                    LoadGioHang();
                }
            }
        }
    }
}
