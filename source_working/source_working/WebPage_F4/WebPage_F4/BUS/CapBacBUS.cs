using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class CapBacBUS
    {
        public List<CapBacDTO> GetAllRecord()
        {
            CapBacDAO dao = new CapBacDAO();
            return dao.GetAllRecord();
        }
    }
}
