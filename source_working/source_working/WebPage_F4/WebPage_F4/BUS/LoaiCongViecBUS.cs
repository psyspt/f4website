using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiCongViecBUS
    {
        public int Insert(LoaiCongViecDTO newrecord)
        {
            LoaiCongViecDAO dao = new LoaiCongViecDAO();
            return dao.Insert(newrecord);
        }

        public int GetIDLoaiCV(LoaiCongViecDTO record)
        {
            LoaiCongViecDAO dao = new LoaiCongViecDAO();
            return dao.GetIDLoaiCV(record);
        }   
    }
}
