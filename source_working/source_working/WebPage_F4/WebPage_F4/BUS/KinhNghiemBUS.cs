using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class KinhNghiemBUS
    {
        public List<KinhNghiemDTO> GetAllRecord()
        {
            KinhNghiemDAO dao = new KinhNghiemDAO();
            return dao.GetAllRecord();
        }
    }
}
