using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
	public class Ultilities
	{
		// lấy chuỗi kết nối từ tập tin App.Config  
		private static string StrName = "ConnectionStringName";
		public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

		// Các biến của bảng Food  
		public static string MauSac_GetAll = "MauSac_GetAll";
		public static string MauSac_InsertUpdateDelete = "MauSac_InsertUpdateDelete";

		// Các biến của bảng Food  
		public static string Size_GetAll = "Size_GetAll";
		public static string Size_InsertUpdateDelete = "Size_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string SanPham_GetAll = "SanPham_GetAll";
		public static string SanPham_InsertUpdateDelete = "SanPham_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string KhachHang_GetAll = "KhachHang__GetAll";
		public static string KhachHang_InsertUpdateDelete = "KhachHang_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string ChiTietHoaDon_GetAll = "ChiTietHoaDon_GetAll";
		public static string ChiTietHoaDon_InsertUpdateDelete = "ChiTietHoaDon_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string HoaDon_GetAll = "HoaDon_GetAll";
		public static string HoaDon_InsertUpdateDelete = "HoaDon_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string ChiTietPhieuNhap_GetAll = "ChiTietPhieuNhap_GetAll";
		public static string ChiTietPhieuNhap_InsertUpdateDelete = "ChiTietPhieuNhap_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string NhanVien_GetAll = "NhanVien_GetAll";
		public static string NhanVien_InsertUpdateDelete = "NhanVien_InsertUpdateDelete";
		// Các biến của bảng Food  
		public static string PhieuNhapHang_GetAll = "PhieuNhapHang_GetAll";
		public static string PhieuNhapHang_InsertUpdateDelete = "PhieuNhapHang_InsertUpdateDelete";
       
		public static string NhomMatHang_GetAll = "NhomMatHang_GetAll";
        public static string NhomMatHang_InsertUpdateDelete = "NhomMatHang_InsertUpdateDelete";

        // Các biến của bảng Food  
        public static string RoleNhanVien_GetAll = "RoleNhanVien_GetAll";
		public static string RoleNhanVien_InsertUpdateDelete = "RoleNhanVien_InsertUpdateDelete";

		// Các biến của bảng Food  
		public static string _GetAll = "_GetAll";
		public static string _InsertUpdateDelete = "_InsertUpdateDelete";



	}
}
