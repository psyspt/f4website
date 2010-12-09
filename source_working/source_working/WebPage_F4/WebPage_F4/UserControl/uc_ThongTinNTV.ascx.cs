using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

namespace WebPage_F4.UserControl
{
    public partial class uc_ThongTinNTV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NguoiTimViecDTO nguoitimviec = new NguoiTimViecDTO();

            NguoiTimViecBUS bus = new NguoiTimViecBUS();

            nguoitimviec = bus.SelectByusername("vanc");

            List<NguoiTimViecDTO> ls = new List<NguoiTimViecDTO>();
            ls.Add(nguoitimviec);
       
            DetailsNTV.DataSource = ls;

            DetailsNTV.DataBind();
        }

    }
}