using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class QuocGiaDTO
    {
        private string _tenQuocGia;

        public string TenQuocGia
        {
            get { return _tenQuocGia; }
            set { _tenQuocGia = value; }
        }
        private int _maQuocGia;

        public int MaQuocGia
        {
            get { return _maQuocGia; }
            set { _maQuocGia = value; }
        }
        
    }
}
