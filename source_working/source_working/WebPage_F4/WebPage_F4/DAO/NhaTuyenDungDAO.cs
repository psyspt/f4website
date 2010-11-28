using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhaTuyenDungDAO
    {
#region Inserting
        public int Insert(NhaTuyenDungDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertNHATUYENDUNG", connect);
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

#region Receiving
        public NhaTuyenDungDTO SelectByEmail(string email)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();

            StringBuilder command = new StringBuilder();
            command.Append("select * from NHATUYENDUNG where Email='");
            command.Append(email);
            command.Append("'");
            SqlCommand cmd = new SqlCommand(command.ToString(), connect);
            SqlDataReader r = cmd.ExecuteReader();
            NhaTuyenDungDTO returnrecord = new NhaTuyenDungDTO();
            r.Read();
            object[] obj = new object[11];
            r.GetValues(obj);

            returnrecord.TenCongTy = obj[1].ToString();
            returnrecord.Email = obj[2].ToString().TrimEnd(' ');
            returnrecord.Password = obj[3].ToString().TrimEnd(' ');
            returnrecord.DiaChi = obj[4].ToString();
            returnrecord.DienThoai = obj[5].ToString();
            returnrecord.LinhVuc = int.Parse(obj[6].ToString());
            returnrecord.TenNguoiDaiDien = obj[7].ToString();
            returnrecord.MoTa = obj[8].ToString();
            returnrecord.MaTKNganHang = obj[9].ToString();
            returnrecord.TrangThai = int.Parse(obj[10].ToString());

            connect.Close();
            return returnrecord;
        }
#endregion
    }
}
