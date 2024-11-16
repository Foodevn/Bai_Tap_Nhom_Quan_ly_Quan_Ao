using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
    public class MauSacDA
    {
        public List<MauSac> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.MauSac_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<MauSac> list = new List<MauSac>();
            while (reader.Read())
            {
                MauSac color = new MauSac();
                color.MaMau = reader["MaMau"].ToString();
                color.TenMau = reader["TenMau"].ToString();
                color.Enable = Convert.ToInt32(reader["Enable"]);
                list.Add(color);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(MauSac color, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.MauSac_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@MaMau", SqlDbType.Char,10);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = color.MaMau;
            command.Parameters.Add("@TenMau", SqlDbType.NVarChar, 20).Value = color.TenMau;
            command.Parameters.Add("@Enable", SqlDbType.Int).Value = color.Enable;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@MaMau"].Value;
            return 0;
        }
    }
}

