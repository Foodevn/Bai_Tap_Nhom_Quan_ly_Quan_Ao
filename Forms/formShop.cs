
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
using Microsoft.VisualBasic;

using BusinessLog;
using DataAccess;
using System.Diagnostics;
using System.Globalization;

namespace quan_ly_shop_quan_ao
{
	public partial class formShop : Form
	{
		List<SanPham> listSanPham = new List<SanPham>();
		List<MauSac> listMauSac = new List<MauSac>();
		List<DataAccess.Size> listSize = new List<DataAccess.Size>();
		List<SanPham> listDonHang = new List<SanPham>();
		public string MaNhanVienFormShop { get; set; }
		public formShop()
		{
			InitializeComponent();

		}
		private void formShop_Load(object sender, EventArgs e)
		{
			mtbNgayLap.Text = DateTime.Now.ToString();

			MauSacBL mauSacBL = new MauSacBL();
			listMauSac = mauSacBL.GetAll();

			SizeBL sizeBL = new SizeBL();
			listSize = sizeBL.GetAll();

			LoadSize();
			LoadMauSac();
			LoadSanPhamToListView();
			
		}
		private void LoadMauSac()
		{
			cbbMau.SelectedIndexChanged -= cbbMau_SelectedIndexChanged;
			cbbMau.DataSource = listMauSac;

			cbbMau.ValueMember = "MaMau";
			cbbMau.DisplayMember = "TenMau";
			cbbMau.SelectedIndexChanged += cbbMau_SelectedIndexChanged;
		}
		void LoadSize()
		{

			cbbSize.DataSource = listSize;
			cbbSize.ValueMember = "MaSize";
			cbbSize.DisplayMember = "TenSize";
		}
		public void LoadSanPhamToListView()
		{
			SanPhamBL sanPhamBL = new SanPhamBL();
			listSanPham = sanPhamBL.GetAll();
			LoadlvDS(listSanPham);

		}
		void LoadlvDS(List<SanPham> list)
		{
			lvDS.Items.Clear();
			foreach (SanPham sp in list)
			{
				ListViewItem item = lvDS.Items.Add(sp.MaSP);
				item.SubItems.Add(sp.TenSP);
				item.SubItems.Add(sp.GiaBan.ToString());
				item.SubItems.Add(sp.SLTon.ToString());
				string tenMauSac = listMauSac.Find(x => x.MaMau == sp.IDMau).TenMau;
				item.SubItems.Add(tenMauSac);
				string tenSize = listSize.Find(x => x.MaSize == sp.IDSize).TenSize;
				item.SubItems.Add(tenSize);
				
			}
			lvDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lvDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		void LoadlvDonHang(List<SanPham> list)
		{
			lvChiTietDonhang.Items.Clear();
			foreach (SanPham sp in list)
			{
				ListViewItem item = lvChiTietDonhang.Items.Add(sp.MaSP);
				item.SubItems.Add(sp.TenSP);
				item.SubItems.Add(sp.GiaBan.ToString("F0"));
				item.SubItems.Add(sp.GiamGia.ToString());
				item.SubItems.Add(sp.SLTon.ToString());
				float thanhTien = sp.SLTon * sp.GiaBan - (sp.SLTon * sp.GiaBan) * sp.GiamGia / 100;
				item.SubItems.Add(thanhTien.ToString("F0"));
			}
			lvChiTietDonhang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		private void ClearForm()
		{
			txtHoTenKH.Text = "";
			mtbSDT.Text = "";
			txtDiaChi.Text = "";
			lvChiTietDonhang.Items.Clear();
			
			txtTongTienHang.Text = "";
			txtPhiGiaoHang.Text = "";
			txtTongThanhToan.Text = "";
			txtGhiChu.Text = "";
			txtGiamGia.Text = "";
			txtThueVAT.Text = "";
			lbl_Tongtien.Text = "Không Đồng";
		}
		//private void btnTimKiem_Click(object sender, EventArgs e)
		//{
		//	string searchText = txtTimKiem.Text.Trim().ToLower();
		//	List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
		//	if (string.IsNullOrEmpty(searchText))
		//	{
		//		lvDS.Items.Clear();
		//		LoadSanPhamToListView();
		//		return;
		//	}
		//	foreach (ListViewItem item in lvDS.Items)
		//	{
		//		string maHang = item.SubItems[0].Text.ToLower();
		//		string tenHang = item.SubItems[1].Text.ToLower();
		//		if (maHang.Contains(searchText) || tenHang.Contains(searchText))
		//		{
		//			ketQuaTimKiem.Add(item);
		//		}
		//	}
		//	lvDS.Items.Clear();
		//	foreach (ListViewItem resultItem in ketQuaTimKiem)
		//	{
		//		lvDS.Items.Add(resultItem);
		//	}
		//	if (ketQuaTimKiem.Count == 0)
		//	{
		//		MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
		//			MessageBoxButtons.OK, MessageBoxIcon.Information);
		//	}
		//}
		//List<SanPham> GroupData(List<SanPham> data)
		//{
		//	List<SanPham> groupedData = data
		//	.GroupBy(item => item.MaSP)  // Nhóm theo thuộc tính Ma
		//	.Select(group =>
		//	{
		//		// Cập nhật SoLuong trong từng đối tượng
		//		var firstItem = group.First();
		//		firstItem.SLTon = group.Count(); // Đếm số lượng trong nhóm
		//		return firstItem;
		//	}).ToList();
		//	return groupedData;
		//}
		//void TimKiem(string keyword)
		//{
		//	string searchText = keyword.Trim().ToLower();
		//	List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
		//	if (string.IsNullOrEmpty(searchText))
		//	{
		//		lvDS.Items.Clear();
		//		LoadSanPhamToListView();
		//		return;
		//	}
		//	foreach (ListViewItem item in lvDS.Items)
		//	{
		//		string maHang = item.SubItems[0].Text.ToLower();
		//		string tenHang = item.SubItems[1].Text.ToLower();
		//		string tenMau = item.SubItems[4].Text.ToLower();
		//		if (maHang.Contains(searchText) || tenHang.Contains(searchText) || tenMau.Contains(searchText))
		//		{
		//			ketQuaTimKiem.Add(item);
		//		}
		//	}
		//	lvDS.Items.Clear();
		//	foreach (ListViewItem resultItem in ketQuaTimKiem)
		//	{
		//		lvDS.Items.Add(resultItem);
		//	}
		//	if (ketQuaTimKiem.Count == 0)
		//	{
		//		LoadSanPhamToListView();
		//	}


		//}
		void TimKiem(List<SanPham> KetQua)
		{

			List<ListViewItem> ketQuaTimKiem = new List<ListViewItem>();
			if (cbbMau.Text.ToLower() == "tất cả" && cbbSize.Text.ToLower() == "tất cả")
			{
				lvDS.Items.Clear();
				LoadlvDS(KetQua);
				return;
			}
			foreach (ListViewItem item in lvDS.Items)
			{
				string maMau = item.SubItems[4].Text.ToLower();
				string maSize = item.SubItems[5].Text.ToLower();
				if (maMau.Contains(cbbMau.Text.ToLower()) || maSize == cbbSize.Text.ToLower())
				{
					ketQuaTimKiem.Add(item);
				}
			}
			lvDS.Items.Clear();
			foreach (ListViewItem resultItem in ketQuaTimKiem)
			{
				lvDS.Items.Add(resultItem);
			}


		}
		List<SanPham> TimKiemv2()
		{
			string searchText = txtTimKiem.Text.ToLower();
			List<SanPham> ketQuaTimKiem = new List<SanPham>();
			if (string.IsNullOrEmpty(searchText))
			{
				lvDS.Items.Clear();
				LoadSanPhamToListView();
				return ketQuaTimKiem;
			}
			foreach (SanPham sp in listSanPham)
			{
				string maHang = sp.MaSP.ToLower();
				string tenHang = sp.TenSP.ToLower();

				if (maHang.Contains(searchText) || tenHang.Contains(searchText))
				{
					ketQuaTimKiem.Add(sp);

				}
			}
			lvDS.Items.Clear();
			LoadlvDS(ketQuaTimKiem);
			TimKiem(ketQuaTimKiem);
			return ketQuaTimKiem;

		}
		float TongTienHang()
		{
			float tongTienHang = listDonHang.Sum(x => x.GiaBan * x.SLTon - x.GiaBan * x.SLTon * x.GiamGia / 100);
			txtTongTienHang.Text = tongTienHang.ToString("F0");
			return tongTienHang;

		}
		void TongHoaDon()
		{
			float tongTienHang = TongTienHang();
			float phiGiaoHang = txtPhiGiaoHang.Text != "" ? float.Parse(txtPhiGiaoHang.Text) : 0;
			float thueVat = txtThueVAT.Text != "" ? float.Parse(txtThueVAT.Text) : 0;
			float giamGia = txtGiamGia.Text != "" ? float.Parse(txtGiamGia.Text) : 0;

			float tongThanhToan = tongTienHang + phiGiaoHang + tongTienHang * thueVat / 100 -
				tongTienHang * giamGia / 100;

			txtTongThanhToan.Text = tongThanhToan.ToString("F0");
			lbl_Tongtien.Text = tongThanhToan.ToString("F0");
		}
		string ktKhachHang(string hoten)
		{
			hoten.ToLower().Trim();
			KhachHangBL khachHangBL = new KhachHangBL();
			KhachHang khachHang = new KhachHang()
			{
				MaKhachHang = "",
				TenKhachHang = hoten,
				DiaChi = txtDiaChi.Text,
				SDT = mtbSDT.Text,
				Enable = 1,
			};
			List<KhachHang> listKhachHang = khachHangBL.GetAll();
			foreach (KhachHang kh in listKhachHang)
			{
				if (hoten == kh.TenKhachHang.ToLower().Trim())
				{

					return kh.MaKhachHang;
				}

			}
			return khachHangBL.Insert(khachHang);
		}
		string ThemHoaDon()
		{

			string ma = ktKhachHang(txtHoTenKH.Text);

			float phiGiaoHang = txtPhiGiaoHang.Text != "" ? float.Parse(txtPhiGiaoHang.Text) : 0;
			float thueVat = txtThueVAT.Text != "" ? float.Parse(txtThueVAT.Text) : 0;
			float giamGia = txtGiamGia.Text != "" ? float.Parse(txtGiamGia.Text) : 0;
			string trangThai = cbbTrangThai.Text;
			if (string.IsNullOrEmpty(trangThai))
			{
				MessageBox.Show("Chưa chọn trạng thái hóa đơn");
				return "";
			}
			//Debug.WriteLine(trangThai);
			HoaDonBL hoaDonBL = new HoaDonBL();
			HoaDon hd = new HoaDon()
			{
				MaHoaDon = "",
				NgayLap = DateTime.Now,
				TongTien = (int)TongTienHang(),
				MaKH = ma,
				MaNV = MaNhanVienFormShop,
				GiamGiaHD = giamGia,
				PhiShip = Convert.ToInt32(phiGiaoHang),
				Vat = thueVat,
				GhiChu = txtGhiChu.Text,
				TrangThai = trangThai,
				Enable = 1,
			};
			return hoaDonBL.Insert(hd);

		}
		void ThemChiTietHoaDon(string MaHD)
		{
			if (string.IsNullOrEmpty(MaHD))
			{ return; }
			foreach (SanPham sp in listDonHang)
			{
				ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
				{
					MaHD = MaHD,
					MaSP = sp.MaSP,
					SL = sp.SLTon,
					GiaBan = sp.SLTon * sp.GiaBan - (sp.SLTon * sp.GiaBan) * sp.GiamGia / 100,
					GhiChu = "",
					Enable = 1
				};

				ChiTietHoaDonBL chiTietHoaDonBL = new ChiTietHoaDonBL();
				string s = chiTietHoaDonBL.Insert(chiTietHoaDon);
				Debug.WriteLine(s);
			}
		}
		private void btnLuuIn_Click(object sender, EventArgs e)
		{
			if (listDonHang.Count < 1)
			{
				MessageBox.Show("Chưa có mặt hàng nào!");
				return;
			}
			string maHD = ThemHoaDon();
			ThemChiTietHoaDon(maHD);
			if (!string.IsNullOrEmpty(maHD))
			{
				MessageBox.Show("Hóa đơn đã được lưu ");
				ClearForm();
			}
			
		}
		void DeleteSanPham_TheoMa(List<SanPham> listSP, string MaSP)
		{
			for (int i = listSP.Count - 1; i >= 0; i--)
			{
				if (listSP[i].MaSP == MaSP)
				{
					listSP.RemoveAt(i);
				}
			}
		}
		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			TimKiemv2();
		}
		private void cbbMau_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimKiem(TimKiemv2());
			if (txtTimKiem.Text == "")
				TimKiem(listSanPham);
		}
		private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimKiem(TimKiemv2());
			if (txtTimKiem.Text == "")
				TimKiem(listSanPham);

		}
		private void sốLượngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string soluong = Interaction.InputBox("Nhận số", "Số Lượng", "2");
			if (int.Parse(soluong) < 1)
			{
				MessageBox.Show("không thể thêm sản phẩm có số lượng bằng 0");
				return;
			}
			if (lvDS.SelectedItems.Count > 0)
			{
				ListViewItem Item1 = lvDS.SelectedItems[0];
				string s = Item1.SubItems[0].Text;
				foreach (SanPham sp2 in listDonHang)
				{
					if (sp2.MaSP.Contains(s))
					{
						sp2.SLTon = int.Parse(soluong);


						LoadlvDonHang(listDonHang);
						TongHoaDon();

						return;
					}

				}
				foreach (SanPham sp in listSanPham)
				{
					if (sp.MaSP.Contains(s))
					{
						sp.SLTon = int.Parse(soluong);


						listDonHang.Add(sp);
						LoadlvDonHang(listDonHang);
						TongHoaDon();
						return;
					}

				}
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
				string s = Item1.SubItems[0].Text;
				foreach (SanPham sp2 in listDonHang)
				{
					if (sp2.MaSP.Contains(s))
					{
						sp2.SLTon++;

						LoadlvDonHang(listDonHang);
						TongHoaDon();

						return;
					}

				}
				foreach (SanPham sp in listSanPham)
				{
					if (sp.MaSP.Contains(s))
					{
						sp.SLTon = 1;

						listDonHang.Add(sp);
						LoadlvDonHang(listDonHang);
						TongHoaDon();

						return;
					}

				}
			}
		}
		private void btnHuyBo_Click(object sender, EventArgs e)
		{
			ClearForm();
			listDonHang.Clear();
		}
		private void txtGiamGia_TextChanged(object sender, EventArgs e)
		{

			TongHoaDon();
		}
		private void txtPhiGiaoHang_TextChanged(object sender, EventArgs e)
		{
			TongHoaDon();
		}
		private void txtThueVAT_TextChanged(object sender, EventArgs e)
		{
			TongHoaDon();
		}
		private void btnLoadDon_Click(object sender, EventArgs e)
		{
			string s=cbbMau.SelectedValue.ToString();
			MessageBox.Show(s);
			//formDangNhap formDangNhap = new formDangNhap();
			//string s= MaNhanVienFormShop;
			//Debug.WriteLine(s);
		}
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lvDS.SelectedItems.Count > 0)
			{
				ListViewItem Item1 = lvDS.SelectedItems[0];
				string s = Item1.SubItems[0].Text;
				foreach (SanPham sp2 in listDonHang)
				{
					if (sp2.MaSP.Contains(s))
					{
						DeleteSanPham_TheoMa(listDonHang, sp2.MaSP);
						LoadlvDonHang(listDonHang);
						return;
					}

				}
				
			}
		}
		private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			KhongDuocNhapChu(e);
		}
		void KhongDuocNhapChu(KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Ngăn không cho nhập ký tự
			}
		}
		private void txtPhiGiaoHang_KeyPress(object sender, KeyPressEventArgs e)
		{
			KhongDuocNhapChu(e);
		}
		private void txtThueVAT_KeyPress(object sender, KeyPressEventArgs e)
		{
			KhongDuocNhapChu(e);
		}
	}
}
