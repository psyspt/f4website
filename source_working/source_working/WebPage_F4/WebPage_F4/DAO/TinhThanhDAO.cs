using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class TinhThanhDAO
    {
#region Receiving
        public List<TinhThanhDTO> GetAllRecord()
        {
            List<TinhThanhDTO> listrecord = new List<TinhThanhDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[3];
                    SqlCommand cmd = new SqlCommand("sp_SelectTINHTHANHsAll", connect);
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
#endregion
    }
}
