using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class TinhThanhBUS
    {
        public List<TinhThanhDTO> GetAllRecord()
        {
            TinhThanhDAO dao = new TinhThanhDAO();
            if (dao.ConnectToSQLServer())
            {
                return dao.GetAllRecord();
            }
            return null;
        }
    }
}
