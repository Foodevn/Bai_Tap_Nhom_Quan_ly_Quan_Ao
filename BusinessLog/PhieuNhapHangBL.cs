using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
	public class PhieuNhapHangBL
	{
		PhieuNhapHangDA PhieuNhapHangDA = new PhieuNhapHangDA();
		public List<PhieuNhapHang> GetAll()
		{
			return PhieuNhapHangDA.GetAll();
		}
		public int Insert(PhieuNhapHang PhieuNhapHang)
		{
			return PhieuNhapHangDA.Insert_Update_Delete(PhieuNhapHang, 0);
		}
		public int Update(PhieuNhapHang PhieuNhapHang)
		{
			return PhieuNhapHangDA.Insert_Update_Delete(PhieuNhapHang, 1);
		}
		public int Delete(PhieuNhapHang PhieuNhapHang)
		{
			return PhieuNhapHangDA.Insert_Update_Delete(PhieuNhapHang, 2);
		}
	}
}
