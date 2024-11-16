using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
	public class NhanVienDA
	{
		public List<NhanVien> GetAll()
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.NhanVien_GetAll;


			SqlDataReader reader = command.ExecuteReader();
			List<NhanVien> list = new List<NhanVien>();
			while (reader.Read())
			{
				NhanVien nhanVien = new NhanVien();
				nhanVien.MaNhanVien = reader["MaNhanVien"].ToString();
				nhanVien.TenNhanVien = reader["TenNhanVien"].ToString();
				nhanVien.Role = reader["Role"].ToString();
				nhanVien.MatKhau = reader["MatKhau"].ToString();
				nhanVien.Enable = Convert.ToInt32(reader["Enable"]);
				list.Add(nhanVien);

			}
			sqlConn.Close();
			return list;
		}
		public int Insert_Update_Delete(NhanVien nhanVien, int action)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.NhanVien_InsertUpdateDelete;


			SqlParameter IDPara = new SqlParameter("@MaNhanVien", SqlDbType.Char, 10);
			IDPara.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(IDPara).Value = nhanVien.MaNhanVien;
			command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 30).Value = nhanVien.TenNhanVien;
			command.Parameters.Add("@Role", SqlDbType.Char,20).Value = nhanVien.Role;
			command.Parameters.Add("@MatKhau", SqlDbType.Char,30).Value = nhanVien.MatKhau;
			command.Parameters.Add("@Enable", SqlDbType.Int).Value = nhanVien.Enable;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0)
				return (int)command.Parameters["@MaNhanVien"].Value;
			return 0;
		}
	}
}
