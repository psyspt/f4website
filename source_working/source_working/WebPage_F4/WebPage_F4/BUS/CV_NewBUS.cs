﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WebPage_F4.DTO;
using WebPage_F4.DAO;
namespace WebPage_F4.BUS
{
    public class CV_NewBUS
    {
        public int Insert(CV_NewDTO record)
        {
            CV_NewDAO dao = new CV_NewDAO();
            return dao.Insert(record);
        }
    }
}
