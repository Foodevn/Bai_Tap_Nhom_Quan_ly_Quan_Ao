namespace Quan_ly_Shop_Quan_ao_1
{
	partial class formDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
			this.lblDangNhap = new System.Windows.Forms.Label();
			this.lblTenDN = new System.Windows.Forms.Label();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.lbThongBao = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panelLogoShop = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lblDangNhap
			// 
			this.lblDangNhap.AutoSize = true;
			this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblDangNhap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblDangNhap.Location = new System.Drawing.Point(757, 135);
			this.lblDangNhap.Name = "lblDangNhap";
			this.lblDangNhap.Size = new System.Drawing.Size(190, 39);
			this.lblDangNhap.TabIndex = 0;
			this.lblDangNhap.Text = "Đăng Nhập";
			// 
			// lblTenDN
			// 
			this.lblTenDN.AutoSize = true;
			this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTenDN.Location = new System.Drawing.Point(642, 265);
			this.lblTenDN.Name = "lblTenDN";
			this.lblTenDN.Size = new System.Drawing.Size(119, 20);
			this.lblTenDN.TabIndex = 2;
			this.lblTenDN.Text = "Tên đăng nhập";
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenDangNhap.Location = new System.Drawing.Point(783, 265);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(203, 22);
			this.txtTenDangNhap.TabIndex = 0;
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblMatKhau.Location = new System.Drawing.Point(684, 317);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(77, 20);
			this.lblMatKhau.TabIndex = 2;
			this.lblMatKhau.Text = "Mật khẩu";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMatKhau.Location = new System.Drawing.Point(783, 318);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(203, 22);
			this.txtMatKhau.TabIndex = 1;
			// 
			// lbThongBao
			// 
			this.lbThongBao.AutoSize = true;
			this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongBao.ForeColor = System.Drawing.Color.LightGray;
			this.lbThongBao.Location = new System.Drawing.Point(668, 363);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.Size = new System.Drawing.Size(13, 20);
			this.lbThongBao.TabIndex = 2;
			this.lbThongBao.Text = ".";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnDangNhap.Location = new System.Drawing.Point(646, 409);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(145, 39);
			this.btnDangNhap.TabIndex = 2;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
			this.btnThoat.Location = new System.Drawing.Point(854, 409);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(132, 39);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// panelLogoShop
			// 
			this.panelLogoShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoShop.BackgroundImage")));
			this.panelLogoShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelLogoShop.Location = new System.Drawing.Point(1, 2);
			this.panelLogoShop.Name = "panelLogoShop";
			this.panelLogoShop.Size = new System.Drawing.Size(599, 701);
			this.panelLogoShop.TabIndex = 4;
			// 
			// formDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1083, 705);
			this.Controls.Add(this.panelLogoShop);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.lbThongBao);
			this.Controls.Add(this.lblMatKhau);
			this.Controls.Add(this.lblTenDN);
			this.Controls.Add(this.lblDangNhap);
			this.Name = "formDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangNhap_FormClosing);
			this.Load += new System.EventHandler(this.formDangNhap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDangNhap;
		private System.Windows.Forms.Label lblTenDN;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label lbThongBao;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Panel panelLogoShop;
	}
}

