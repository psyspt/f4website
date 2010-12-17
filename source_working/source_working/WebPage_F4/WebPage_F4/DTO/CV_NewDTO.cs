using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WebPage_F4.DTO
{
    public class CV_NewDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private int _iDNguoiTimViec;

        public int IDNguoiTimViec
        {
            get { return _iDNguoiTimViec; }
            set { _iDNguoiTimViec = value; }
        }
        private int _iDKinhNghiem;

        public int IDKinhNghiem
        {
            get { return _iDKinhNghiem; }
            set { _iDKinhNghiem = value; }
        }
        private int _iDQuaTrinhHocTap;

        public int IDQuaTrinhHocTap
        {
            get { return _iDQuaTrinhHocTap; }
            set { _iDQuaTrinhHocTap = value; }
        }
        private int _iDThongTinBoSung;

        public int IDThongTinBoSung
        {
            get { return _iDThongTinBoSung; }
            set { _iDThongTinBoSung = value; }
        }
        private int _iDThongTinUngDung;

        public int IDThongTinUngDung
        {
            get { return _iDThongTinUngDung; }
            set { _iDThongTinUngDung = value; }
        }
        private int _iDViecLamMongMuon;

        public int IDViecLamMongMuon
        {
            get { return _iDViecLamMongMuon; }
            set { _iDViecLamMongMuon = value; }
        }
    }
}
