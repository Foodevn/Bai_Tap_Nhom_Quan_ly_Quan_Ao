using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
	public class ChiTietHoaDonBL
	{
		ChiTietHoaDonDA ChiTietHoaDonDA = new ChiTietHoaDonDA();
		public List<ChiTietHoaDon> GetAll()
		{
			return ChiTietHoaDonDA.GetAll();
		}
		public string Insert(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 0);
		}
		public string Update(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 1);
		}
		public string Delete(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 2);
		}
	}
}
