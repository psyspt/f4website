using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class NgonNguDAO
    {
        public List<NgonNguDTO> GetAllRecord()
        {
            List<NgonNguDTO> listrecord = new List<NgonNguDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[4];
                    SqlCommand cmd = new SqlCommand("sp_SelectNGONNGUsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        NgonNguDTO km = new NgonNguDTO();
                        km.ID = (int)allrecord.GetValue(0);
                        km.TenNgonNgu = (string)allrecord.GetValue(1);
                        km.TrongSo= (int)allrecord.GetValue(2);
                        km.IDKyNangNgonNgu = (int)allrecord.GetValue(3);
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
