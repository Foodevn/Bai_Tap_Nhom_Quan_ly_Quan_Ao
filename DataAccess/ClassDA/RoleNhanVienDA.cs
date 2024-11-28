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
	public class RoleNhanVienDA
	{
		
		public List<RoleNhanVien> GetAll()
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();
			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.RoleNhanVien_GetAll;

			SqlDataReader reader = command.ExecuteReader();
			List<RoleNhanVien> list = new List<RoleNhanVien>();
			while (reader.Read())
			{
				RoleNhanVien roleNhanVien = new RoleNhanVien();
				roleNhanVien.MaRole = reader["MaRole"].ToString();
				roleNhanVien.MaNhanVien = reader["MaNhanVien"].ToString();
				roleNhanVien.KhichHoat = Convert.ToInt32(reader["KhichHoat"]);
				roleNhanVien.GhiChu = reader["GhiChu"].ToString();
			
				list.Add(roleNhanVien);
			}
			sqlConn.Close();
			return list;
		}
		public string Insert_Update_Delete(RoleNhanVien roleNhanVien, int action)
		{
			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.RoleNhanVien_InsertUpdateDelete;

			SqlParameter IDPara = new SqlParameter("@MaRole", SqlDbType.Char, 20);
			IDPara.Direction = ParameterDirection.InputOutput;

			command.Parameters.Add(IDPara).Value = roleNhanVien.MaRole;
			command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar, 35).Value = roleNhanVien.MaNhanVien;
			command.Parameters.Add("@KhichHoat", SqlDbType.Int).Value = roleNhanVien.KhichHoat;
			command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = roleNhanVien.GhiChu;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0) // Nếu thành công thì trả về ID đã thêm
				return (string)command.Parameters["@MaRole"].Value;
			return "";
		}
	}
}
