using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class QuocGiaBUS
    {
        public List<QuocGiaDTO> GetAllRecord()
        {
            QuocGiaDAO dao = new QuocGiaDAO();
            return dao.GetAllRecord();
        }
    }
}
