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
    public class CV_QuaTrinhHocVanDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenTruong;

        public string TenTruong
        {
            get { return _tenTruong; }
            set { _tenTruong = value; }
        }
        private string _chuyenNganh;

        public string ChuyenNganh
        {
            get { return _chuyenNganh; }
            set { _chuyenNganh = value; }
        }
        private string _bangCap;

        public string BangCap
        {
            get { return _bangCap; }
            set { _bangCap = value; }
        }
        private int _namTotNghiep;

        public int NamTotNghiep
        {
            get { return _namTotNghiep; }
            set { _namTotNghiep = value; }
        }
    }
}
