namespace _3_PL.Views
{
    partial class Frm_BanHang 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tienthua = new System.Windows.Forms.TextBox();
            this.txt_tienkhachdua = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_hoadoncho = new System.Windows.Forms.DataGridView();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.dgrid_giohang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_sanpham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_taohoadon = new System.Windows.Forms.Button();
            this.btn_xoasp = new System.Windows.Forms.Button();
            this.btn_xoagiohang = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadoncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tienthua
            // 
            this.txt_tienthua.Enabled = false;
            this.txt_tienthua.Location = new System.Drawing.Point(139, 124);
            this.txt_tienthua.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tienthua.Name = "txt_tienthua";
            this.txt_tienthua.Size = new System.Drawing.Size(171, 23);
            this.txt_tienthua.TabIndex = 8;
            // 
            // txt_tienkhachdua
            // 
            this.txt_tienkhachdua.Location = new System.Drawing.Point(139, 94);
            this.txt_tienkhachdua.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tienkhachdua.Name = "txt_tienkhachdua";
            this.txt_tienkhachdua.Size = new System.Drawing.Size(171, 23);
            this.txt_tienkhachdua.TabIndex = 7;
            this.txt_tienkhachdua.TextChanged += new System.EventHandler(this.txt_tienkhachdua_TextChanged);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(139, 60);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(171, 23);
            this.txt_tongtien.TabIndex = 6;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(139, 28);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(171, 23);
            this.txt_ma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền thừa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền khách đưa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // dgrid_hoadoncho
            // 
            this.dgrid_hoadoncho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadoncho.Location = new System.Drawing.Point(4, 22);
            this.dgrid_hoadoncho.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_hoadoncho.Name = "dgrid_hoadoncho";
            this.dgrid_hoadoncho.RowHeadersWidth = 62;
            this.dgrid_hoadoncho.RowTemplate.Height = 33;
            this.dgrid_hoadoncho.Size = new System.Drawing.Size(304, 170);
            this.dgrid_hoadoncho.TabIndex = 0;
            this.dgrid_hoadoncho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_hoadoncho_CellClick);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(363, 183);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(172, 23);
            this.txt_sdt.TabIndex = 4;
            this.txt_sdt.Text = "Nhập SDT KH";
            this.txt_sdt.Click += new System.EventHandler(this.txt_sdt_Click);
            // 
            // dgrid_giohang
            // 
            this.dgrid_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_giohang.Location = new System.Drawing.Point(4, 21);
            this.dgrid_giohang.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_giohang.Name = "dgrid_giohang";
            this.dgrid_giohang.RowHeadersWidth = 62;
            this.dgrid_giohang.RowTemplate.Height = 33;
            this.dgrid_giohang.Size = new System.Drawing.Size(528, 148);
            this.dgrid_giohang.TabIndex = 0;
            this.dgrid_giohang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_giohang_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_hoadoncho);
            this.groupBox3.Location = new System.Drawing.Point(616, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(319, 200);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoá đơn chờ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_sanpham);
            this.groupBox2.Location = new System.Drawing.Point(66, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(536, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // dgrid_sanpham
            // 
            this.dgrid_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sanpham.Location = new System.Drawing.Point(2, 20);
            this.dgrid_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_sanpham.Name = "dgrid_sanpham";
            this.dgrid_sanpham.RowHeadersWidth = 62;
            this.dgrid_sanpham.RowTemplate.Height = 33;
            this.dgrid_sanpham.Size = new System.Drawing.Size(530, 177);
            this.dgrid_sanpham.TabIndex = 0;
            this.dgrid_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sanpham_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.dgrid_giohang);
            this.groupBox1.Location = new System.Drawing.Point(67, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(536, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_taohoadon);
            this.panel1.Controls.Add(this.btn_xoasp);
            this.panel1.Controls.Add(this.btn_xoagiohang);
            this.panel1.Location = new System.Drawing.Point(5, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 27);
            this.panel1.TabIndex = 29;
            // 
            // btn_taohoadon
            // 
            this.btn_taohoadon.Location = new System.Drawing.Point(234, 4);
            this.btn_taohoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_taohoadon.Name = "btn_taohoadon";
            this.btn_taohoadon.Size = new System.Drawing.Size(99, 20);
            this.btn_taohoadon.TabIndex = 11;
            this.btn_taohoadon.Text = "Tạo hoá đơn";
            this.btn_taohoadon.UseVisualStyleBackColor = true;
            this.btn_taohoadon.Click += new System.EventHandler(this.btn_taohoadon_Click);
            // 
            // btn_xoasp
            // 
            this.btn_xoasp.Location = new System.Drawing.Point(2, 4);
            this.btn_xoasp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoasp.Name = "btn_xoasp";
            this.btn_xoasp.Size = new System.Drawing.Size(104, 20);
            this.btn_xoasp.TabIndex = 9;
            this.btn_xoasp.Text = "Xoá sản phẩm";
            this.btn_xoasp.UseVisualStyleBackColor = true;
            this.btn_xoasp.Click += new System.EventHandler(this.btn_xoasp_Click);
            // 
            // btn_xoagiohang
            // 
            this.btn_xoagiohang.Location = new System.Drawing.Point(119, 4);
            this.btn_xoagiohang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoagiohang.Name = "btn_xoagiohang";
            this.btn_xoagiohang.Size = new System.Drawing.Size(99, 20);
            this.btn_xoagiohang.TabIndex = 10;
            this.btn_xoagiohang.Text = "Xoá giỏ hàng";
            this.btn_xoagiohang.UseVisualStyleBackColor = true;
            this.btn_xoagiohang.Click += new System.EventHandler(this.btn_xoagiohang_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_thanhtoan);
            this.groupBox4.Controls.Add(this.txt_tienthua);
            this.groupBox4.Controls.Add(this.txt_tienkhachdua);
            this.groupBox4.Controls.Add(this.txt_tongtien);
            this.groupBox4.Controls.Add(this.txt_ma);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(615, 267);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(321, 200);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh toán";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(118, 168);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(78, 20);
            this.btn_thanhtoan.TabIndex = 10;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Frm_BanHang";
            this.Text = "Frm_BanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadoncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_giohang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tienthua;
        private System.Windows.Forms.TextBox txt_tienkhachdua;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_hoadoncho;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DataGridView dgrid_giohang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_sanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_taohoadon;
        private System.Windows.Forms.Button btn_xoasp;
        private System.Windows.Forms.Button btn_xoagiohang;
        private System.Windows.Forms.Button btn_thanhtoan;
    }
}