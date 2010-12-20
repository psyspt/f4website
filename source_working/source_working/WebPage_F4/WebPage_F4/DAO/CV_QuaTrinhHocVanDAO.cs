using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WebPage_F4.DTO;
using DAO;
using System.Data.SqlClient;
namespace WebPage_F4.DAO
{
    public class CV_QuaTrinhHocVanDAO
    {
        public int Insert(CV_QuaTrinhHocVanDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into CV_QUA_TRINH_HOC_VAN(TenTruong,ChuyenNganh,BangCap,NamTotNghiep) values(@TenTruong,@ChuyenNganh,@BangCap,@NamTotNghiep) SET @IDR = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter truongParam = new SqlParameter("@TenTruong", SqlDbType.NVarChar, 50);
                truongParam.Value = record.TenTruong;
                SqlParameter chuyennganhParam = new SqlParameter("@ChuyenNganh", SqlDbType.NVarChar, 50);
                chuyennganhParam.Value = record.ChuyenNganh;
                SqlParameter bangcapParam = new SqlParameter("@BangCap", SqlDbType.NVarChar,50);
                bangcapParam.Value = record.BangCap;
                SqlParameter namtotnghiepParam = new SqlParameter("@NamTotNghiep", SqlDbType.Int);
                namtotnghiepParam.Value = record.NamTotNghiep;
                SqlParameter IDParam = new SqlParameter("@IDR", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(truongParam);
                cmd.Parameters.Add(chuyennganhParam);
                cmd.Parameters.Add(bangcapParam);
                cmd.Parameters.Add(namtotnghiepParam);
                cmd.Parameters.Add(IDParam);
                cmd.ExecuteNonQuery();
                int id = (int)IDParam.Value;
                return id;
            }
            catch (System.Exception ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }

        
    }
}
