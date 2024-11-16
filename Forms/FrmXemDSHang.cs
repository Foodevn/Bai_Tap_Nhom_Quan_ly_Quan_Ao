using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLog;
using DataAccess;
using DataAccess.Class;

namespace XemLaiHoaDon
{
    public partial class FrmXemDSHang : Form
    {
        public FrmXemDSHang()
        {
            InitializeComponent();
        }
        List<NhomMatHang> listNhomMatHang = new List<NhomMatHang>();
        List<SanPham> listSanPham = new List<SanPham>();
        private void FrmXemDSHang_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào ComboBox
            LoadNhomMatHang();
            // Đổ dữ liệu vào ListView
            LoadSanPhamDataToListView();
        }
        private void LoadNhomMatHang()
        {
            NhomMatHangBL nhomMatHangBL = new NhomMatHangBL();
            listNhomMatHang = nhomMatHangBL.GetAll();
            cbbNhomMatHang.DataSource = listNhomMatHang;
            cbbNhomMatHang.ValueMember = "MaNhomMatHang";
            cbbNhomMatHang.DisplayMember = "TenNhomMatHang";
        }

        public void LoadSanPhamDataToListView()
        {
            SanPhamBL sanPhamBL = new SanPhamBL();
            listSanPham = sanPhamBL.GetAll();

            lvDS.Items.Clear();
            foreach (var sanPham in listSanPham)
            {
                ListViewItem item = lvDS.Items.Add(sanPham.MaSP);
                item.SubItems.Add(sanPham.IDNhomMatHang);
                item.SubItems.Add(sanPham.TenSP);
                item.SubItems.Add(sanPham.GiaBan.ToString());
                item.SubItems.Add(sanPham.SLTon.ToString());
                item.SubItems.Add(sanPham.NhaCungCap);
                item.SubItems.Add(sanPham.IDMau);
                item.SubItems.Add(sanPham.IDSize);
           
                item.SubItems.Add(sanPham.GhiChu);
                item.SubItems.Add(sanPham.Enable.ToString());

                // Theo dữ liệu của bảng Category ID, lấy Name để hiển thị
                string Name = listNhomMatHang
                .Find(x => x.MaNhomMatHang == sanPham.IDNhomMatHang).TenNhomMatHang;
                item.SubItems.Add(Name);
                // Đưa dữ liệu Notes vào cột cuối
            }
        }


    }
}
