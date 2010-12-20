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
    public class CV_ViecLamMongMuonDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _nganhNgheMongMuon;

        public string NganhNgheMongMuon
        {
            get { return _nganhNgheMongMuon; }
            set { _nganhNgheMongMuon = value; }
        }
        private string _viTriMongMuon;

        public string ViTriMongMuon
        {
            get { return _viTriMongMuon; }
            set { _viTriMongMuon = value; }
        }
        private string _mucLuong;

        public string MucLuong
        {
            get { return _mucLuong; }
            set { _mucLuong = value; }
        }
        private string _hinhThucLamViec;

        public string HinhThucLamViec
        {
            get { return _hinhThucLamViec; }
            set { _hinhThucLamViec = value; }
        }
        private string _loaiHinhCongViec;

        public string LoaiHinhCongViec
        {
            get { return _loaiHinhCongViec; }
            set { _loaiHinhCongViec = value; }
        }
        private string _noiLamViec;

        public string NoiLamViec
        {
            get { return _noiLamViec; }
            set { _noiLamViec = value; }
        }

        public CV_ViecLamMongMuonDTO()
        {
            this.HinhThucLamViec = "";
            this.LoaiHinhCongViec = "";
            this.MucLuong = "";
            this.NoiLamViec = "";
            this.NganhNgheMongMuon = "";
            this.ViTriMongMuon = "";
        }
    }
}
