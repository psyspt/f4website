using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class QuocGiaDAO
    {
        #region Receiving
        public List<QuocGiaDTO> GetAllRecord()
        {
            List<QuocGiaDTO> listrecord = new List<QuocGiaDTO>();
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    object[] allrecord = new object[3];
                    SqlCommand cmd = new SqlCommand("sp_SelectQUOCGIAsAll", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reader.GetValues(allrecord);
                        QuocGiaDTO tt = new QuocGiaDTO();
                        tt.MaQuocGia = (int)allrecord.GetValue(0);
                        tt.TenQuocGia = (string)allrecord.GetValue(1);
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
