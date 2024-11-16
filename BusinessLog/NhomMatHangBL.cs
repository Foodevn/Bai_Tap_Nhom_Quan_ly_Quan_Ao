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
    public class NhomMatHangBL
    {
     
            NhomMatHangDA NhomMatHangDA = new NhomMatHangDA();
            public List<NhomMatHang> GetAll()
            {
                return NhomMatHangDA.GetAll();
            }
            public int Insert(NhomMatHang nhomMatHang)
            {
                return NhomMatHangDA.Insert_Update_Delete(nhomMatHang, 0);
            }
            public int Update(NhomMatHang nhomMatHang)
            {
                return NhomMatHangDA.Insert_Update_Delete(nhomMatHang, 1);
            }
            public int Delete(NhomMatHang nhomMatHang)
            {
                return NhomMatHangDA.Insert_Update_Delete(nhomMatHang, 2);
            }
        
        
    }
}
