using BusinessLog;
using DataAccess;
using quan_ly_shop_quan_ao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Shop_Quan_ao_1
{
	public partial class formDangNhap : Form
	{
		public string MaNV {  get; set; }
		public formDangNhap()
		{
			InitializeComponent();			
		}
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			
			if(string.IsNullOrWhiteSpace(txtTenDangNhap.Text)||string.IsNullOrWhiteSpace(txtMatKhau.Text))
			{
				lbThongBao.Text = "Vui lòng nhập tên và mật khẩu";
				lbThongBao.ForeColor=Color.Red;
				return;
			}
			List<NhanVien> listNhanVien= new List<NhanVien>();
			NhanVienBL nhanVienBL = new NhanVienBL();
			listNhanVien = nhanVienBL.GetAll();
			foreach(NhanVien nhanVien in listNhanVien)
			{
				
				if(nhanVien.MaNhanVien.Trim().ToLower() == txtTenDangNhap.Text.Trim().ToLower() &&
					nhanVien.MatKhau.Trim() == txtMatKhau.Text)
				{
					
					this.Hide();
					menu form = new menu();
					form.MaNhanVienFormMenu=nhanVien.MaNhanVien;
					form.Show();
					return;
				}
			}
			MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa đúng!");

		}
		public string test()
		{
			return "NV0001"; 
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void formDangNhap_Load(object sender, EventArgs e)
		{
			
			this.KeyPreview = true;
			this.AcceptButton = btnDangNhap;
		}

		private void formDangNhap_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
