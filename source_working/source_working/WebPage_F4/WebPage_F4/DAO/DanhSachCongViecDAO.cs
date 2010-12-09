using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DanhSachCongViecDAO
    {
        #region Receive
        public List<DanhSachCOngViecDTO> GetDSCV(string username)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();

            StringBuilder command = new StringBuilder();
            command.Append("Select D.TenNganh From NGUOITIMVIEC A, NGUOITIMVIECLUUTINTUYENDUNG B, TINTUYENDUNG C, NGANHNGHE D where A.ID = B.MaNguoiTimViec and B.MaTinTuyenDung = C.ID and C.Nganh = D.ID and A.Username ='");
            command.Append(username);
            command.Append("'");
            SqlCommand cmd = new SqlCommand(command.ToString(), connect);
            SqlDataReader r = cmd.ExecuteReader();
            
            List<DanhSachCOngViecDTO> lsDSCV = new List<DanhSachCOngViecDTO>();
            
            while (r.Read())
            {
                DanhSachCOngViecDTO record = new DanhSachCOngViecDTO();
                record.Nganh = r["TenNganh"].ToString();
                lsDSCV.Add(record);
            }
            connect.Close();
            return lsDSCV;
        }
        #endregion
    }
}
