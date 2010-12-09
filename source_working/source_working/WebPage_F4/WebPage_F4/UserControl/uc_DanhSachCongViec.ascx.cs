using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace WebPage_F4.UserControl
{
    public partial class uc_DanhSachCongViec : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DanhSachCongViecBUS bus = new DanhSachCongViecBUS();

            List<DanhSachCOngViecDTO> ls = new List<DanhSachCOngViecDTO>();

            //string username = Session["username"];
            string username = "vanc";
            ls = bus.GetDSCVbyUsername(username);

            DanhSachCongViecList.DataSource = ls;
            DanhSachCongViecList.DataBind();
        }
    }
}