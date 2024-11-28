using BusinessLog;
using Chitietphieunhau;
using DataAccess.Class;
using quan_ly_shop_quan_ao;
using quanlyshopquanao;
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
using XemLaiHoaDon;

namespace Quan_ly_Shop_Quan_ao_1
{
	public partial class menu : Form
	{
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;

		public string MaNhanVienFormMenu {  get; set; }
		public menu()
		{
			InitializeComponent();
			random = new Random();
			btnCloseChildForm.Visible = false;
		}

		//Constructor

		//[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		//private extern static void ReleaseCapture();
		//[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		//private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		//Methods
		#region Function
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			ActivateButton(btnSender);

			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktop.Controls.Add(childForm);
			this.panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitle.Text = childForm.Text;
		}
		private void LoadChildForm(Form childForm)
		{
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktop.Controls.Add(childForm);
			this.panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void Reset()
		{
			DisableButton();
			lblTitle.Text = "HOME";
			panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			btnCloseChildForm.Visible = false;
		}
		private void KiemTraRole()
		{
			RoleNhanVienBL roleNhanVienBL = new RoleNhanVienBL();
			List<RoleNhanVien> listRoleNhanVien = roleNhanVienBL.GetAll();
			foreach (RoleNhanVien roleNhanVien in listRoleNhanVien)
			{
				if (roleNhanVien.MaNhanVien == MaNhanVienFormMenu)
				{
					if (roleNhanVien.MaRole.Trim() == "003")
					{
						btnDSSanPham.Visible = false;
						btnKhachHang.Visible = false;
						btnDoanhThu.Visible = false;
						btnNhapHang.Visible = false;
					}

				}
			}
			


		}
		#endregion
		#region
		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}
		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					panelTitleBar.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					btnCloseChildForm.Visible = true;
				}
			}
		}
		private void DisableButton()
		{
			foreach (Control previousBtn in panelMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}
		#endregion
		#region Event
		private void btnNguoidung_Click(object sender, EventArgs e)
		{
			formShop formShop = new formShop();
			formShop.MaNhanVienFormShop = MaNhanVienFormMenu;
			OpenChildForm(formShop, sender);
		}
		private void btnBaoCao_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmXemLaiHoaDon(), sender);
		}
		private void btnQuanLy_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmXemDSHang(), sender);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormBaoCaoDanhThu(), sender);
		}
		private void btnCloseChildForm_Click(object sender, EventArgs e)
		{

			//if (activeForm != null)
			//	activeForm.Close();
			//Reset();
			//panelDesktop.Controls.Clear()  ;
			Debug.WriteLine(MaNhanVienFormMenu);

			
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
			Form form = new formDangNhap();
			form.Show();
			
		}
		private void button1_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormQuanLyTaiKhoanNguoiDung(), sender);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormBaoCaoDanhThu(), sender);
		}
		private void menu_Load(object sender, EventArgs e)
		{
			
			//MessageBox.Show(MaNhanVienFormMenu);
			btnDonHang.PerformClick();
			KiemTraRole();

		}
		private void button3_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Lapphieunhaphangmoi(), sender);
		}
		#endregion

	}
}
