using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Text;
using System.Net.Mail;
using DTO;
using BUS;
using System.Collections.Generic;

namespace WebPage_F4.UserControl
{
    public partial class uc_Register_Nguoi_Tim_Viec : System.Web.UI.UserControl
    {
        private static int ID;
        protected string RamdomURL(object sender, EventArgs e)
        {
            string Url = "../CaptchaImg/Captcha";
            Random rand = new Random();
            ID = rand.Next(1, 20);
            Url += ID + ".jpg";
            return Url;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                captchaImage.ImageUrl = RamdomURL(sender, e);
            }
            List<TinhThanhDTO> allrecord = new List<TinhThanhDTO>();
            TinhThanhBUS bus = new TinhThanhBUS();
            allrecord = bus.GetAllRecord();
            for (int i = 0; i < allrecord.Count; i++)
            {
                ListItem li = new ListItem(allrecord[i].TenTinhThanh, allrecord[i].ID.ToString());
                ThanhPho.Items.Add(li);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            captchaImage.ImageUrl = RamdomURL(sender, e);
        }

        public void SendMail(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("ptudwebf4@gmail.com", "th200701");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            string strname = Username.Text;

            try
            {
                mail.From = new MailAddress("ptudwebf4@gmail.com", "Mail xác nhận đăng ký", System.Text.Encoding.UTF8);
                mail.To.Add(Email.Text);
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
        
        protected void Button1_Click(object sender, EventArgs e)
        {
                   
            string username = Username.Text;
            CaptchaBUS buscaptcha = new CaptchaBUS();
            string CaptchaStr = buscaptcha.GetString(ID);
            if (CaptchaText.Text.ToString().Equals(CaptchaStr, StringComparison.OrdinalIgnoreCase))
            {
                //Lưu dữ liệu
                NguoiTimViecDTO newrecord = new NguoiTimViecDTO();
                newrecord.TrangThai = 1;
                newrecord.HoTen = Ho.Text + " " + Ten.Text;
                if (gioitinh.SelectedIndex == 0)
                {
                    newrecord.GioiTinh = 1;
                }
                else if (gioitinh.SelectedIndex == 1)
                {
                    newrecord.GioiTinh = 0;
                }

                newrecord.NgaySinh = DateTime.Parse(NgaySinh.Text);
                newrecord.DiaChi = DiaChi.Text;
                newrecord.DienThoai = DienThoai.Text;
                newrecord.UserName = Username.Text;
                newrecord.PassWord = Password.Text;
                newrecord.EMail = Email.Text;
                newrecord.TinhThanh = int.Parse(ThanhPho.SelectedValue);
                NguoiTimViecBUS bus = new NguoiTimViecBUS();
                int result = bus.Insert(newrecord);
                if (result !=0 )
                {
                    SendMail(sender, e);
                    //Thông báo thành công
                    Response.Redirect("../DangKi/DangKiTaiKhoanNguoiTimViec.aspx?AddUser=" + username);
                }
                else
                {
                    //redirect den trang bao loi
                }
            }
            else
            {
                //redirect den trang bao loi
            }
        }
    }
}