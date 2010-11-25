using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class TinhThanhDAO
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

        public List<TinhThanhDTO> GetAllRecord()
        {
            try
            {
                object[] allrecord = new object[3];
                List<TinhThanhDTO> listrecord = new List<TinhThanhDTO>();
                SqlCommand cmd = new SqlCommand("sp_SelectTINHTHANHsAll", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValues(allrecord);
                    TinhThanhDTO tt = new TinhThanhDTO();
                    tt.ID = (int)allrecord.GetValue(0);
                    tt.MaQuocGia = (int)allrecord.GetValue(2);
                    tt.TenTinhThanh = (string)allrecord.GetValue(1);
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
