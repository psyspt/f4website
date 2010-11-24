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
            //kiểm tra người dùng đã click vào link xác nhân chưa
            if (Request.QueryString["username"] != null)
            {
                //lưu xuống csdl người dùng đã kích hoạt 
            }
        }
    }
}
