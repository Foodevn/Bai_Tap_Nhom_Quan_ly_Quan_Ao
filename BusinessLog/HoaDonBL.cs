using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
    public class HoaDonBL
    {
        HoaDonDA HoaDonDA = new HoaDonDA();
        public List<HoaDon> GetAll()
        {
            return HoaDonDA.GetAll();
        }
        public string Insert(HoaDon hoaDon)
        {
            return HoaDonDA.Insert_Update_Delete(hoaDon, 0);
        }
        public string Update(HoaDon hoaDon)
        {
            return HoaDonDA.Insert_Update_Delete(hoaDon, 1);
        }
        public string Delete(HoaDon hoaDon)
        {
            return HoaDonDA.Insert_Update_Delete(hoaDon, 2);
        }
    }
}
