using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class LoaiUngVienDAO
    {
        #region GetIDUngVien
        public int GetIDUNgVien(LoaiUngVienDTO newrecord)
        {
            DataTable dt = new DataTable();
            int result=0;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetIDLOAIUV", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter NganhNghe_param = cmd.Parameters.Add("@NganhNghe", System.Data.SqlDbType.NVarChar);
                    SqlParameter CapBac_param = cmd.Parameters.Add("@CapBac", System.Data.SqlDbType.NVarChar);
                    SqlParameter BangCap_param = cmd.Parameters.Add("@BangCap", System.Data.SqlDbType.NVarChar);

                    NganhNghe_param.Direction = System.Data.ParameterDirection.Input;
                    CapBac_param.Direction = System.Data.ParameterDirection.Input;
                    BangCap_param.Direction = System.Data.ParameterDirection.Input;

                    NganhNghe_param.Value = newrecord.NganhNghe;
                    CapBac_param.Value = newrecord.CapBac;
                    BangCap_param.Value = newrecord.BangCap;

                    
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

        #region Insert
        public int Insert(LoaiUngVienDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_insertLOAIUNGVIEN", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter NganhNghe_param = cmd.Parameters.Add("@NganhNghe", System.Data.SqlDbType.NVarChar);
                    SqlParameter CapBac_param = cmd.Parameters.Add("@CapBac", System.Data.SqlDbType.NVarChar);
                    SqlParameter BangCap_param = cmd.Parameters.Add("@BangCap", System.Data.SqlDbType.NVarChar);

                    NganhNghe_param.Direction = System.Data.ParameterDirection.Input;
                    CapBac_param.Direction = System.Data.ParameterDirection.Input;
                    BangCap_param.Direction = System.Data.ParameterDirection.Input;

                    NganhNghe_param.Value = newrecord.NganhNghe;
                    CapBac_param.Value = newrecord.CapBac;
                    BangCap_param.Value = newrecord.BangCap;


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
        public List<LoaiUngVienDTO> GetAllRecord()
        {
            List<LoaiUngVienDTO> listrecord = new List<LoaiUngVienDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                StringBuilder command = new StringBuilder();
                command.Append("select * from LOAIUNGVIEN ");
                SqlCommand cmd = new SqlCommand(command.ToString(), connect);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    LoaiUngVienDTO record = new LoaiUngVienDTO();
                    record.BangCap = r["BangCap"].ToString();
                    record.CapBac = r["CapBac"].ToString();
                    record.NganhNghe = r["NganhNghe"].ToString();
                    listrecord.Add(record);
                }
                connect.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return listrecord;
        }
        #endregion

        #region GetBangCap
        public List<String> GetBangCap()
        {
            List<String> listBangCap = new List<String>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                StringBuilder command = new StringBuilder();
                command.Append("select DISTINCT BangCap from LOAIUNGVIEN ");
                SqlCommand cmd = new SqlCommand(command.ToString(), connect);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    listBangCap.Add(r["BangCap"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return listBangCap;
        }
        #endregion

        #region GetCapBac
        public List<String> GetCapBac()
        {
            List<String> listCapBac = new List<String>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                StringBuilder command = new StringBuilder();
                command.Append("select DISTINCT CapBac from LOAIUNGVIEN ");
                SqlCommand cmd = new SqlCommand(command.ToString(), connect);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    listCapBac.Add(r["CapBac"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return listCapBac;
        }
        #endregion

        #region GetNganhNghe
        public List<String> GetNganhNghe()
        {
            List<String> listNganhNghe = new List<String>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                StringBuilder command = new StringBuilder();
                command.Append("select DISTINCT NganhNghe from LOAIUNGVIEN ");
                SqlCommand cmd = new SqlCommand(command.ToString(), connect);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    listNganhNghe.Add(r["NganhNghe"].ToString());
                }
                connect.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return listNganhNghe;
        }
        #endregion

    }
}
