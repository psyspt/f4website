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
namespace WebPage_F4.DangNhap
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dangNhapNguoiTimViec_Click(object sender, EventArgs e)
        {
            //chua check SQL injection + chua Ma hoa pass
            string username = userNguoiTimViec.Text;
            string password = passNguoiTimViec.Text;
            NguoiTimViecBUS bus = new NguoiTimViecBUS();
            NguoiTimViecDTO user = bus.SelectByusername(username);
            if (user != null)
            {
                if (user.PassWord == password)
                {
                    //dang nhap thanh cong
                }
            }
        }

        protected void dangNhapNhaTuyenDung_Click(object sender, EventArgs e)
        {
            //chua check SQL injection + chua Ma hoa pass
            string email = userNhaTuyenDung.Text;
            string password = passNhaTuyenDung.Text;
            NhaTuyenDungBUS bus = new NhaTuyenDungBUS();
            NhaTuyenDungDTO user = bus.SelectByEmail(email);
            if (user != null)
            {
                if (user.Password == password)
                {
                    //dang nhap thanh cong
                }
            }
        }
    }
}
