using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class NganhNgheDAO
    {
        private string connectionString = "Data Source=LTBCOMPUTER;Initial Catalog=CSDLWeb;Integrated Security=True";
        public static SqlConnection conn;
        public bool ConnectToSQLServer()
        {
            conn = new SqlConnection(connectionString);
            if (conn != null)
            {
                conn.Open();
                return true;
            }
            return false;
        }

        public List<NganhNgheDTO> GetAllRecord()
        {
            try
            {
                object[] allrecord = new object[3];
                List<NganhNgheDTO> listrecord = new List<NganhNgheDTO>();
                SqlCommand cmd = new SqlCommand("sp_SelectNGANHNGHEsAll", conn);
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
                        tt.MoTa= (string)allrecord.GetValue(2);
                    }
                    tt.TenNganhNghe = (string)allrecord.GetValue(1);
                    listrecord.Add(tt);
                }
                return listrecord;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }
    }
}
