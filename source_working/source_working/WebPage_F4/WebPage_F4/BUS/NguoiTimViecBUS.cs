using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NguoiTimViecBUS
    {
        public int Insert(NguoiTimViecDTO newrecord)
        {
            NguoiTimViecDAO dao = new NguoiTimViecDAO();
            return dao.Insert(newrecord);
        }

        public NguoiTimViecDTO SelectByusername(string username)
        {
            NguoiTimViecDAO dao = new NguoiTimViecDAO();
            return dao.SelectByUsername(username);
        }
    }
}
