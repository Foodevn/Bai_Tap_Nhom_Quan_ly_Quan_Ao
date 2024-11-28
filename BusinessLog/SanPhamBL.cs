using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
    public class SanPhamBL
    {
        SanPhamDA SanPhamDA = new SanPhamDA();
        public List<SanPham> GetAll()
        {
            return SanPhamDA.GetAll();
        }
        public string Insert(SanPham sanPham)
        {
            return SanPhamDA.Insert_Update_Delete(sanPham, 0);
        }
        public string Update(SanPham sanPham)
        {
            return SanPhamDA.Insert_Update_Delete(sanPham, 1);
        }
        public string Delete(SanPham sanPham)
        {
            return SanPhamDA.Insert_Update_Delete(sanPham, 2);
        }

    }
}
