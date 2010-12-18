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
using System.Text;
namespace WebPage_F4.DAO
{
    public class CV_KinhNghiemLamViecDAO
    {
        public int Insert(CV_KinhNghiemLamViecDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into CV_KINH_NGHIEM_LAM_VIEC(TenCongTy,ViTri,ThoiGianBatDau,ThoiGianKetThuc,TinhTP,MoTa) values(@TenCongTy,@ViTri,@ThoiGianBatDau,@ThoiGianKetThuc,@TinhTP,@MoTa) SET @ID = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter congtyParam = new SqlParameter("@TenCongTy", SqlDbType.NVarChar, 50);
                congtyParam.Value = record.TenCongTy;
                SqlParameter vitriParam = new SqlParameter("@ViTri", SqlDbType.NVarChar, 50);
                vitriParam.Value = record.ViTri;
                SqlParameter BeginTimeParam = new SqlParameter("@ThoiGianBatDau", SqlDbType.DateTime);
                BeginTimeParam.Value = record.ThoiGianBatDau;
                SqlParameter EndTimeParam = new SqlParameter("@ThoiGianKetThuc", SqlDbType.DateTime);
                EndTimeParam.Value = record.ThoiGianKetThuc;
                SqlParameter TinhTPParam = new SqlParameter("@TinhTP", SqlDbType.NVarChar,50);
                TinhTPParam.Value = record.TinhTP;
                SqlParameter MoTaParam = new SqlParameter("@MoTa", SqlDbType.NText);
                MoTaParam.Value = record.MoTa;
                SqlParameter IDParam = new SqlParameter("@ID", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(congtyParam);
                cmd.Parameters.Add(vitriParam);
                cmd.Parameters.Add(BeginTimeParam);
                cmd.Parameters.Add(EndTimeParam);
                cmd.Parameters.Add(TinhTPParam);
                cmd.Parameters.Add(MoTaParam);
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
