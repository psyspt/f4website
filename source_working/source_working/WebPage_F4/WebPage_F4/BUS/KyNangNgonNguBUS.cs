using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class KyNangNgonNguBUS
    {
        public List<KyNangNgonNguDTO> GetAllRecord()
        {
            KyNangNgonNguDAO dao = new KyNangNgonNguDAO();
            return dao.GetAllRecord();
        }
    }
}
