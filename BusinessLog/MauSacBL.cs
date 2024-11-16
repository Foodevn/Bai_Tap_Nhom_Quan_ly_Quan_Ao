using DataAccess.ClassDA;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLog
{
    public class MauSacBL
    {
        MauSacDA mauSacDA = new MauSacDA();

        public List<MauSac> GetAll()
        {
            return mauSacDA.GetAll();
        }
        public int Insert(MauSac mauSac)
        {
            return mauSacDA.Insert_Update_Delete(mauSac, 0);
        }
        public int Update(MauSac mauSac)
        {
            return mauSacDA.Insert_Update_Delete(mauSac, 1);
        }
        public int Delete(MauSac mauSac)
        {
            return mauSacDA.Insert_Update_Delete(mauSac, 2);
        }
    }
}
