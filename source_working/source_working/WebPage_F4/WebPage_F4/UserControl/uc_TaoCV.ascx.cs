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
using WebPage_F4.BUS;
using WebPage_F4.DTO;
namespace WebPage_F4.UserControl
{
    public partial class uc_TaoCV : System.Web.UI.UserControl
    {
        NguoiTimViecDTO CurrentUser = new NguoiTimViecDTO();
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
                cbxKNLV_Begin_Month.Items.Add(i.ToString());
                cbxKNLV_End_Month.Items.Add(i.ToString());
            }
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbxKNLV_Begin_Year.Items.Add(i.ToString());
                cbxKNLV_End_Year.Items.Add(i.ToString());
            }
            //Thong tin bổ sung

            string username = "thic";//thay bang session["ID"]
            NguoiTimViecBUS busNTV = new NguoiTimViecBUS();
            CurrentUser = busNTV.SelectByusername(username);
            tbxThongTin_Email.Value = CurrentUser.EMail;
            tbxThongTin_DiaChi.Value = CurrentUser.DiaChi;
            tbxThongTin_DienThoai.Value = CurrentUser.DienThoai;
            if (CurrentUser.GioiTinh == 1)
            {
                cbxThongTin_GioiTinh.Value = "Nam";
            }
            else
            {
                cbxThongTin_GioiTinh.Value = "Nữ";
            }
            cbxThongTin_NgaySinh.Value = CurrentUser.NgaySinh.Day.ToString();
            cbxThongTin_Thang.Value = CurrentUser.NgaySinh.Month.ToString();
            cbxThongTin_Nam.Value = CurrentUser.NgaySinh.Year.ToString();
            cbxThongTin_TinhTrangHonNhan.Value = "Đã kết hôn";
            tbxThongTin_HoTen.Value = CurrentUser.HoTen;
        }

        protected void butCV_Click(object sender, EventArgs e)
        {
            CV_KinhNghiemLamViecBUS busKNLV = new CV_KinhNghiemLamViecBUS();
            CV_NewBUS busCV = new CV_NewBUS();
            CV_QuaTrinhHocVanBUS busQTHV = new CV_QuaTrinhHocVanBUS();
            CV_ThongTinBoSungBUS busTTBS = new CV_ThongTinBoSungBUS();
            CV_ThongTinUngDungBUS busTTUD = new CV_ThongTinUngDungBUS();
            CV_ViecLamMongMuonBUS busVLMM = new CV_ViecLamMongMuonBUS();

            int idNTV = CurrentUser.ID;

            CV_ThongTinUngDungDTO dtoTTUD = new CV_ThongTinUngDungDTO();
            dtoTTUD.KinhNghiem = cbxTTUngDung_KinhNghiem.Value;
            dtoTTUD.BangCap = cbxTTUngDung_BangCap.Value;
            dtoTTUD.CapBac = cbxTTUngDung_CapBac.Value;
            dtoTTUD.NgoaiNgu = cbxTTUngDung_LoaiNgoaiNgu.Value;
            if (rbTTUngDung_ChuyenCho_Option.Checked)
            {
                dtoTTUD.ChuyenChoO = "Tùy trường hợp";
            }
            else if (rbTTUngDung_ChuyenCho_Yes.Checked)
            {
                dtoTTUD.ChuyenChoO = "Có";
            }
            else if (rdTTUngDung_ChuyenCho_No.Checked)
            {
                dtoTTUD.ChuyenChoO = "Không";
            }

            if (rdTTUngDung_CongTac_No.Checked)
            {
                dtoTTUD.DiCongtac = "Không";
            }
            else if (rdTTUngDung_CongTac_Yes.Checked)
            {
                dtoTTUD.DiCongtac = "Có";
            }
            else if (rdTTUngDung_CongTac_Option.Checked)
            {
                dtoTTUD.DiCongtac = "Tùy trường hợp";
            }

            if (rdTTUngDung_LamNgoaiGio_No.Checked)
            {
                dtoTTUD.LamNgoaiGio = "Không";
            }
            else if (rdTTUngDung_LamNgoaigio_Yes.Checked)
            {
                dtoTTUD.LamNgoaiGio = "Có";
            }
            else if (rdTTUngDung_LamNgoaiGio_Option.Checked)
            {
                dtoTTUD.LamNgoaiGio = "Tùy trường hợp";
            }
            int idTTUD = busTTUD.Insert(dtoTTUD);

            CV_ViecLamMongMuonDTO dtoVLMM = new CV_ViecLamMongMuonDTO();
            dtoVLMM.MucLuong = cbxVLMongMuon_MucLuongDeNghi.Value;
            dtoVLMM.NoiLamViec = cbxVLMongMuon_NoiLamViec.Value;
            dtoVLMM.NganhNgheMongMuon = cbxVLMongMuon_NganhNghe.Value;
            dtoVLMM.ViTriMongMuon = tbxVLMongMuon_ViTri.Value;
            if (cbVLMongMuon_HinhThucCongViec_ChinhThuc.Checked)
            {
                dtoVLMM.HinhThucLamViec = "Nhân viên chính thức";
            }
            else if (cbVLMongMuon_HinhThucCongViec_TuDo.Checked)
            {
                dtoVLMM.HinhThucLamViec = "Tự do";
            }
            else if (cbVLMongMuon_HinhThucCongViec_ThoiVu.Checked)
            {
                dtoVLMM.HinhThucLamViec = "Nhân viên thời vụ";
            }

            if (cbVLMongMuon_LaiCongViec_Parttime.Checked)
            {
                dtoVLMM.LoaiHinhCongViec = "Part-time";
            }
            else if (cbVLMongMuon_LoaiCongViec_Fulltime.Checked)
            {
                dtoVLMM.LoaiHinhCongViec = "Full-time";
            }
            int idVLMM = busVLMM.Insert(dtoVLMM);

            CV_QuaTrinhHocVanDTO dtoQTHV = new CV_QuaTrinhHocVanDTO();
            dtoQTHV.TenTruong = tbxQuaTrinhHocTap_TenTruong.Value;
            dtoQTHV.ChuyenNganh = tbxQuaTrinhHocTap_ChuyenNganh.Value;
            dtoQTHV.BangCap = cbxQuaTrinhHocTap_BangCap.Value;
            dtoQTHV.NamTotNghiep = DateTime.Parse(tbxNgayTotNghiep.Text).Year;
            int idQTHV = busQTHV.Insert(dtoQTHV);

            CV_KinhNghiemLamViecDTO dtoKNLV = new CV_KinhNghiemLamViecDTO();
            dtoKNLV.MoTa = tbxKNLV_MoTa.Value;
            dtoKNLV.TenCongTy = tbxKNLV_TenCongTy.Value;
            dtoKNLV.TinhTP = cbxKNLV_TinhTP.Value;
            dtoKNLV.ViTri = tbxKNLV_ViTriCongViec.Value;
            dtoKNLV.ThoiGianBatDau = new DateTime(int.Parse(cbxKNLV_Begin_Year.Value), int.Parse(cbxKNLV_Begin_Month.Value), 1);
            dtoKNLV.ThoiGianKetThuc = new DateTime(int.Parse(cbxKNLV_End_Year.Value), int.Parse(cbxKNLV_End_Month.Value), 1);
            int idKNLV = busKNLV.Insert(dtoKNLV);

            CV_ThongTinBoSungDTO dtoTTBS = new CV_ThongTinBoSungDTO();
            dtoTTBS.KyNang = tbxKynang.Value;
            dtoTTBS.MucTieuNgheNghiep = tbxMucTieu.Value;
            dtoTTBS.NangKhieuSoThich = tbxNangKhieuSoThich.Value;
            dtoTTBS.UuDiemKhuyetDiem = tbxUuDiemNhuocDiem.Value;
            int idTTBS = busTTBS.Insert(dtoTTBS);

            CV_NewDTO newCV = new CV_NewDTO();
            newCV.IDKinhNghiem = idKNLV;
            newCV.IDNguoiTimViec = CurrentUser.ID;
            newCV.IDQuaTrinhHocTap = idQTHV;
            newCV.IDThongTinBoSung = idTTBS;
            newCV.IDThongTinUngDung = idTTUD;
            newCV.IDViecLamMongMuon = idVLMM;
            int kq = busCV.Insert(newCV);

        }
    }
}