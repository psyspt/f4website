using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class CaptchaBUS
    {
        public string GetString(int ID)
        {
            CaptchaDAO dao = new CaptchaDAO();
            return dao.GetCaptchaString(ID);
        }

    }
}
