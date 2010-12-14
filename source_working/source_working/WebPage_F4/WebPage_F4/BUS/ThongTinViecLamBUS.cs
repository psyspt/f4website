using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class ThongTinViecLamBUS
    {
        public int Insert(ThongTinViecLamDTO newrecord)
        {
            ThongTinViecLamDAO dao = new ThongTinViecLamDAO();
            return dao.Insert(newrecord);
        }
    }
}
