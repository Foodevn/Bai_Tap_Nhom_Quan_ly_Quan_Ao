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
		public int Insert(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 0);
		}
		public int Update(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 1);
		}
		public int Delete(ChiTietHoaDon chiTietHoaDon)
		{
			return ChiTietHoaDonDA.Insert_Update_Delete(chiTietHoaDon, 2);
		}
	}
}
