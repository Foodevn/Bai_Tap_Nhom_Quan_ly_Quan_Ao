using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Shop_Quan_ao_1
{
	public partial class test : Form
	{
		public test()
		{
			InitializeComponent();
			s();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// Tạo một DataGridViewButtonColumn mới
			
			DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
			btnDelete.HeaderText = "Xóa";
			btnDelete.Text = "Xóa";
			btnDelete.UseColumnTextForButtonValue = true; // Hiển thị văn bản trong cột là "Xóa"

			// Thêm cột nút "Xóa" vào DataGridView
			dataGridView1.Columns.Add(btnDelete);
		}

		// Xử lý sự kiện nhấn vào nút "Xóa"
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem người dùng có nhấn vào cột nút "Xóa" không
			if (e.ColumnIndex == dataGridView1.Columns["Xóa"].Index && e.RowIndex >= 0)
			{
				// Hiển thị thông báo xác nhận
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					// Xóa hàng
					dataGridView1.Rows.RemoveAt(e.RowIndex);
				}
			}
		}
		public void s()
		{
			//tạo thêm cột
			listView1.Columns.Add("Mã hàng", 100);
			listView1.Columns.Add("Tên hàng", 150);
			listView1.Columns.Add("Giá", 70);

			//tạo nhóm
			ListViewGroup group1 = new ListViewGroup("Nhóm 1", HorizontalAlignment.Left);
			ListViewGroup group2 = new ListViewGroup("Nhóm 2", HorizontalAlignment.Left);
			ListViewGroup group3 = new ListViewGroup("Nhóm 3", HorizontalAlignment.Left);
			//thêm nhóm vào list view
			listView1.Groups.Add(group1);
			listView1.Groups.Add(group2);
			listView1.Groups.Add(group3);
			Button btnDelete = new Button();

			ListViewItem item1 = new ListViewItem("MH001", "Quần áo");
			item1.SubItems.Add("Quần áo");
			item1.SubItems.Add("150.000");
		
			item1.Group = group1; // Đặt vào nhóm 1

			ListViewItem item2 = new ListViewItem("MH002");
			item2.SubItems.Add("Giày dép");
			item2.SubItems.Add("300.000");
			item2.Group = group2; // Đặt vào nhóm 2

			// Thêm các mục vào ListView
			listView1.Items.Add(item1);
			listView1.Items.Add(item2);
			List<string[]> danhSachSanPham = new List<string[]>
			{
				new string[] { "MH003", "quần tây 3", "150.000","1%", "10" },
				new string[] { "Mt004", "áo thun 4", "250.000", "0%", "2" },
				new string[] { "MH005", "áo dj 6", "250.000", "1%", "21" },
				new string[] { "Mk006", "quần què 5", "250.000","12%", "22" },
				new string[] { "Mk007", "áo caro 7", "250.000","4%", "27" }

			};

			foreach (string[] sanPham in danhSachSanPham)
			{
				ListViewItem item = new ListViewItem(sanPham);
				listView1.Items.Add(item);
			}
		}
	}
}
