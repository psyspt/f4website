using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DTO;
using BUS;
using System.Collections.Generic;
namespace WebPage_F4.UserControl
{
    public partial class uc_TaoCV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Init form
            //Thong tin lien he
            for (int i = 1; i <= 31; i++)
            {
                cbxThongTin_NgaySinh.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                cbxThongTin_Thang.Items.Add(i.ToString());
            }
            for (int i = 1950; i <= 1990; i++)
            {
                cbxThongTin_Nam.Items.Add(i.ToString());
            }
            cbxThongTin_GioiTinh.Items.Add("Nam");
            cbxThongTin_GioiTinh.Items.Add("Nữ");
            cbxThongTin_TinhTrangHonNhan.Items.Add("Đã kết hôn");
            cbxThongTin_TinhTrangHonNhan.Items.Add("Độc thân");
            //Thong tin ung dung
            cbxTTUngDung_KinhNghiem.Items.Add("Dưới 1 năm");
            cbxTTUngDung_KinhNghiem.Items.Add("Từ 1 đến 2 năm");
            cbxTTUngDung_KinhNghiem.Items.Add("Từ 2 đến 3 năm");
            cbxTTUngDung_KinhNghiem.Items.Add("Từ 3 đến 4 năm");
            cbxTTUngDung_KinhNghiem.Value = "Dưới 1 năm";

            cbxTTUngDung_CapBac.Items.Add("Quản lý");
            cbxTTUngDung_CapBac.Items.Add("Trưởng phòng");
            cbxTTUngDung_CapBac.Items.Add("Nhóm trưởng");
            cbxTTUngDung_CapBac.Items.Add("Nhân viên");
            cbxTTUngDung_CapBac.Value = "Nhân viên";

            cbxTTUngDung_BangCap.Items.Add("Đang là sinh viên/học sinh");
            cbxTTUngDung_BangCap.Items.Add("Cử nhân");
            cbxTTUngDung_BangCap.Items.Add("Thạc sĩ");
            cbxTTUngDung_BangCap.Items.Add("Tiến sĩ");
            cbxTTUngDung_BangCap.Items.Add("Phó giáo sư");
            cbxTTUngDung_BangCap.Items.Add("Giáo sư");
            cbxTTUngDung_BangCap.Value = "Đang là sinh viên/học sinh";

            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Anh");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Pháp");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Nga");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Mỹ");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Hàn");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Hoa");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Nhật");
            cbxTTUngDung_LoaiNgoaiNgu.Items.Add("tiếng Latinh");
            cbxTTUngDung_LoaiNgoaiNgu.Value = "tiếng Anh";

            cbxTTUngDung_TrinhDoNgoaiNgu.Items.Add("Level 1");
            cbxTTUngDung_TrinhDoNgoaiNgu.Items.Add("Level 2");
            cbxTTUngDung_TrinhDoNgoaiNgu.Items.Add("Level 3");
            cbxTTUngDung_TrinhDoNgoaiNgu.Items.Add("Level 4");
            cbxTTUngDung_TrinhDoNgoaiNgu.Items.Add("Level 5");
            cbxTTUngDung_TrinhDoNgoaiNgu.Value = "Level 1";

            //Viec lam mong muon
            NganhNgheBUS bus = new NganhNgheBUS();
            List<NganhNgheDTO> allrecord = new List<NganhNgheDTO>();
            allrecord = bus.GetAllRecord();
            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecord[i].TenNganhNghe, allrecord[i].ID.ToString());
                cbxVLMongMuon_NganhNghe.Items.Add(li);
            }

            cbxVLMongMuon_MucLuongDeNghi.Items.Add("200 USD");
            cbxVLMongMuon_MucLuongDeNghi.Items.Add("300 USD");
            cbxVLMongMuon_MucLuongDeNghi.Items.Add("400 USD");
            cbxVLMongMuon_MucLuongDeNghi.Items.Add("500 USD");
            cbxVLMongMuon_MucLuongDeNghi.Items.Add("600 USD");
            cbxVLMongMuon_MucLuongDeNghi.Value = "200 USD";

            List<TinhThanhDTO> allrecordTT = new List<TinhThanhDTO>();
            TinhThanhBUS busTT = new TinhThanhBUS();
            allrecordTT = busTT.GetAllRecord();
            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecordTT[i].TenTinhThanh, allrecordTT[i].ID.ToString());
                cbxVLMongMuon_NoiLamViec.Items.Add(li);
            }

            //Qua trinh hoc van
            cbxQuaTrinhHocTap_BangCap.Items.Add("Đang là sinh viên/học sinh");
            cbxQuaTrinhHocTap_BangCap.Items.Add("Cử nhân");
            cbxQuaTrinhHocTap_BangCap.Items.Add("Thạc sĩ");
            cbxQuaTrinhHocTap_BangCap.Items.Add("Tiến sĩ");
            cbxQuaTrinhHocTap_BangCap.Items.Add("Phó giáo sư");
            cbxQuaTrinhHocTap_BangCap.Items.Add("Giáo sư");
            cbxQuaTrinhHocTap_BangCap.Value = "Đang là sinh viên/học sinh";

            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecordTT[i].TenTinhThanh, allrecordTT[i].ID.ToString());
                cbxQuaTrinhHocTap_TinhThanh.Items.Add(li);
            }
            //Kinh nghiem lam viec

            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecordTT[i].TenTinhThanh, allrecordTT[i].ID.ToString());
                cbxKNLV_TinhTP.Items.Add(li);
            }
            for (int i = 1; i <= 12; i++)
            {
                cbxKNLV_Begin_Month.Items.Add("Tháng "+ i.ToString());
                cbxKNLV_End_Month.Items.Add("Tháng " + i.ToString());
            }
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbxKNLV_Begin_Year.Items.Add(i.ToString());
                cbxKNLV_End_Year.Items.Add(i.ToString());
            }
            //Thong tin bổ sung

            string username = "thic";//thay bang session["ID"]
            NguoiTimViecBUS busNTV = new NguoiTimViecBUS();
            NguoiTimViecDTO user = busNTV.SelectByusername(username);
            tbxThongTin_Email.Value = user.EMail;
            tbxThongTin_DiaChi.Value = user.DiaChi;
            tbxThongTin_DienThoai.Value = user.DienThoai;
            if (user.GioiTinh==1)
            {
                cbxThongTin_GioiTinh.Value = "Nam";
            }
            else
            {
                cbxThongTin_GioiTinh.Value = "Nữ";
            }
            cbxThongTin_NgaySinh.Value = user.NgaySinh.Day.ToString();
            cbxThongTin_Thang.Value = user.NgaySinh.Month.ToString();
            cbxThongTin_Nam.Value = user.NgaySinh.Year.ToString();
            cbxThongTin_TinhTrangHonNhan.Value = "Đã kết hôn";
            tbxThongTin_HoTen.Value = user.HoTen;
        }

        protected void butCV_Click(object sender, EventArgs e)
        {
            //
        }
    }
}