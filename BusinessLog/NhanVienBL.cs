using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
	public class NhanVienBL
	{
		NhanVienDA NhanVienDA = new NhanVienDA();
		public List<NhanVien> GetAll()
		{
			return NhanVienDA.GetAll();
		}
		public int Insert(NhanVien NhanVien)
		{
			return NhanVienDA.Insert_Update_Delete(NhanVien, 0);
		}
		public int Update(NhanVien NhanVien)
		{
			return NhanVienDA.Insert_Update_Delete(NhanVien, 1);
		}
		public int Delete(NhanVien NhanVien)
		{
			return NhanVienDA.Insert_Update_Delete(NhanVien, 2);
		}
	}
}
