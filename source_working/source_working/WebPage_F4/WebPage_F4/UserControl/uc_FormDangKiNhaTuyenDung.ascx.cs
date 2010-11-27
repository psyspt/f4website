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
using BUS;
using DTO;
using System.Collections.Generic;

namespace WebPage_F4.UserControl
{
    public partial class uc_FormDangKiNhaTuyenDung : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NganhNgheBUS bus = new NganhNgheBUS();
            List<NganhNgheDTO> allrecord = new List<NganhNgheDTO>();
            allrecord = bus.GetAllRecord();
            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecord[i].TenNganhNghe, allrecord[i].ID.ToString());
                nganhNghe.Items.Add(li);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Begin 'Luu vao data base'
            NhaTuyenDungBUS bus = new NhaTuyenDungBUS();
            NhaTuyenDungDTO dto = new NhaTuyenDungDTO();
            dto.DiaChi = diaChi.Text;
            dto.Email = username.Text;
            dto.LinhVuc = int.Parse(nganhNghe.SelectedValue);
            dto.TenCongTy = tenCongTy.Text;
            dto.MoTa = TextBox1.Text;
            dto.Password = password.Text;

            bus.Insert(dto);
            //End 'Luu vai database'
        }
    }
}