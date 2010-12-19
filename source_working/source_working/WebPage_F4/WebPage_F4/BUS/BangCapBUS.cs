using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class BangCapBUS
    {
        public List<BangCapDTO> GetAllRecord()
        {
            BangCapDAO dao = new BangCapDAO();
            return dao.GetAllRecord();
        }
    }
}
