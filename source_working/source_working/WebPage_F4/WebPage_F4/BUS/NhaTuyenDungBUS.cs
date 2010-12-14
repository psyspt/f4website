using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NhaTuyenDungBUS
    {
        public int Insert(NhaTuyenDungDTO newrecord)
        {
            NhaTuyenDungDAO dao = new NhaTuyenDungDAO();            
            return dao.Insert(newrecord);
        }

        public NhaTuyenDungDTO SelectByEmail(string email)
        {
            NhaTuyenDungDAO dao = new NhaTuyenDungDAO();
            return dao.SelectByEmail(email);
        }
        public int GetIDNhaTuyenDung(string email)
        {
            NhaTuyenDungDAO dao = new NhaTuyenDungDAO();
            int ID = dao.GetIDNhaTuyenDung(email);
            return ID;
        }
    }
}
