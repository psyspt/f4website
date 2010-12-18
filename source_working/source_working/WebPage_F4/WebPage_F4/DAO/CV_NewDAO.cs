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
    public class CV_NewDAO
    {
        public int Insert(CV_NewDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into CV_KINH_NGHIEM_LAM_VIEC"+
                    "(IDNguoiTimViec,ID_CV_KinhNghiem,ID_CV_QuaTrinhHocTap,ID_CV_ThongTinBoSung,ID_CV_ThongTinUngDung,ID_CV_ViecLamMongMuon)"
                    + " values(@IDNguoiTimViec,@ID_CV_KinhNghiem,@ID_CV_QuaTrinhHocTap,@ID_CV_ThongTinBoSung,@ID_CV_ThongTinUngDung,@ID_CV_ViecLamMongMuon)"
                +" SET @ID = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter nguoitimviecParam = new SqlParameter("@IDNguoiTimViec", SqlDbType.Int);
                nguoitimviecParam.Value = record.IDNguoiTimViec;
                SqlParameter kinhnghiemParam = new SqlParameter("@ID_CV_KinhNghiem", SqlDbType.Int);
                kinhnghiemParam.Value = record.IDKinhNghiem;
                SqlParameter quatrinhParam = new SqlParameter("@ID_CV_QuaTrinhHocTap", SqlDbType.Int);
                quatrinhParam.Value = record.IDQuaTrinhHocTap;
                SqlParameter ttbosungParam = new SqlParameter("@ID_CV_ThongTinBoSung", SqlDbType.Int);
                ttbosungParam.Value = record.IDThongTinBoSung;
                SqlParameter ttungdungParam = new SqlParameter("@ID_CV_ThongTinUngDung", SqlDbType.Int);
                ttungdungParam.Value = record.IDThongTinUngDung;
                SqlParameter vievlammmParam = new SqlParameter("@ID_CV_ViecLamMongMuon", SqlDbType.Int);
                vievlammmParam.Value = record.IDViecLamMongMuon;
                SqlParameter IDParam = new SqlParameter("@ID", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(nguoitimviecParam);
                cmd.Parameters.Add(kinhnghiemParam);
                cmd.Parameters.Add(quatrinhParam);
                cmd.Parameters.Add(ttbosungParam);
                cmd.Parameters.Add(ttungdungParam);
                cmd.Parameters.Add(vievlammmParam);
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
