using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class DanhSachCongViecBUS
    {
        public List<DanhSachCOngViecDTO> GetDSCVbyUsername(string username)
        {
            DanhSachCongViecDAO dao = new DanhSachCongViecDAO();
            return dao.GetDSCV(username);
        }

    }
}
