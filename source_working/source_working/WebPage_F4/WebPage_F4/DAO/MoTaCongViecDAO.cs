using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class MoTaCongViecDAO
    {
        #region Inserting
        public int Insert(MoTaCongViecDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertMoTaCongViec", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter vitrituyendung_param = cmd.Parameters.Add("@ViTriTuyenDung", System.Data.SqlDbType.NVarChar);
                    SqlParameter mota_param = cmd.Parameters.Add("@MoTa", System.Data.SqlDbType.NVarChar);
                    SqlParameter kynang_param = cmd.Parameters.Add("@KyNang", System.Data.SqlDbType.NVarChar);

                    vitrituyendung_param.Direction = System.Data.ParameterDirection.Input;
                    kynang_param.Direction = System.Data.ParameterDirection.Input;
                    mota_param.Direction = System.Data.ParameterDirection.Input;

                    vitrituyendung_param.Value = newrecord.ViTriTuyenDung;
                    kynang_param.Value = newrecord.MoTaCongViec;
                    mota_param.Value = newrecord.KyNangCongViec;
                    

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
