﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WebPage_F4.DangKi
{
    public partial class DangKiTaiKhoanNhaTuyenDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uc_ThongBao1.Visible = false;
            if (Request.QueryString["AddUser"] != null)
            {
                uc_FormDangKiNhaTuyenDung1.Visible = false;
                uc_ThongBao1.Visible = true;
            }
        }
    }
}
