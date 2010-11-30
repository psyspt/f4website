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
using System.Net.Mail;

namespace WebPage_F4.UserControl
{
    public partial class uc_FormDangKiNhaTuyenDung : System.Web.UI.UserControl
    {
        private static int CaptchaID;
        public string RamdomURL(object sender, EventArgs e)
        {
            string Url = "../CaptchaImg/Captcha";
            Random rand = new Random();
            CaptchaID = int.Parse(rand.Next(1, 20).ToString());
            Url += CaptchaID.ToString() + ".jpg";
            return Url;
        }
        public void SendMail(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("ptudwebf4@gmail.com", "th200701");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            string strname = username.Text;

            try
            {
                mail.From = new MailAddress("ptudwebf4@gmail.com", "Mail xác nhận đăng ký", System.Text.Encoding.UTF8);
                mail.To.Add(username.Text);
                mail.Subject = "Xác nhận đăng ký";
                mail.IsBodyHtml = true;

                string strlink = "<a href = " + "http://localhost:49865/XacNhanDangKy.aspx?username=" + strname + " > http://localhost:49865/XacNhanDangKy.aspx?username=" + strname + "</a>";
                mail.Body = "Hello! " + strname + "</br> <p>Bạn đã đăng ký vào website Tìm Việc </p>"
                            + "</br><p>Click vào link liên kết sau để hoàn tất đăng ký:</p>"
                            + strlink;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaptchaImg.ImageUrl = RamdomURL(sender, e);
            }
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
            CaptchaBUS buscaptcha = new CaptchaBUS();
            string CaptchaStr = buscaptcha.GetString(CaptchaID);
           
            if (xacNhanCaptchar.Text.ToString().Equals(CaptchaStr, StringComparison.OrdinalIgnoreCase))
            {
                string strname = username.Text;
                //Begin 'Luu vao data base'
                NhaTuyenDungBUS bus = new NhaTuyenDungBUS();
                NhaTuyenDungDTO dto = new NhaTuyenDungDTO();
                dto.DiaChi = diaChi.Text;
                dto.Email = username.Text;
                dto.LinhVuc = int.Parse(nganhNghe.SelectedValue);
                dto.TenCongTy = tenCongTy.Text;
                dto.MoTa = TextBox1.Text;
                dto.Password = password.Text;

                //End 'Luu vai database'
                int result = bus.Insert(dto);
                if (result!=0)//success
                {
                      //gui mail xac nhan
                        SendMail(sender, e);
                      //redirect den trang bao thanh cong
                        Response.Redirect("../DangKi/DangKiTaiKhoanNhaTuyenDung.aspx?AddUser=" + strname);
                }
                else
                {
                    //redirect den trang bao loi
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            CaptchaImg.ImageUrl = RamdomURL(sender, e);
        }
    }
}