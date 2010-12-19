using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KinhNghiemDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private int _thoiGian_Bot;

        public int ThoiGian_Bot
        {
            get { return _thoiGian_Bot; }
            set { _thoiGian_Bot = value; }
        }
        private int _thoiGian_Top;

        public int ThoiGian_Top
        {
            get { return _thoiGian_Top; }
            set { _thoiGian_Top = value; }
        }
        private int _trongSo;

        public int TrongSo
        {
            get { return _trongSo; }
            set { _trongSo = value; }
        }

        public KinhNghiemDTO()
        {
            this.ThoiGian_Bot = 0;
            this.ThoiGian_Top = 0;
            this.TrongSo = 0;
        }
    }
}
