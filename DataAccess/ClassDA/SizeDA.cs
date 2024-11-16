using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
    public class SizeDA
    {
        public List<Size> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Size_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Size> list = new List<Size>();
            while (reader.Read())
            {
                Size size = new Size();
                size.MaSize = reader["MaSize"].ToString();
                size.TenSize = reader["TenSize"].ToString();
                size.Enable = Convert.ToInt32(reader["Enable"]);
                list.Add(size);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(Size size, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Size_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@MaSize", SqlDbType.Char,10);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = size.MaSize;
            command.Parameters.Add("@TenSize", SqlDbType.NVarChar, 20).Value = size.TenSize;
            command.Parameters.Add("@Enable", SqlDbType.Int).Value = size.Enable;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@MaSize"].Value;
            return 0;
        }
    }
}
