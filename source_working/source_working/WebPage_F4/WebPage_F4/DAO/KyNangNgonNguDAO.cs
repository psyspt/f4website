using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class KyNangNgonNguDAO
    {
        public List<KyNangNgonNguDTO> GetAllRecord()
        {
            List<KyNangNgonNguDTO> listrecord = new List<KyNangNgonNguDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[2];
                    SqlCommand cmd = new SqlCommand("sp_SelectKYNANGNGONNGUsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        KyNangNgonNguDTO km = new KyNangNgonNguDTO();
                        km.ID = (int)allrecord.GetValue(0);  
                        km.Level = (int)allrecord.GetValue(1);      
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
