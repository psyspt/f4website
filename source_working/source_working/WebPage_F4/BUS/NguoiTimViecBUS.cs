using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NguoiTimViecBUS
    {
        public bool Insert(NguoiTimViecDTO newrecord)
        {
            NguoiTimViecDAO dao = new NguoiTimViecDAO();
            if (dao.ConnectToSQLServer())
            {
                return dao.Insert(newrecord);
            }
            return false;
        }
    }
}
