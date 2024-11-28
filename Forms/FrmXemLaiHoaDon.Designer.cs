namespace XemLaiHoaDon
{
    partial class FrmXemLaiHoaDon
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
			this.lblNgayBatDau = new System.Windows.Forms.Label();
			this.lblNgayKetThuc = new System.Windows.Forms.Label();
			this.lblKhachHang = new System.Windows.Forms.Label();
			this.lblSDT = new System.Windows.Forms.Label();
			this.lblTrangThai = new System.Windows.Forms.Label();
			this.lblLapBoi = new System.Windows.Forms.Label();
			this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
			this.txtKhachHang = new System.Windows.Forms.TextBox();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.cbTrangThai = new System.Windows.Forms.ComboBox();
			this.cbNhanVienLap = new System.Windows.Forms.ComboBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lvDSHoaDon = new System.Windows.Forms.ListView();
			this.clhMaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhNgayHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhSdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhTienHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhPhiShip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhTienThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhXoaHuy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblTongDoanhThu = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNgayBatDau
			// 
			this.lblNgayBatDau.AutoSize = true;
			this.lblNgayBatDau.Location = new System.Drawing.Point(13, 21);
			this.lblNgayBatDau.Name = "lblNgayBatDau";
			this.lblNgayBatDau.Size = new System.Drawing.Size(76, 16);
			this.lblNgayBatDau.TabIndex = 0;
			this.lblNgayBatDau.Text = "Lập từ ngày";
			this.lblNgayBatDau.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblNgayKetThuc
			// 
			this.lblNgayKetThuc.AutoSize = true;
			this.lblNgayKetThuc.Location = new System.Drawing.Point(13, 62);
			this.lblNgayKetThuc.Name = "lblNgayKetThuc";
			this.lblNgayKetThuc.Size = new System.Drawing.Size(64, 16);
			this.lblNgayKetThuc.TabIndex = 0;
			this.lblNgayKetThuc.Text = "Đến ngày";
			this.lblNgayKetThuc.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblKhachHang
			// 
			this.lblKhachHang.AutoSize = true;
			this.lblKhachHang.Location = new System.Drawing.Point(226, 21);
			this.lblKhachHang.Name = "lblKhachHang";
			this.lblKhachHang.Size = new System.Drawing.Size(77, 16);
			this.lblKhachHang.TabIndex = 0;
			this.lblKhachHang.Text = "Khách hàng";
			this.lblKhachHang.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblSDT
			// 
			this.lblSDT.AutoSize = true;
			this.lblSDT.Location = new System.Drawing.Point(217, 57);
			this.lblSDT.Name = "lblSDT";
			this.lblSDT.Size = new System.Drawing.Size(85, 16);
			this.lblSDT.TabIndex = 0;
			this.lblSDT.Text = "Số điện thoại";
			this.lblSDT.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblTrangThai
			// 
			this.lblTrangThai.AutoSize = true;
			this.lblTrangThai.Location = new System.Drawing.Point(510, 15);
			this.lblTrangThai.Name = "lblTrangThai";
			this.lblTrangThai.Size = new System.Drawing.Size(67, 16);
			this.lblTrangThai.TabIndex = 0;
			this.lblTrangThai.Text = "Trạng thái";
			this.lblTrangThai.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblLapBoi
			// 
			this.lblLapBoi.AutoSize = true;
			this.lblLapBoi.Location = new System.Drawing.Point(525, 56);
			this.lblLapBoi.Name = "lblLapBoi";
			this.lblLapBoi.Size = new System.Drawing.Size(52, 16);
			this.lblLapBoi.TabIndex = 0;
			this.lblLapBoi.Text = "Lập bởi";
			this.lblLapBoi.Click += new System.EventHandler(this.label1_Click);
			// 
			// dtpNgayLap
			// 
			this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayLap.Location = new System.Drawing.Point(98, 15);
			this.dtpNgayLap.Name = "dtpNgayLap";
			this.dtpNgayLap.Size = new System.Drawing.Size(111, 22);
			this.dtpNgayLap.TabIndex = 1;
			this.dtpNgayLap.Value = new System.DateTime(2024, 9, 8, 0, 0, 0, 0);
			// 
			// dtpNgayDen
			// 
			this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayDen.Location = new System.Drawing.Point(98, 57);
			this.dtpNgayDen.Name = "dtpNgayDen";
			this.dtpNgayDen.Size = new System.Drawing.Size(111, 22);
			this.dtpNgayDen.TabIndex = 1;
			// 
			// txtKhachHang
			// 
			this.txtKhachHang.Location = new System.Drawing.Point(309, 15);
			this.txtKhachHang.Name = "txtKhachHang";
			this.txtKhachHang.Size = new System.Drawing.Size(198, 22);
			this.txtKhachHang.TabIndex = 2;
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(309, 50);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(198, 22);
			this.txtSdt.TabIndex = 2;
			this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
			// 
			// cbTrangThai
			// 
			this.cbTrangThai.FormattingEnabled = true;
			this.cbTrangThai.Items.AddRange(new object[] {
            "Hoàn Thành",
            "Chưa Thanh Toán"});
			this.cbTrangThai.Location = new System.Drawing.Point(583, 15);
			this.cbTrangThai.Name = "cbTrangThai";
			this.cbTrangThai.Size = new System.Drawing.Size(144, 24);
			this.cbTrangThai.TabIndex = 3;
			// 
			// cbNhanVienLap
			// 
			this.cbNhanVienLap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNhanVienLap.FormattingEnabled = true;
			this.cbNhanVienLap.Location = new System.Drawing.Point(583, 50);
			this.cbNhanVienLap.Name = "cbNhanVienLap";
			this.cbNhanVienLap.Size = new System.Drawing.Size(144, 24);
			this.cbNhanVienLap.TabIndex = 3;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(758, 18);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(84, 23);
			this.btnTim.TabIndex = 4;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(9, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(114, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tổng doanh thu";
			this.label7.Click += new System.EventHandler(this.label1_Click);
			// 
			// lvDSHoaDon
			// 
			this.lvDSHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMaDon,
            this.clhNhanVien,
            this.clhNgayHoaDon,
            this.clhKhachHang,
            this.clhSdt,
            this.clhTienHang,
            this.clhGiamGia,
            this.clhPhiShip,
            this.clhTienThue,
            this.clhThanhTien,
            this.clhTrangThai,
            this.clhXoaHuy});
			this.lvDSHoaDon.GridLines = true;
			this.lvDSHoaDon.HideSelection = false;
			this.lvDSHoaDon.Location = new System.Drawing.Point(12, 133);
			this.lvDSHoaDon.Name = "lvDSHoaDon";
			this.lvDSHoaDon.Size = new System.Drawing.Size(1028, 468);
			this.lvDSHoaDon.TabIndex = 5;
			this.lvDSHoaDon.UseCompatibleStateImageBehavior = false;
			this.lvDSHoaDon.View = System.Windows.Forms.View.Details;
			// 
			// clhMaDon
			// 
			this.clhMaDon.Text = "Mã đơn";
			this.clhMaDon.Width = 62;
			// 
			// clhNhanVien
			// 
			this.clhNhanVien.Text = "Nhân viên";
			this.clhNhanVien.Width = 74;
			// 
			// clhNgayHoaDon
			// 
			this.clhNgayHoaDon.Text = "Ngày hóa đơn";
			this.clhNgayHoaDon.Width = 107;
			// 
			// clhKhachHang
			// 
			this.clhKhachHang.Text = "Khách hàng";
			this.clhKhachHang.Width = 85;
			// 
			// clhSdt
			// 
			this.clhSdt.Text = "Số điện thoại";
			this.clhSdt.Width = 97;
			// 
			// clhTienHang
			// 
			this.clhTienHang.Text = "Tiền hàng";
			this.clhTienHang.Width = 80;
			// 
			// clhGiamGia
			// 
			this.clhGiamGia.Text = "Giảm giá";
			this.clhGiamGia.Width = 77;
			// 
			// clhPhiShip
			// 
			this.clhPhiShip.Text = "Phí ship";
			// 
			// clhTienThue
			// 
			this.clhTienThue.Text = "Tiền thuế";
			this.clhTienThue.Width = 77;
			// 
			// clhThanhTien
			// 
			this.clhThanhTien.Text = "Thành tiền";
			this.clhThanhTien.Width = 80;
			// 
			// clhTrangThai
			// 
			this.clhTrangThai.Text = "Trạng thái";
			this.clhTrangThai.Width = 82;
			// 
			// clhXoaHuy
			// 
			this.clhXoaHuy.Text = "Xóa/Hủy";
			this.clhXoaHuy.Width = 78;
			// 
			// lblTongDoanhThu
			// 
			this.lblTongDoanhThu.AutoSize = true;
			this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
			this.lblTongDoanhThu.Location = new System.Drawing.Point(143, 97);
			this.lblTongDoanhThu.Name = "lblTongDoanhThu";
			this.lblTongDoanhThu.Size = new System.Drawing.Size(15, 16);
			this.lblTongDoanhThu.TabIndex = 6;
			this.lblTongDoanhThu.Text = "0";
			// 
			// FrmXemLaiHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 613);
			this.Controls.Add(this.lblTongDoanhThu);
			this.Controls.Add(this.lvDSHoaDon);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.cbNhanVienLap);
			this.Controls.Add(this.cbTrangThai);
			this.Controls.Add(this.txtSdt);
			this.Controls.Add(this.txtKhachHang);
			this.Controls.Add(this.dtpNgayDen);
			this.Controls.Add(this.dtpNgayLap);
			this.Controls.Add(this.lblLapBoi);
			this.Controls.Add(this.lblTrangThai);
			this.Controls.Add(this.lblSDT);
			this.Controls.Add(this.lblKhachHang);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblNgayKetThuc);
			this.Controls.Add(this.lblNgayBatDau);
			this.Name = "FrmXemLaiHoaDon";
			this.Text = "Hóa đơn bán hàng";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblLapBoi;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbNhanVienLap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvDSHoaDon;
        private System.Windows.Forms.ColumnHeader clhMaDon;
        private System.Windows.Forms.ColumnHeader clhNhanVien;
        private System.Windows.Forms.ColumnHeader clhNgayHoaDon;
        private System.Windows.Forms.ColumnHeader clhKhachHang;
        private System.Windows.Forms.ColumnHeader clhSdt;
        private System.Windows.Forms.ColumnHeader clhTienHang;
        private System.Windows.Forms.ColumnHeader clhGiamGia;
        private System.Windows.Forms.ColumnHeader clhPhiShip;
        private System.Windows.Forms.ColumnHeader clhTienThue;
        private System.Windows.Forms.ColumnHeader clhThanhTien;
        private System.Windows.Forms.ColumnHeader clhTrangThai;
        private System.Windows.Forms.ColumnHeader clhXoaHuy;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}

