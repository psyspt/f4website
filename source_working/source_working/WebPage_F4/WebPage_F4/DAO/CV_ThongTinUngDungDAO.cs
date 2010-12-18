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
using System.Data.SqlClient;
using DAO;
namespace WebPage_F4.DAO
{
    public class CV_ThongTinUngDungDAO
    {
        public int Insert(CV_ThongTinUngDungDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into CV_THONG_TIN_UNG_DUNG(KinhNghiem,BangCap,CapBac,NgoaiNgu,DiCongTac,ChuyenChoO,LamNgoaiGio) values(@KinhNghiem,@BangCap,@CapBac,@NgoaiNgu,@DiCongTac,@ChuyenChoO,@LamNgoaiGio) SET @ID = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter kinhnghiem = new SqlParameter("@KinhNghiem", SqlDbType.Int);
                kinhnghiem.Value = record.KinhNghiem;
                SqlParameter bangcapParam = new SqlParameter("@BangCap", SqlDbType.Int);
                bangcapParam.Value = record.BangCap;
                SqlParameter capbacParam = new SqlParameter("@CapBac", SqlDbType.Int);
                capbacParam.Value = record.CapBac;
                SqlParameter ngoainguParam = new SqlParameter("@NgoaiNgu", SqlDbType.Int);
                ngoainguParam.Value = record.NgoaiNgu;
                SqlParameter congtacgParam = new SqlParameter("@DiCongTac", SqlDbType.NVarChar, 50);
                congtacgParam.Value = record.DiCongtac;
                SqlParameter chuyenchoParam = new SqlParameter("@ChuyenChoO", SqlDbType.NVarChar, 50);
                chuyenchoParam.Value = record.ChuyenChoO;
                SqlParameter lamngoaigioParam = new SqlParameter("@LamNgoaiGio", SqlDbType.NVarChar, 50);
                lamngoaigioParam.Value = record.LamNgoaiGio;
                SqlParameter IDParam = new SqlParameter("@ID", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(kinhnghiem);
                cmd.Parameters.Add(bangcapParam);
                cmd.Parameters.Add(capbacParam);
                cmd.Parameters.Add(ngoainguParam);
                cmd.Parameters.Add(congtacgParam);
                cmd.Parameters.Add(chuyenchoParam);
                cmd.Parameters.Add(lamngoaigioParam);
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
