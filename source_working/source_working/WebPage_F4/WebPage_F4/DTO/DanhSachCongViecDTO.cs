using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DanhSachCOngViecDTO
    {
        private string _CongTy;

        public string CongTy
        {
            get { return _CongTy; }
            set { _CongTy = value; }
        }
        private string _Nganh;

        public string Nganh
        {
            get { return _Nganh; }
            set { _Nganh = value; }
        }

        public DanhSachCOngViecDTO()
        {

        }
    }
}