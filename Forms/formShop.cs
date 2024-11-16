
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
		List<SanPham> listSanPham = new List<SanPham>();
		List<MauSac> listMauSac = new List<MauSac>();
		List<DataAccess.Size> listSize = new List<DataAccess.Size>();
		public formShop()
		{
			InitializeComponent();
			lvDS.DoubleClick += new EventHandler(listView1_DoubleClick);
		}
		private void formShop_Load(object sender, EventArgs e)
		{
			mtbNgayLap.Text = DateTime.Now.ToString();
			LoadMauSac();
			LoadSize();
			LoadSanPhamToListView();
		}
		private void LoadMauSac()
		{
			MauSacBL mauSacBL = new MauSacBL();
			listMauSac = mauSacBL.GetAll();
			cbbMau.DataSource = listMauSac;
			cbbMau.ValueMember = "MaMau";
			cbbMau.DisplayMember= "TenMau";
		}
		void LoadSize()
		{
			SizeBL sizeBL = new SizeBL();
			listSize = sizeBL.GetAll();
			cbbSize.DataSource = listSize;
			cbbSize.ValueMember = "MaSize";
			cbbSize.DisplayMember = "TenSize";
		}

		public void LoadSanPhamToListView()
		{
			SanPhamBL sanPhamBL = new SanPhamBL();
			listSanPham=sanPhamBL.GetAll();
			lvDS.Items.Clear();
			foreach(SanPham sp in listSanPham)
			{
				ListViewItem item = lvDS.Items.Add(sp.MaSP);
				item.SubItems.Add(sp.TenSP);
				item.SubItems.Add(sp.GiaBan.ToString());
				item.SubItems.Add(sp.SLTon.ToString());
				string tenMauSac = listMauSac.Find(x => x.MaMau == sp.IDMau).TenMau;
				item.SubItems.Add(tenMauSac);
				string tenSize=listSize.Find(x=>x.MaSize==sp.IDSize).TenSize;
				item.SubItems.Add(tenSize);
			}
			lvDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lvDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchText = txtTimKiem.Text.Trim().ToLower();
			List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
			if (string.IsNullOrEmpty(searchText))
			{
				lvDS.Items.Clear();
				LoadSanPhamToListView();
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
			if (ketQuaTimKiem.Count == 0)
			{
				MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
		{
			LoadSanPhamToListView();
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

		private void cbbMau_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			string searchText = txtTimKiem.Text.Trim().ToLower();
			List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
			if (string.IsNullOrEmpty(searchText))
			{
				lvDS.Items.Clear();
				LoadSanPhamToListView();
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
			if (ketQuaTimKiem.Count == 0)
			{
				MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void btnThoat_Click(object sender, EventArgs e)
		{

		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{

		}

		
	}
}
