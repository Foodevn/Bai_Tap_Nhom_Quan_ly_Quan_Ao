using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Class;

namespace BusinessLog
{
	public class RoleNhanVienBL
	{
		RoleNhanVienDA RoleNhanVienDA = new RoleNhanVienDA();
		public List<RoleNhanVien> GetAll()
		{
			return RoleNhanVienDA.GetAll();
		}
		public string Insert(RoleNhanVien sanPham)
		{
			return RoleNhanVienDA.Insert_Update_Delete(sanPham, 0);
		}
		public string Update(RoleNhanVien sanPham)
		{
			return RoleNhanVienDA.Insert_Update_Delete(sanPham, 1);
		}
		public string Delete(RoleNhanVien sanPham)
		{
			return RoleNhanVienDA.Insert_Update_Delete(sanPham, 2);
		}

	}
}
