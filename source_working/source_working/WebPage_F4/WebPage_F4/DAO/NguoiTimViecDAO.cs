using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NguoiTimViecDAO
    {
#region Inserting
        public int Insert(NguoiTimViecDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertNGUOITIMVIEC", connect);
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

                    result = cmd.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();                
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
#endregion

#region Receive
        public NguoiTimViecDTO SelectByUsername(string username)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();

            StringBuilder command = new StringBuilder();
            command.Append("select * from NGUOITIMVIEC where Username='");
            command.Append(username);
            command.Append("'");
            SqlCommand cmd = new SqlCommand(command.ToString(), connect);
            SqlDataReader r = cmd.ExecuteReader();
            NguoiTimViecDTO returnrecord = new NguoiTimViecDTO();
            r.Read();
            object[] obj = new object[13];
            r.GetValues(obj);

            returnrecord.HoTen = obj[1].ToString();
            returnrecord.UserName = obj[2].ToString().TrimEnd(' ');
            returnrecord.PassWord = obj[3].ToString().TrimEnd(' ');
            returnrecord.EMail = obj[4].ToString();
            returnrecord.DiaChi = obj[5].ToString();
            returnrecord.NgaySinh = DateTime.Parse(obj[6].ToString());
            returnrecord.GioiTinh = int.Parse(obj[7].ToString());
            returnrecord.DienThoai = obj[8].ToString();
            returnrecord.TinhThanh = int.Parse(obj[9].ToString());
            returnrecord.NgonNgu = int.Parse(obj[10].ToString());
            returnrecord.URLHinhAnh = obj[11].ToString();
            returnrecord.TrangThai = int.Parse(obj[12].ToString());
            connect.Close();
            return returnrecord;
        }
#endregion        
    }
}
