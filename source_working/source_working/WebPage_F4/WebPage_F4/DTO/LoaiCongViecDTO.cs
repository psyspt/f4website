using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiCongViecDTO
    {
        private string _tenCongViec;

        public string TenCongViec
        {
            get { return _tenCongViec; }
            set { _tenCongViec = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        private int _trongSo;

        public int TrongSo
        {
            get { return _trongSo; }
            set { _trongSo = value; }
        }
        public LoaiCongViecDTO()
        {

        }
    }
}
