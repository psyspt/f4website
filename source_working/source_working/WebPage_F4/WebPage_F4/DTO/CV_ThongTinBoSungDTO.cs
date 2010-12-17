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
    public class CV_ThongTinBoSungDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _mucTieuNgheNghiep;

        public string MucTieuNgheNghiep
        {
            get { return _mucTieuNgheNghiep; }
            set { _mucTieuNgheNghiep = value; }
        }
        private string _KyNang;

        public string KyNang
        {
            get { return _KyNang; }
            set { _KyNang = value; }
        }
        private string _uuDiemKhuyetDiem;

        public string UuDiemKhuyetDiem
        {
            get { return _uuDiemKhuyetDiem; }
            set { _uuDiemKhuyetDiem = value; }
        }
        private string _nangKhieuSoThich;

        public string NangKhieuSoThich
        {
            get { return _nangKhieuSoThich; }
            set { _nangKhieuSoThich = value; }
        }

        public CV_ThongTinBoSungDTO()
        {
            this.KyNang = "";
            this.MucTieuNgheNghiep = "";
            this.NangKhieuSoThich = "";
            this.UuDiemKhuyetDiem = "";
        }
    }
}
