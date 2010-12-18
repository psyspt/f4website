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
    public class CV_ViecLamMongMuonDAO
    {
        public int Insert(CV_ViecLamMongMuonDTO record)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();
            try
            {
                string strcmd = "insert into "
                +"CV_VIEC_LAM_MONG_MUON(NganhNgheMongMuon,ViTriMongMuon,MucLuong,HinhThucLamViec,LoaiHinhCongViec,NoiLamVIec)"
                +" values(@NganhNgheMongMuon,@ViTriMongMuon,@MucLuong,@HinhThucLamViec,@LoaiHinhCongViec,@NoiLamVIec)"
                +" SET @ID = SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(strcmd, connect);
                SqlParameter nganhngheParam = new SqlParameter("@NganhNgheMongMuon", SqlDbType.NVarChar, 50);
                nganhngheParam.Value = record.NganhNgheMongMuon;
                SqlParameter vitriParam = new SqlParameter("@ViTriMongMuon", SqlDbType.NVarChar, 50);
                vitriParam.Value = record.ViTriMongMuon;
                SqlParameter mucluongParam = new SqlParameter("@MucLuong", SqlDbType.Int);
                mucluongParam.Value = record.MucLuong;
                SqlParameter hinhthucParam = new SqlParameter("@HinhThucLamViec", SqlDbType.NVarChar, 50);
                hinhthucParam.Value = record.HinhThucLamViec;
                SqlParameter loaihinhParam = new SqlParameter("@LoaiHinhCongViec", SqlDbType.Int);
                loaihinhParam.Value = record.LoaiHinhCongViec;
                SqlParameter noilamviecParam = new SqlParameter("@NoiLamVIec", SqlDbType.NVarChar, 50);
                noilamviecParam.Value = record.NoiLamViec;

                SqlParameter IDParam = new SqlParameter("@ID", SqlDbType.Int);
                IDParam.Direction = ParameterDirection.Output;
                //MoTaParam.Value = record.MoTa;
                cmd.Parameters.Add(nganhngheParam);
                cmd.Parameters.Add(vitriParam);
                cmd.Parameters.Add(mucluongParam);
                cmd.Parameters.Add(hinhthucParam);
                cmd.Parameters.Add(loaihinhParam);
                cmd.Parameters.Add(noilamviecParam);
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
