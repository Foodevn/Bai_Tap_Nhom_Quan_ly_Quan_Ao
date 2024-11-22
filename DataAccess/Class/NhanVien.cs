using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class NhanVien
	{
		public string MaNhanVien { get; set; }
		public string MatKhau {  get; set; }
		public string HoTen { get; set; }
		public string Email { get; set; }
		public int SDT { get; set; }
		public DateTime NgayTao { get; set; }
		public int Enable { get; set; }
	}

}
