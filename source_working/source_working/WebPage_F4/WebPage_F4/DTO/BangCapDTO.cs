using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BangCapDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenBang;

        public string TenBang
        {
            get { return _tenBang; }
            set { _tenBang = value; }
        }
        private DateTime _ngayCap;

        public DateTime NgayCap
        {
            get { return _ngayCap; }
            set { _ngayCap = value; }
        }
        private string _mota;

        public string Mota
        {
            get { return _mota; }
            set { _mota = value; }
        }
        private int _trongSo;

        public int TrongSo
        {
            get { return _trongSo; }
            set { _trongSo = value; }
        }

        public BangCapDTO()
        {
            this.Mota = "Mo ta ve bang cap";
            this.NgayCap = DateTime.Now;
            this.TenBang = "Ten bang cap";
            this.TrongSo = 0;
        }
    }
}
