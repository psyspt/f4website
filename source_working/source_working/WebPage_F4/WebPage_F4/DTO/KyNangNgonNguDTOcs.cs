using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KyNangNgonNguDTO
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public KyNangNgonNguDTO()
        {
            this.Level = 0;
        }
    }
}
