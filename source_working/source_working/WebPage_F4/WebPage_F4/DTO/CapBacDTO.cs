using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CapBacDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenCapBac;

        public string TenCapBac
        {
            get { return _tenCapBac; }
            set { _tenCapBac = value; }
        }
        private int _trongSo;

        public int TrongSo
        {
            get { return _trongSo; }
            set { _trongSo = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public CapBacDTO()
        {
            this.MoTa = "Mo ta ve cap bac";
            this.TenCapBac = "Ten cap bac";
            this.TrongSo = 0;
        }
    }
}
