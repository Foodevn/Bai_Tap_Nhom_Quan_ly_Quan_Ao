using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClassDA
{
	public class ChiTietHoaDonDA
	{
		public List<ChiTietHoaDon> GetAll()
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.ChiTietHoaDon_GetAll;


			SqlDataReader reader = command.ExecuteReader();
			List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
			while (reader.Read())
			{
				ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
				chiTietHoaDon.MaHD = reader["MaHD"].ToString();
				chiTietHoaDon.MaSP = reader["MaSP"].ToString();
				chiTietHoaDon.SL = Convert.ToInt32(reader["SL"]);
				chiTietHoaDon.GiaBan = Convert.ToSingle(reader["GiaBan"]);
				chiTietHoaDon.GhiChu = reader["SDT"].ToString();
				chiTietHoaDon.Enable = Convert.ToInt32(reader["Enable"]);
				list.Add(chiTietHoaDon);

			}
			sqlConn.Close();
			return list;
		}
		public string Insert_Update_Delete(ChiTietHoaDon chiTietHoaDon, int action)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.ChiTietHoaDon_InsertUpdateDelete;


			SqlParameter IDPara = new SqlParameter("@MaHD", SqlDbType.Char, 10);
			IDPara.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(IDPara).Value = chiTietHoaDon.MaHD;
			command.Parameters.Add("@MaSP", SqlDbType.Char, 20).Value = chiTietHoaDon.MaSP;
			command.Parameters.Add("@SL", SqlDbType.Int).Value = chiTietHoaDon.SL;
			command.Parameters.Add("@GiaBan", SqlDbType.Float).Value = chiTietHoaDon.GiaBan;
			command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 10).Value = chiTietHoaDon.GhiChu;
			command.Parameters.Add("@Enable", SqlDbType.Int).Value = chiTietHoaDon.Enable;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0)
				return (string)command.Parameters["@MaHD"].Value;
			return "";
		}
	}
}
