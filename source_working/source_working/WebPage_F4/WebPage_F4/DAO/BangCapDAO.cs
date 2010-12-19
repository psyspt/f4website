using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class BangCapDAO
    {
        public List<BangCapDTO> GetAllRecord()
        {
            List<BangCapDTO> listrecord = new List<BangCapDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[5];
                    SqlCommand cmd = new SqlCommand("sp_SelectBANGCAPsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        BangCapDTO km = new BangCapDTO();
                        km.ID = (int)allrecord.GetValue(0);
                        km.TenBang = (string)allrecord.GetValue(1);
                        km.NgayCap = (DateTime)allrecord.GetValue(2);
                        km.Mota = (string)allrecord.GetValue(3);
                        km.TrongSo = (int)allrecord.GetValue(4);
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
