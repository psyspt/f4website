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
using System.Collections.Generic;
namespace WebPage_F4.UserControl
{
    public partial class uc_FormDangKiNhaTuyenDung : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            List<ListItem> alllistitem = new List<ListItem>();
            
            List<NganhNgheDTO> allrecordNganhNghe = new List<NganhNgheDTO>();
            NganhNgheBUS busNN = new NganhNgheBUS();
            allrecordNganhNghe = busNN.GetAllRecord();
            alllistitem = new List<ListItem>();
            for (int j = 0; j < allrecordNganhNghe.Count; j++)
            {
                alllistitem.Add(new ListItem(allrecordNganhNghe[j].TenNganhNghe, allrecordNganhNghe[j].ID.ToString()));
                nganhNghe.Items.Add(alllistitem[j]);
            }

        }

     

        protected void Button1_Click1(object sender, EventArgs e)
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