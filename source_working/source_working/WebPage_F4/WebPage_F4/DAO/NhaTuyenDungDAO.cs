using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhaTuyenDungDAO
    {
        private string connectionString = "Data Source=LTBCOMPUTER;Initial Catalog=CSDLWeb;Integrated Security=True";
        public static SqlConnection conn; 
        public bool ConnectToSQLServer()
        {
            conn = new SqlConnection(connectionString);
            if (conn != null)
            {
                conn.Open();
                return true;
            }
            return false;
        }

        public bool Insert(NhaTuyenDungDTO newrecord)
        {
            try
            {
                /*
                @TenCongTy nvarchar(100),
	            @Email varchar(50),
	            @Password varchar(50),
	            @DiaChi nvarchar(100),
	            @DienThoai nchar(20),
	            @LinhVuc int,
	            @TenNguoiDaiDien nvarchar(50),
	            @MoTa text,
	            @MaTKNganHang nchar(10),
	            @TrangThai int,
	            @ID int OUTPUT
                */
                SqlCommand cmd = new SqlCommand("sp_InsertNHATUYENDUNG", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter tencongty_param = cmd.Parameters.Add("@TenCongTy", System.Data.SqlDbType.NVarChar);
                tencongty_param.Direction = System.Data.ParameterDirection.Input;
                tencongty_param.Value = newrecord.TenCongTy;
                SqlParameter email_param = cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);
                email_param.Direction = System.Data.ParameterDirection.Input;
                email_param.Value = newrecord.Email;
                SqlParameter pass_param = cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                pass_param.Direction = System.Data.ParameterDirection.Input;
                pass_param.Value = newrecord.Password;
                SqlParameter diachi_param = cmd.Parameters.Add("@DiaChi", System.Data.SqlDbType.NVarChar);
                diachi_param.Direction = System.Data.ParameterDirection.Input;
                diachi_param.Value = newrecord.DiaChi;
                SqlParameter dienthoai_param = cmd.Parameters.Add("@DienThoai", System.Data.SqlDbType.NChar);
                dienthoai_param.Direction = System.Data.ParameterDirection.Input;
                dienthoai_param.Value = newrecord.DienThoai;
                SqlParameter linhvuc_param = cmd.Parameters.Add("@LinhVuc", System.Data.SqlDbType.Int);
                linhvuc_param.Direction = System.Data.ParameterDirection.Input;
                linhvuc_param.Value = newrecord.LinhVuc;
                SqlParameter tennguoidaidien_param = cmd.Parameters.Add("@TenNguoiDaiDien", System.Data.SqlDbType.NVarChar);
                tennguoidaidien_param.Direction = System.Data.ParameterDirection.Input;
                tennguoidaidien_param.Value = newrecord.TenNguoiDaiDien;
                SqlParameter mota_param = cmd.Parameters.Add("@MoTa", System.Data.SqlDbType.Text);
                mota_param.Direction = System.Data.ParameterDirection.Input;
                mota_param.Value = newrecord.MoTa;
                SqlParameter maTKNH_param = cmd.Parameters.Add("@MaTKNganHang", System.Data.SqlDbType.NChar);
                maTKNH_param.Direction = System.Data.ParameterDirection.Input;
                maTKNH_param.Value = newrecord.MaTKNganHang;
                SqlParameter trangthai_param = cmd.Parameters.Add("@TrangThai", System.Data.SqlDbType.Int);
                trangthai_param.Direction = System.Data.ParameterDirection.Input;
                trangthai_param.Value = newrecord.TrangThai;
                SqlParameter id_param = cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                id_param.Direction = System.Data.ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
