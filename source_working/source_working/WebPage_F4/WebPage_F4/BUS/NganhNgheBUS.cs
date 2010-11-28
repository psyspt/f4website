using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class NganhNgheBUS
    {
        public List<NganhNgheDTO> GetAllRecord()
        {
            NganhNgheDAO dao = new NganhNgheDAO();
            return dao.GetAllRecord();
        }
    }
}
