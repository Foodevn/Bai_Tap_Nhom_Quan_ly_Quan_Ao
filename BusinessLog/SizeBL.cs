using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
    public class SizeBL
    {
        SizeDA SizeDA = new SizeDA();
        public List<Size> GetAll()
        {
            return SizeDA.GetAll();
        }
        public int Insert(Size size)
        {
            return SizeDA.Insert_Update_Delete(size, 0);
        }
        public int Update(Size size)
        {
            return SizeDA.Insert_Update_Delete(size, 1);
        }
        public int Delete(Size size)
        {
            return SizeDA.Insert_Update_Delete(size, 2);
        }
    }
}
