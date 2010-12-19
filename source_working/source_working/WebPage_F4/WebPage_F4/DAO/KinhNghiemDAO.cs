using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class KinhNghiemDAO
    {
        public List<KinhNghiemDTO> GetAllRecord()
        {

            List<KinhNghiemDTO> listrecord = new List<KinhNghiemDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[4];
                    SqlCommand cmd = new SqlCommand("sp_SelectKINHNGHIEMsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        KinhNghiemDTO km = new KinhNghiemDTO();
                        km.ID = (int)allrecord.GetValue(0);
                        km.ThoiGian_Bot = (int)allrecord.GetValue(1);
                        km.ThoiGian_Top = (int)allrecord.GetValue(2);
                        km.TrongSo = (int)allrecord.GetValue(3);
                        listrecord.Add(km);
                    }
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
            return listrecord;
        }
    }
}
