using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NhaTuyenDungBUS
    {
        public bool Insert(NhaTuyenDungDTO newrecord)
        {
            NhaTuyenDungDAO dao = new NhaTuyenDungDAO();
            if (dao.ConnectToSQLServer())
            {
                return dao.Insert(newrecord);
            }
            return false;
        }
    }
}
