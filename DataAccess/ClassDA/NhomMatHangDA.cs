using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Class;

namespace DataAccess.ClassDA
{
    public class NhomMatHangDA
    {
        public List<NhomMatHang> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.NhomMatHang_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<NhomMatHang> list = new List<NhomMatHang>();
            while (reader.Read())
            {
                NhomMatHang nhomMatHang = new NhomMatHang();
                nhomMatHang.MaNhomMatHang = reader["MaNhomMatHang"].ToString();
                nhomMatHang.TenNhomMatHang = reader["TenNhomMatHang"].ToString();
                nhomMatHang.Enable = Convert.ToInt32(reader["Enable"]);
                list.Add(nhomMatHang);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(NhomMatHang nhomMatHang, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.NhomMatHang_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@MaNhomMatHang", SqlDbType.Char, 3);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = nhomMatHang.MaNhomMatHang;
            command.Parameters.Add("@TenNhomMatHang", SqlDbType.NVarChar, 50).Value = nhomMatHang.TenNhomMatHang;
            command.Parameters.Add("@Enable", SqlDbType.Int).Value = nhomMatHang.Enable;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@MaNhomMatHang"].Value;
            return 0;
        }
    }
}
