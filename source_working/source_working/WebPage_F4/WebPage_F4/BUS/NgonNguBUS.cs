using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NgonNguBUS
    {
        public List<NgonNguDTO> GetAllRecord()
        {
            NgonNguDAO dao = new NgonNguDAO();
            return dao.GetAllRecord();
        }
    }
}
