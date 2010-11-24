using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NganhNgheDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenNganhNghe;

        public string TenNganhNghe
        {
            get { return _tenNganhNghe; }
            set { _tenNganhNghe = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public NganhNgheDTO()
        {
            MoTa = "";
        }

    }
}
