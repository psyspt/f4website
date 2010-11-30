using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage_F4
{
    public partial class XacNhanDangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["username"] != null)
            {
                // Lưu đã kích hoạt với username là Request.QueryString["username"]

            }
        }
    }
}
