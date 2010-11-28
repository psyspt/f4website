using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class NganhNgheDAO
    {
#region Receiving
        public List<NganhNgheDTO> GetAllRecord()
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            try
            {
                connect.Open();

                object[] allrecord = new object[3];
                List<NganhNgheDTO> listrecord = new List<NganhNgheDTO>();
                SqlCommand cmd = new SqlCommand("sp_SelectNGANHNGHEsAll", connect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValues(allrecord);
                    NganhNgheDTO tt = new NganhNgheDTO();
                    tt.ID = (int)allrecord.GetValue(0);

                    if (allrecord.GetValue(2) == System.DBNull.Value)
                    {
                        tt.MoTa = "";
                    }
                    else
                    {
                        tt.MoTa = (string)allrecord.GetValue(2);
                    }
                    tt.TenNganhNghe = (string)allrecord.GetValue(1);
                    listrecord.Add(tt);
                }
                connect.Close();
                return listrecord;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }
#endregion
    }
}
