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
    public class CV_KinhNghiemLamViecDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenCongTy;

        public string TenCongTy
        {
            get { return _tenCongTy; }
            set { _tenCongTy = value; }
        }
        private string _viTri;

        public string ViTri
        {
            get { return _viTri; }
            set { _viTri = value; }
        }
        private DateTime _thoiGianBatDau;

        public DateTime ThoiGianBatDau
        {
            get { return _thoiGianBatDau; }
            set { _thoiGianBatDau = value; }
        }
        private DateTime _thoiGianKetThuc;

        public DateTime ThoiGianKetThuc
        {
            get { return _thoiGianKetThuc; }
            set { _thoiGianKetThuc = value; }
        }
        private string _tinhTP;

        public string TinhTP
        {
            get { return _tinhTP; }
            set { _tinhTP = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public CV_KinhNghiemLamViecDTO()
        {
            this.MoTa = "";
            this.TenCongTy = "";
            this.TinhTP = "";
            this.ThoiGianBatDau = DateTime.Now;
            this.ThoiGianKetThuc = DateTime.Now;
            this.ViTri = "";
        }
    }
}
