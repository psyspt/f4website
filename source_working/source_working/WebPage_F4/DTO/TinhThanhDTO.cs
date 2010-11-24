using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TinhThanhDTO
    {
        private string _tenTinhThanh;

        public string TenTinhThanh
        {
            get { return _tenTinhThanh; }
            set { _tenTinhThanh = value; }
        }
        private int _maQuocGia;

        public int MaQuocGia
        {
            get { return _maQuocGia; }
            set { _maQuocGia = value; }
        }
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public TinhThanhDTO()
        {
            MaQuocGia = 1;
        }
    }
}
