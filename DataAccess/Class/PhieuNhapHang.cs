using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class PhieuNhapHang
	{
		public string MaPhieuNhap { get; set; }
		public DateTime NgayNhap { get; set; }
		public string MaNhanVien { get; set; }
		public string NguonHang { get; set; }
		public float TongTienHang { get; set; }
		public float CacPhiKhac { get; set; }
		public float PhiVanChuyen { get; set; }
		public float ThueVat { get; set; }
		public string GhiChu { get; set; }
		public int Enable { get; set; }
	}

}
