using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NgonNguDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _tenNgonNgu;

        public string TenNgonNgu
        {
            get { return _tenNgonNgu; }
            set { _tenNgonNgu = value; }
        }
        private int _trongSo;

        public int TrongSo
        {
            get { return _trongSo; }
            set { _trongSo = value; }
        }
        private int _iDKyNangNgonNgu;

        public int IDKyNangNgonNgu
        {
            get { return _iDKyNangNgonNgu; }
            set { _iDKyNangNgonNgu = value; }
        }

        public NgonNguDTO()
        {
            this.IDKyNangNgonNgu = -1;
            this.TenNgonNgu = "ten ngon ngu";
            this.TrongSo = 0;
        }
    }
}
