using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess.ClassDA
{
	public class PhieuNhapHangDA
	{
		public List<PhieuNhapHang> GetAll()
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.PhieuNhapHang_GetAll;


			SqlDataReader reader = command.ExecuteReader();
			List<PhieuNhapHang> list = new List<PhieuNhapHang>();
			while (reader.Read())
			{
				PhieuNhapHang chiTietHoaDon = new PhieuNhapHang();
				chiTietHoaDon.MaPhieuNhap = reader["MaPhieuNhap"].ToString();
				chiTietHoaDon.NgayNhap =Convert.ToDateTime( reader["NgayNhap"]);
				chiTietHoaDon.NhaCungCap = reader["NhaCungCap"].ToString();
				chiTietHoaDon.MaNhanVien = reader["MaNhanVien"].ToString();
				chiTietHoaDon.Enable = Convert.ToInt32(reader["Enable"]);
				list.Add(chiTietHoaDon);

			}
			sqlConn.Close();
			return list;
		}
		public int Insert_Update_Delete(PhieuNhapHang phieuNhapHang, int action)
		{

			SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
			sqlConn.Open();

			SqlCommand command = sqlConn.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = Ultilities.PhieuNhapHang_InsertUpdateDelete;


			SqlParameter IDPara = new SqlParameter("@MaPhieuNhap", SqlDbType.Char, 10);
			IDPara.Direction = ParameterDirection.InputOutput;
			command.Parameters.Add(IDPara).Value = phieuNhapHang.MaPhieuNhap;
			command.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = phieuNhapHang.NgayNhap;
			command.Parameters.Add("@NhaCungCap", SqlDbType.NVarChar,35).Value = phieuNhapHang.NhaCungCap;
			command.Parameters.Add("@MaNhanVien", SqlDbType.Char,10).Value = phieuNhapHang.MaNhanVien;
			command.Parameters.Add("@Enable", SqlDbType.Int).Value = phieuNhapHang.Enable;
			command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

			int result = command.ExecuteNonQuery();
			if (result > 0)
				return (int)command.Parameters["@MaPhieuNhap"].Value;
			return 0;
		}
	}
}
