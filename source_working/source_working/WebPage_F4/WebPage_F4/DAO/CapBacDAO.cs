using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class CapBacDAO
    {
        public List<CapBacDTO> GetAllRecord()
        {
            List<CapBacDTO> listrecord = new List<CapBacDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[4];
                    SqlCommand cmd = new SqlCommand("sp_SelectCAPBACsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        CapBacDTO km = new CapBacDTO();
                        km.ID = (int)allrecord.GetValue(0);
                        km.TenCapBac = (string)allrecord.GetValue(1);
                        km.TrongSo= (int)allrecord.GetValue(2);
                        km.MoTa = (string)allrecord.GetValue(3);
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
