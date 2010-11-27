using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage_F4.DangKi
{
    public partial class DangKiTaiKhoanNguoiTimViec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uc_ThongBao1.Visible = false;
            if (Request.QueryString["AddUser"] != null)
            {
                uc_FormDangKiNguoiTimViec1.Visible = false;
                uc_ThongBao1.Visible = true;
            }
        }
    }
}
