using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class TinTuyenDungDAO
    {
        #region Insert
        public int Insert(TinTuyenDungDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_insertTINTUYENDUNG", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter ViTriTuyenDung_param = cmd.Parameters.Add("@ViTriTuyenDung", System.Data.SqlDbType.NVarChar);
                    SqlParameter MoTaCongViec_param = cmd.Parameters.Add("@MoTaCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter KyNangCongViec_param = cmd.Parameters.Add("@KyNangCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter MaSoCongViec_param = cmd.Parameters.Add("@MaSoCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter LoaiUngVien_param = cmd.Parameters.Add("@LoaiUngVien", System.Data.SqlDbType.Int);
                    SqlParameter NhaTuyenDung_param = cmd.Parameters.Add("@NhaTuyenDung", System.Data.SqlDbType.Int);

                    ViTriTuyenDung_param.Direction = System.Data.ParameterDirection.Input;
                    MoTaCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    KyNangCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    MaSoCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    LoaiUngVien_param.Direction = System.Data.ParameterDirection.Input;
                    NhaTuyenDung_param.Direction = System.Data.ParameterDirection.Input;

                    ViTriTuyenDung_param.Value = newrecord.ViTriTuyenDung;
                    MoTaCongViec_param.Value = newrecord.MoTaCongViec;
                    KyNangCongViec_param.Value = newrecord.KyNangCongViec;
                    MaSoCongViec_param.Value = newrecord.MaSoCongViec;
                    LoaiUngVien_param.Value = newrecord.LoaiUngVien;
                    NhaTuyenDung_param.Value = newrecord.NhanTuyenDung;

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
    }
}
