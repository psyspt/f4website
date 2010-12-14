using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiUngVienDTO
    {
        private string _nganhNghe;

        public string NganhNghe
        {
            get { return _nganhNghe; }
            set { _nganhNghe = value; }
        }

        private string _capBac;

        public string CapBac
        {
            get { return _capBac; }
            set { _capBac = value; }
        }

        private string _bangCap;

        public string BangCap
        {
            get { return _bangCap; }
            set { _bangCap = value; }
        }
        public LoaiUngVienDTO()
        {

        }
    }
}