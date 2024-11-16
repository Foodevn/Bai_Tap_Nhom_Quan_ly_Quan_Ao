
using Quan_ly_Shop_Quan_ao_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BusinessLog;
using DataAccess;

namespace quan_ly_shop_quan_ao
{
	public partial class formShop : Form
	{
		List<KhachHang> listKhachHang=new List<KhachHang>();
		KhachHang khachHang;
		public formShop()
		{
			InitializeComponent();
			lvDS.DoubleClick += new EventHandler(listView1_DoubleClick);
			start();
			
		}
		
		public void start()
		{
			mtbNgayLap.Text = DateTime.Now.ToString();
			TaiDanhSach1();
		}
		public void TaiDanhSach1()
		{
			KhachHangBL khachHangBL = new KhachHangBL();
			listKhachHang = khachHangBL.GetAll();
			int count = 1;
			foreach(KhachHang khachHang in listKhachHang)
			{
				ListViewItem item = lvDS.Items.Add(count.ToString());
				item.SubItems.Add(khachHang.TenKhachHang);


			}

		}
		

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchText = txtTimKiem.Text.Trim().ToLower();

			List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
			if (string.IsNullOrEmpty(searchText))
			{
				lvDS.Items.Clear();
				TaiDanhSach1();
				return;
			}

			foreach (ListViewItem item in lvDS.Items)
			{

				string maHang = item.SubItems[0].Text.ToLower();
				string tenHang = item.SubItems[1].Text.ToLower();

				if (maHang.Contains(searchText) || tenHang.Contains(searchText))
				{

					ketQuaTimKiem.Add(item);
				}
			}
			lvDS.Items.Clear();
			foreach (ListViewItem resultItem in ketQuaTimKiem)
			{
				lvDS.Items.Add(resultItem);

			}
			//listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			if (ketQuaTimKiem.Count == 0)
			{
				MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


		}

		private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
		{
			//lvds.items.clear();
			//taidanhsach1();

		}

		private void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtTimKiem.Clear();
		}

		
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (lvDS.SelectedItems.Count > 0)
			{
				ListViewItem Item1 = lvDS.SelectedItems[0];
				ListViewItem newItem = (ListViewItem)Item1.Clone();
				lvChiTietDonhang.Items.Add(newItem);
				lvChiTietDonhang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			}

		}

		private void btnHuyBo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void ClearForm()
		{
			txtHoTen.Text = "";
			mtbSDT.Text = "";
			txtDiaChi.Text = "";

			lvChiTietDonhang.Items.Clear(); 

			mtbNgayLap.Text = "";
			txtTongTienHang.Text = "";
			txtPhiGiaoHang.Text = "";
			txtTongThanhToan.Text = "";
			txtGhiChu.Text = "";
			txtGiamGia.Text = "";
			txtThueVAT.Text = "";

			lbl_Tongtien.Text = "Không Đồng";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{

		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{

		}
	}
}
