using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CaptchaDTO
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _CaptchaString;

        public string CaptchaString
        {
            get { return _CaptchaString; }
            set { _CaptchaString = value; }
        }

        public CaptchaDTO()
        {

        }
    }
}
