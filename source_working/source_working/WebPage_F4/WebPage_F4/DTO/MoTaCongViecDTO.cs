using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MoTaCongViecDTO
    {
        private string _viTriTuyenDung;

        public string ViTriTuyenDung
        {
            get { return _viTriTuyenDung; }
            set { _viTriTuyenDung = value; }
        }

        private string _moTaCongViec;

        public string MoTaCongViec
        {
            get { return _moTaCongViec; }
            set { _moTaCongViec = value; }
        }

        private string _kyNangCongViec;

        public string KyNangCongViec
        {
            get { return _kyNangCongViec; }
            set { _kyNangCongViec = value; }
        }

    }
}
