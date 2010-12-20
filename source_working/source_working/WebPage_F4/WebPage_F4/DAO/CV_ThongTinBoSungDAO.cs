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
    public class CV_ThongTinBoSungDAO
    {
        public int Insert(CV_ThongTinBoSungDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into CV_THONG_TIN_BO_SUNG(MucTieuNgheNghiep,KyNang,UuDiemKhuyetDiem,NangKhieuSoThich) values(@MucTieuNgheNghiep,@KyNang,@UuDiemKhuyetDiem,@NangKhieuSoThich) SET @IDR = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter muctieuParam = new SqlParameter("@MucTieuNgheNghiep", SqlDbType.NVarChar, 50);
                muctieuParam.Value = record.MucTieuNgheNghiep;
                SqlParameter kynangParam = new SqlParameter("@KyNang", SqlDbType.NText);
                kynangParam.Value = record.KyNang;
                SqlParameter uukhuyetParam = new SqlParameter("@UuDiemKhuyetDiem", SqlDbType.NText);
                uukhuyetParam.Value = record.UuDiemKhuyetDiem;
                SqlParameter nangkhieuParam = new SqlParameter("@NangKhieuSoThich", SqlDbType.NText);
                nangkhieuParam.Value = record.NangKhieuSoThich;
                SqlParameter IDParam = new SqlParameter("@IDR", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(muctieuParam);
                cmd.Parameters.Add(kynangParam);
                cmd.Parameters.Add(uukhuyetParam);
                cmd.Parameters.Add(nangkhieuParam);
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
