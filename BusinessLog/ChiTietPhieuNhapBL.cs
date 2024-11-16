using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
    public class ChiTietPhieuNhapBL
    {
        ChiTietPhieuNhapDA ChiTietPhieuNhapDA = new ChiTietPhieuNhapDA();
        public List<ChiTietPhieuNhap> GetAll()
        {
            return ChiTietPhieuNhapDA.GetAll();
        }
        public int Insert(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return ChiTietPhieuNhapDA.Insert_Update_Delete(chiTietPhieuNhap, 0);
        }
        public int Update(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return ChiTietPhieuNhapDA.Insert_Update_Delete(chiTietPhieuNhap, 1);
        }
        public int Delete(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return ChiTietPhieuNhapDA.Insert_Update_Delete(chiTietPhieuNhap, 2);
        }
    }
}
