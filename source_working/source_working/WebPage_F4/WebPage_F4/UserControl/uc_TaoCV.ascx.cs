using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DTO;
using BUS;
namespace WebPage_F4.UserControl
{
    public partial class uc_TaoCV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["ID"].ToString();
            NguoiTimViecBUS bus = new NguoiTimViecBUS();
            NguoiTimViecDTO user = bus.SelectByusername(username);
            tbxThongTin_Email.Value = user.EMail;
            tbxThongTin_HoTen.Value = user.HoTen;
        }

        protected void butCV_Click(object sender, EventArgs e)
        {
            //
        }
    }
}