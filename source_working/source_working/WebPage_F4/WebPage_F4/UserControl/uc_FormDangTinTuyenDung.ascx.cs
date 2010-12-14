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
    public partial class uc_FormDangTinTuyenDung : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String strEmail = Session["Email"];

            string strEmail = "f4depnhuhoa@gmail.com";
            NhaTuyenDungDTO nhatuyendung = new NhaTuyenDungDTO();

            NhaTuyenDungBUS ntdBus = new NhaTuyenDungBUS();

            nhatuyendung = ntdBus.SelectByEmail(strEmail);

            TenCongTy.Value = nhatuyendung.TenCongTy;
            TenLienLac.Value = nhatuyendung.TenNguoiDaiDien;
            Email.Value = nhatuyendung.Email;
            DiaChi.Value = nhatuyendung.DiaChi;
            QuocGia.Value = "F4";
            TinhThanh.Value = "F4";
            DienThoai.Value = nhatuyendung.DienThoai;
            Fax.Value = "F4";

            // Lấy thông tin phân loại ứng viên
            List<string> ListBangCap = new List<string>();
            LoaiUngVienBUS bus = new LoaiUngVienBUS();
            ListBangCap = bus.GetBangCap();
            List<string> ListNganhNghe = bus.GetNganhNghe();
            List<string> ListCapBac = bus.GetCapBac();


            for (int i = 0; i < ListBangCap.Count; i++)
            {
                ListItem liBangCap = new ListItem(ListBangCap[i], ListBangCap[i]);
                BangCap.Items.Add(liBangCap);
            }

            for (int i = 0; i < ListCapBac.Count; i++)
            {
                ListItem LiCapBac = new ListItem(ListCapBac[i], ListCapBac[i]);
                CapBac.Items.Add(LiCapBac);
            }

            for (int i = 0; i < ListNganhNghe.Count; i++)
            {
                ListItem LiNganhNghe = new ListItem(ListNganhNghe[i], ListNganhNghe[i]);
                NganhNghe.Items.Add(LiNganhNghe);
            }

            // lấy tỉnh thành, quốc gia

            List<TinhThanhDTO> allrecord = new List<TinhThanhDTO>();
            TinhThanhBUS bustt = new TinhThanhBUS();
            allrecord = bustt.GetAllRecord();
            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecord[i].TenTinhThanh, allrecord[i].ID.ToString());
                TinhThanhList.Items.Add(li);
            }

            List<QuocGiaDTO> allQuocGia = new List<QuocGiaDTO>();
            QuocGiaBUS busqg = new QuocGiaBUS();
            allQuocGia = busqg.GetAllRecord();
            for (int i = 0; i < allQuocGia.Count; i++)
            {
                ListItem li = new ListItem(allQuocGia[i].TenQuocGia, allQuocGia[i].MaQuocGia.ToString());
                QuocGiaList.Items.Add(li);
            }

            // thêm giới tính vào listbox

            GioiTinh.Items.Add(new ListItem("Nam", "0"));
            GioiTinh.Items.Add(new ListItem("Nữ", "1"));
            GioiTinh.Items.Add(new ListItem("Khác", "2"));

            //Thêm số năm kinh nghiệm

            KinhNghiem.Items.Add(new ListItem(" < 1 năm", "1"));
            KinhNghiem.Items.Add(new ListItem(" 1 -> 5 năm", "2"));
            KinhNghiem.Items.Add(new ListItem(" 5 -> 10 năm", "3"));
            KinhNghiem.Items.Add(new ListItem(" > 10 năm", "4"));


        }

        protected void DongY_Click(object sender, EventArgs e)
        {
            
            MoTaCongViecDTO motacongviec = new MoTaCongViecDTO();
            motacongviec.KyNangCongViec = KyNangCongViec.Value.ToString();
            motacongviec.MoTaCongViec = MoTaCongViec.Value.ToString();
            motacongviec.ViTriTuyenDung = ViTriTuyenDung.Value.ToString();
            
            ThongTinViecLamDTO thongtinvieclam = new ThongTinViecLamDTO();
            thongtinvieclam.MaSoCongViec = MaSoCongViec.Value.ToString();
            thongtinvieclam.SoLuong = Int32.Parse(SoLuong.Value.ToString());
            thongtinvieclam.TuoiMin = Int32.Parse(TuoiMin.Value.ToString());
            thongtinvieclam.TuoiMax = Int32.Parse(TuoiMax.Value.ToString());
            thongtinvieclam.QuocGia = Int32.Parse(QuocGiaList.Value.ToString());
            thongtinvieclam.TinhThanh = Int32.Parse(TinhThanhList.Value.ToString());
            thongtinvieclam.MucLuong = Int32.Parse(MucLuong.Value.ToString());
            thongtinvieclam.PhuCapKhac = PhuCap.Value.ToString();
            thongtinvieclam.SoNamKinhNghiem = Int32.Parse(KinhNghiem.Value.ToString());
            //thongtinvieclam.HanNopSoSo = DateTime.Parse(HanNopHoSo.Value.ToString());
            thongtinvieclam.GioiTinh = Int32.Parse(GioiTinh.Value.ToString());

            LoaiCongViecDTO LoaiCongViec = new LoaiCongViecDTO();

            if (Checkbox1.Checked == true)
            {
                LoaiCongViec.TenCongViec = "Full-time";
            }
            if (Checkbox2.Checked == true)
            {
                LoaiCongViec.TenCongViec = "Part-time";
            }
            if (Checkbox3.Checked == true)
            {
                LoaiCongViec.MoTa = "Nhân viên chính thức";
            }
            if (Checkbox4.Checked == true)
            {
                LoaiCongViec.MoTa = "Thời vụ";
            }
            if (Checkbox5.Checked == true)
            {
                LoaiCongViec.MoTa = "Tự do";
            }
            LoaiCongViec.TrongSo = 1;
            LoaiCongViecBUS busLoaiCV = new LoaiCongViecBUS();
           
            thongtinvieclam.LoaiCongViec = busLoaiCV.GetIDLoaiCV(LoaiCongViec);

            ThongTinViecLamBUS busThongTin = new ThongTinViecLamBUS();
            busThongTin.Insert(thongtinvieclam);


            LoaiUngVienDTO LoaiUngVien = new LoaiUngVienDTO();
            LoaiUngVien.NganhNghe = NganhNghe.Value.ToString();
            LoaiUngVien.CapBac = CapBac.Value.ToString();
            LoaiUngVien.BangCap = BangCap.Value.ToString();

            LoaiUngVienBUS busLoaiUV = new LoaiUngVienBUS();
            busLoaiUV.insert(LoaiUngVien);

            NhaTuyenDungBUS busNhaTD = new NhaTuyenDungBUS();
            TinTuyenDungDTO TinTuyenDung = new TinTuyenDungDTO();
            String strEmail = Email.Value.ToString();
            TinTuyenDung.NhanTuyenDung = busNhaTD.GetIDNhaTuyenDung(strEmail);
            TinTuyenDung.LoaiUngVien = busLoaiUV.GetIDLoaiUV(LoaiUngVien);
            TinTuyenDung.MaSoCongViec = thongtinvieclam.MaSoCongViec;
            TinTuyenDung.ViTriTuyenDung = motacongviec.ViTriTuyenDung;
            TinTuyenDung.MoTaCongViec = motacongviec.MoTaCongViec;
            TinTuyenDung.KyNangCongViec = motacongviec.KyNangCongViec;

            TinTuyenDungBUS BusTTT = new TinTuyenDungBUS();
            BusTTT.Insert(TinTuyenDung);
        }

    }
}