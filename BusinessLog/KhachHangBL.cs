using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ClassDA;
using DataAccess;
namespace BusinessLog
{
	public class KhachHangBL
	{
		KhachHangDA khachHangDA = new KhachHangDA();
	  
		public List<KhachHang> GetAll()
		{
			return khachHangDA.GetAll();
		}
		public string Insert(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 0);
		}
		public string Update(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 1);
		}
		public string Delete(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 2);
		}
	}
}
