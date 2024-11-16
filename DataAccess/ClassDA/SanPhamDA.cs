using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
    public class SanPhamDA
    {
        public List<SanPham> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.SanPham_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<SanPham> list = new List<SanPham>();
            while (reader.Read())
            {
                SanPham sanPham = new SanPham();
                sanPham.MaSP = reader["MaSP"].ToString();
                sanPham.TenSP = reader["TenSP"].ToString();
                sanPham.GiaBan = Convert.ToInt32(reader["GiaBan"]);
                sanPham.SLTon = Convert.ToInt32(reader["SLTon"]);
                sanPham.NhaCungCap = reader["NhaCungCap"].ToString();
                sanPham.IDMau = reader["IDMau"].ToString();
                sanPham.IDSize = reader["IDSize"].ToString();
                sanPham.IDNhomMatHang = reader["IDNhomMatHang"].ToString();
                sanPham.GhiChu = reader["GhiChu"].ToString();
                sanPham.Enable = Convert.ToInt32(reader["Enable"]);
                list.Add(sanPham);
            }
            sqlConn.Close();
            return list;
        }
        public int Insert_Update_Delete(SanPham sanPham, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.SanPham_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@MaSP", SqlDbType.Char,20);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = sanPham.MaSP;
            command.Parameters.Add("@TenSP", SqlDbType.NVarChar, 35) .Value = sanPham.TenSP;
            command.Parameters.Add("@GiaBan", SqlDbType.Int) .Value = sanPham.GiaBan;
            command.Parameters.Add("@SLTon", SqlDbType.Int).Value = sanPham.SLTon;
            command.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar, 35).Value = sanPham.NhaCungCap;
            command.Parameters.Add("@IDMau", SqlDbType.NVarChar, 10).Value = sanPham.IDMau;
            command.Parameters.Add("@IDSize", SqlDbType.NVarChar, 10).Value = sanPham.IDSize;
            command.Parameters.Add("@NhomMatHang", SqlDbType.NVarChar, 3).Value = sanPham.IDNhomMatHang;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = sanPham.GhiChu;
            command.Parameters.Add("@Enable", SqlDbType.Int).Value = sanPham.Enable;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@MaSP"].Value;
            return 0;
        }
    }
}
