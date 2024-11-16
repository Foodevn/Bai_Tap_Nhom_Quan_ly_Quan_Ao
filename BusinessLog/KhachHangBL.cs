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
		public int Insert(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 0);
		}
		public int Update(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 1);
		}
		public int Delete(KhachHang khachHang)
		{
			return khachHangDA.Insert_Update_Delete(khachHang, 2);
		}
	}
}
