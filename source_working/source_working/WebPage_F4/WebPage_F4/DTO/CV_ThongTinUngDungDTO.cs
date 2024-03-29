﻿using System;
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
    public class CV_ThongTinUngDungDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _kinhNghiem;

        public string KinhNghiem
        {
            get { return _kinhNghiem; }
            set { _kinhNghiem = value; }
        }
        private string _bangCap;

        public string BangCap
        {
            get { return _bangCap; }
            set { _bangCap = value; }
        }
        private string _capBac;

        public string CapBac
        {
            get { return _capBac; }
            set { _capBac = value; }
        }
        private string _ngoaiNgu;

        public string NgoaiNgu
        {
            get { return _ngoaiNgu; }
            set { _ngoaiNgu = value; }
        }
        private string _diCongtac;

        public string DiCongtac
        {
            get { return _diCongtac; }
            set { _diCongtac = value; }
        }
        private string _chuyenChoO;

        public string ChuyenChoO
        {
            get { return _chuyenChoO; }
            set { _chuyenChoO = value; }
        }
        private string _lamNgoaiGio;

        public string LamNgoaiGio
        {
            get { return _lamNgoaiGio; }
            set { _lamNgoaiGio = value; }
        }

        public CV_ThongTinUngDungDTO()
        {
            this.BangCap = "";
            this.CapBac = "";
            this.ChuyenChoO = "";
            this.DiCongtac = "";
            this.KinhNghiem = "";
            this.LamNgoaiGio = "";
            this.NgoaiNgu = "";
        }
    }
}
