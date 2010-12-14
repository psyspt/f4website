using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using BUS;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class LoaiCongViecDAO
    {
        #region Inserting
        public int Insert(LoaiCongViecDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertLOAICONGVIEC", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter TenLoaiCongViec_param = cmd.Parameters.Add("@TenLoaiCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter mota_param = cmd.Parameters.Add("@MoTa", System.Data.SqlDbType.NVarChar);
                    SqlParameter trongso_param = cmd.Parameters.Add("@TrongSo", System.Data.SqlDbType.Int);

                    TenLoaiCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    mota_param.Direction = System.Data.ParameterDirection.Input;
                    trongso_param.Direction = System.Data.ParameterDirection.Input;

                    TenLoaiCongViec_param.Value = newrecord.TenCongViec;
                    mota_param.Value = newrecord.MoTa;
                    trongso_param.Value = newrecord.TrongSo;


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

        #region GetIDLoaiCV
        public int GetIDLoaiCV(LoaiCongViecDTO record)
        {
            DataTable dt = new DataTable();
            int result = 0;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetIDLOAICV", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter TenLoaiCongViec_param = cmd.Parameters.Add("@TenLoaiCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter MoTa_param = cmd.Parameters.Add("@MoTa", System.Data.SqlDbType.NVarChar);


                    TenLoaiCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    MoTa_param.Direction = System.Data.ParameterDirection.Input;


                    TenLoaiCongViec_param.Value = record.TenCongViec;
                    MoTa_param.Value = record.MoTa;
                    


                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
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
            foreach (DataRow dr in dt.Rows)
            {
                return Int32.Parse(dr["ID"].ToString());
            }
            return result;
        }
        #endregion
    }
}
