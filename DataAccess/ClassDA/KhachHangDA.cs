using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
	public class KhachHangDA
	{
		public List<KhachHang> GetAll()
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.KhachHang_GetAll;


			SqlDataReader reader = command.ExecuteReader();
			List<KhachHang> list = new List<KhachHang>();
			while (reader.Read())
			{
				KhachHang khachHang = new KhachHang();
				khachHang.MaKhachHang = reader["MaKhachHang"].ToString();
				khachHang.TenKhachHang = reader["TenKhachHang"].ToString();
				khachHang.DiaChi = reader["DiaChi"].ToString();
				khachHang.SDT = reader["SDT"].ToString();
				khachHang.Enable = Convert.ToInt32(reader["Enable"]);
				list.Add(khachHang);

			}
			sqlConn.Close();
			return list;
		}
		public string Insert_Update_Delete(KhachHang khachHang, int action)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.KhachHang_InsertUpdateDelete;


			SqlParameter IDPara = new SqlParameter("@maKhachHang", SqlDbType.Char, 10);

			IDPara.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(IDPara).Value = khachHang.MaKhachHang;
			command.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar, 35).Value = khachHang.TenKhachHang;
			command.Parameters.Add("@diaChi", SqlDbType.NVarChar,100).Value = khachHang.DiaChi;
			command.Parameters.Add("@sdt", SqlDbType.Char, 12).Value = khachHang.SDT;
			command.Parameters.Add("@enable", SqlDbType.Int).Value = khachHang.Enable;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0)
				return (string)command.Parameters["@maKhachHang"].Value;
			return "";
		}
	}
}

