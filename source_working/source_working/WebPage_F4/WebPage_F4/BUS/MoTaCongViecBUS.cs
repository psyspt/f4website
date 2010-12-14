using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class MoTaCongViecBUS
    {
        public int Insert(MoTaCongViecDTO newrecord)
        {
            MoTaCongViecDAO dao = new MoTaCongViecDAO();
            return dao.Insert(newrecord);
        }       
    }
}
