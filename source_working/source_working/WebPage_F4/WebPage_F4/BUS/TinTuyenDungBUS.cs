﻿using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class TinTuyenDungBUS
    {
        public int Insert(TinTuyenDungDTO newrecord)
        {
            TinTuyenDungDAO dao = new TinTuyenDungDAO();
            return dao.Insert(newrecord);
        }
    }
}
