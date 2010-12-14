using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiUngVienBUS
    {
        public void insert(LoaiUngVienDTO newrecord)
        {
            LoaiUngVienDAO dao = new LoaiUngVienDAO();
            dao.Insert(newrecord);
        }
        public int GetIDLoaiUV(LoaiUngVienDTO record)
        {
            LoaiUngVienDAO dao = new LoaiUngVienDAO();
            return dao.GetIDUNgVien(record);
        }
        public List<LoaiUngVienDTO> GetAllRecord()
        {
            LoaiUngVienDAO dao = new LoaiUngVienDAO();
            return dao.GetAllRecord();
        }

        public List<String> GetNganhNghe()
        {
            LoaiUngVienDAO dao1 = new LoaiUngVienDAO();
            return dao1.GetNganhNghe();
        }

        public List<String> GetBangCap()
        {
            LoaiUngVienDAO dao2 = new LoaiUngVienDAO();
            return dao2.GetBangCap();
        }

        public List<String> GetCapBac()
        {
            LoaiUngVienDAO dao3 = new LoaiUngVienDAO();
            return dao3.GetCapBac();
        }
    }
}
