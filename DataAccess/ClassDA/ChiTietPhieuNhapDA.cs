using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
    public class ChiTietPhieuNhapDA
    {
        public List<ChiTietPhieuNhap> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietPhieuNhap_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();
            while (reader.Read())
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MaPhieuNhap = reader["MaPhieuNhap"].ToString();
                chiTietPhieuNhap.MaSP = reader["MaSP"].ToString();
                chiTietPhieuNhap.SL = Convert.ToInt32(reader["SL"]);
                chiTietPhieuNhap.GiaNhap = Convert.ToInt32(reader["GiaNhap"]);
                chiTietPhieuNhap.GhiChu = reader["GhiChu"].ToString();
                chiTietPhieuNhap.Enable = Convert.ToInt32(reader["Enable"]);
                list.Add(chiTietPhieuNhap);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(ChiTietPhieuNhap chiTietPhieuNhap, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChiTietPhieuNhap_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@MaPhieuNhap", SqlDbType.Char, 10);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = chiTietPhieuNhap.MaPhieuNhap;
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar, 20).Value = chiTietPhieuNhap.MaSP;
            command.Parameters.Add("@SL", SqlDbType.Int).Value = chiTietPhieuNhap.SL;
            command.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = chiTietPhieuNhap.GiaNhap;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 255).Value = chiTietPhieuNhap.GhiChu;
            command.Parameters.Add("@Enable", SqlDbType.Int).Value = chiTietPhieuNhap.Enable;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@MaPhieuNhap"].Value;
            return 0;
        }
    }
}
