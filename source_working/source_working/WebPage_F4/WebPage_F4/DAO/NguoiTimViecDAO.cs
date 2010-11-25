using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NguoiTimViecDAO
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
        
        public bool Insert(NguoiTimViecDTO newrecord)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertNGUOITIMVIEC", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter hoten_param = cmd.Parameters.Add("@HoTen", System.Data.SqlDbType.NVarChar);
                SqlParameter user_param = cmd.Parameters.Add("@Username", System.Data.SqlDbType.NChar);
                SqlParameter password_parm = cmd.Parameters.Add("@Password", System.Data.SqlDbType.NChar);
                SqlParameter email_param = cmd.Parameters.Add("@Email", System.Data.SqlDbType.NChar);
                SqlParameter diachi_param = cmd.Parameters.Add("@DiaChi", System.Data.SqlDbType.NVarChar);
                SqlParameter ngaysinh_param = cmd.Parameters.Add("@NgaySinh", System.Data.SqlDbType.DateTime);
                SqlParameter gioitinh_param = cmd.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Int);
                SqlParameter dienthoai_param = cmd.Parameters.Add("@DienThoai", System.Data.SqlDbType.NChar);
                SqlParameter tinhthanh_param = cmd.Parameters.Add("@TinhThanh", System.Data.SqlDbType.Int);
                SqlParameter ngonngu_param = cmd.Parameters.Add("@NgonNgu", System.Data.SqlDbType.Int);
                SqlParameter hinhanh_param = cmd.Parameters.Add("@URLHinhAnh", System.Data.SqlDbType.NChar);
                SqlParameter trangthai_param = cmd.Parameters.Add("@TrangThai", System.Data.SqlDbType.Int);
                SqlParameter id_param = cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int);
                user_param.Direction = System.Data.ParameterDirection.Input;
                hoten_param.Direction = System.Data.ParameterDirection.Input;
                password_parm.Direction = System.Data.ParameterDirection.Input;
                email_param.Direction = System.Data.ParameterDirection.Input;
                diachi_param.Direction = System.Data.ParameterDirection.Input;
                ngaysinh_param.Direction = System.Data.ParameterDirection.Input;
                gioitinh_param.Direction = System.Data.ParameterDirection.Input;
                dienthoai_param.Direction = System.Data.ParameterDirection.Input;
                tinhthanh_param.Direction = System.Data.ParameterDirection.Input;
                ngonngu_param.Direction = System.Data.ParameterDirection.Input;
                //hinhanh_param.Direction = System.Data.ParameterDirection.Input;
                hinhanh_param.Direction = System.Data.ParameterDirection.Input;
                trangthai_param.Direction = System.Data.ParameterDirection.Input;
                id_param.Direction = System.Data.ParameterDirection.Output;
                user_param.Value = newrecord.UserName;
                hoten_param.Value = newrecord.HoTen;
                password_parm.Value = newrecord.PassWord;
                email_param.Value = newrecord.EMail;
                diachi_param.Value = newrecord.DiaChi;
                ngaysinh_param.Value = newrecord.NgaySinh;
                gioitinh_param.Value = newrecord.GioiTinh;
                dienthoai_param.Value = newrecord.DienThoai;
                tinhthanh_param.Value = newrecord.TinhThanh;
                ngonngu_param.Value = newrecord.NgonNgu;
                hinhanh_param.Value = newrecord.URLHinhAnh;
                trangthai_param.Value = newrecord.TrangThai;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            //return true;
        }
    }
}
