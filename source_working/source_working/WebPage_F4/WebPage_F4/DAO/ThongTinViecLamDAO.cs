using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class ThongTinViecLamDAO
    {
        #region Inserting
        public int Insert(ThongTinViecLamDTO newrecord)
        {
            int result;
            try
            {
                SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_insertTHONGTINVIECLAM", connect);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter MaSoCongViec_param = cmd.Parameters.Add("@MaSoCongViec", System.Data.SqlDbType.NVarChar);
                    SqlParameter SoLuong_param = cmd.Parameters.Add("@SoLuong", System.Data.SqlDbType.Int);
                    SqlParameter GioiTinh_param = cmd.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Int);
                    SqlParameter TuoiMin_param = cmd.Parameters.Add("@TuoiMin", System.Data.SqlDbType.Int);
                    SqlParameter TuoiMax_param = cmd.Parameters.Add("@TuoiMax", System.Data.SqlDbType.Int);
                    SqlParameter SoNamKinhNghiem_param = cmd.Parameters.Add("@SoNamKinhNghiem", System.Data.SqlDbType.Int);
                    SqlParameter QuocGia_param = cmd.Parameters.Add("@QuocGia", System.Data.SqlDbType.Int);
                    SqlParameter TinhThanh_param = cmd.Parameters.Add("@TinhThanh", System.Data.SqlDbType.Int);
                    SqlParameter LoaiCV_param = cmd.Parameters.Add("@LoaiCV", System.Data.SqlDbType.Int);
                    SqlParameter MucLuong_param = cmd.Parameters.Add("@MucLuong", System.Data.SqlDbType.Int);
                    SqlParameter PhuCapKhac_param = cmd.Parameters.Add("@PhuCapKhac", System.Data.SqlDbType.NVarChar);
                    //SqlParameter HanNopHoSo_param = cmd.Parameters.Add("@HanNopHoSo", System.Data.SqlDbType.DateTime);

                    MaSoCongViec_param.Direction = System.Data.ParameterDirection.Input;
                    SoLuong_param.Direction = System.Data.ParameterDirection.Input;
                    GioiTinh_param.Direction = System.Data.ParameterDirection.Input;
                    TuoiMin_param.Direction = System.Data.ParameterDirection.Input;
                    TuoiMax_param.Direction = System.Data.ParameterDirection.Input;
                    SoNamKinhNghiem_param.Direction = System.Data.ParameterDirection.Input;
                    QuocGia_param.Direction = System.Data.ParameterDirection.Input;
                    TinhThanh_param.Direction = System.Data.ParameterDirection.Input;
                    LoaiCV_param.Direction = System.Data.ParameterDirection.Input;
                    MucLuong_param.Direction = System.Data.ParameterDirection.Input;
                    PhuCapKhac_param.Direction = System.Data.ParameterDirection.Input;
                    //HanNopHoSo_param.Direction = System.Data.ParameterDirection.Input;


                    MaSoCongViec_param.Value = newrecord.MaSoCongViec;
                    SoLuong_param.Value = newrecord.SoLuong;
                    GioiTinh_param.Value = newrecord.GioiTinh;
                    TuoiMin_param.Value = newrecord.TuoiMin;
                    TuoiMax_param.Value = newrecord.TuoiMax;
                    SoNamKinhNghiem_param.Value = newrecord.SoNamKinhNghiem;
                    QuocGia_param.Value = newrecord.QuocGia;
                    TinhThanh_param.Value = newrecord.TinhThanh;
                    LoaiCV_param.Value = newrecord.LoaiCongViec;
                    MucLuong_param.Value = newrecord.MucLuong;
                    PhuCapKhac_param.Value = newrecord.PhuCapKhac;
                    //HanNopHoSo_param.Value = newrecord.HanNopSoSo;

                    result = cmd.ExecuteNonQuery();
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
            return result;
        }
        #endregion

    }
}
