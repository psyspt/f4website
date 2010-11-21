﻿using System;
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
using System.Web.Mail;

namespace WebPage_F4.UserControl
{
    public class CaptchaProvider : Page
    {
        private int rrandom = 0;
        private int grandom = 0;
        private int brandom = 0;
        private string name = "NoruleCaptcha";
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public CaptchaProvider()
        {

        }
        public string CreateCaptcha()
        {
            string[] fonts = { "Counier New", "Comic Sans MS", "Times New Roman", "Tahoma" };

            const byte LENGTH = 5;

            // chiều dài chuỗi để lấy các kí tự sẽ sử dụng cho captcha

            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            using (Bitmap bmp = new Bitmap(120, 35))
            {

                using (Graphics g = Graphics.FromImage(bmp))
                {

                    // Tạo nền cho ảnh dạng sóng

                    HatchBrush brush = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.White, Color.Tan);

                    g.FillRegion(brush, g.Clip);

                    // Lưu chuỗi captcha trong quá trình tạo

                    StringBuilder strCaptcha = new StringBuilder();

                    Random rand = new Random();
                    float locationX = 3;
                    for (int i = 0; i < LENGTH; i++)
                    {

                        // Lấy kí tự ngẫu nhiên từ mảng chars

                        SolidBrush brushes = new SolidBrush(GetRandomColor());

                        string str = chars[rand.Next(chars.Length)].ToString();

                        strCaptcha.Append(str);

                        // Tạo font với tên font ngẫu nhiên chọn từ mảng fonts

                        Font font = new Font(fonts[rand.Next(fonts.Length)], new Random().Next(14, 17), FontStyle.Bold | FontStyle.Italic);

                        // Lấy kích thước của kí tự

                        SizeF size = g.MeasureString(str, font);
                        // Vẽ kí tự đó ra ảnh tại vị trí tăng dần theo i, vị trí top ngẫu nhiên

                        g.DrawString(str, font, brushes, locationX, rand.Next(2, 10));

                        font.Dispose();
                        //định location X
                        locationX += size.Width + i;

                    }

                    // Lưu captcha vào session

                    Session["captcha"] = strCaptcha.ToString();

                    // Ghi ảnh trực tiếp ra luồng xuất theo định dạng gif
                    //Response.ContentType = "image/GIF";4
                    int numRandom = new Random().Next(1, 3000);
                    string imgFile = "captcha" + numRandom + ".jpg";
                    string directoryCaptcha = "~/tmp/";
                    // Kiểm tra thư mục đã tồn tại
                    if (!Directory.Exists(Server.MapPath(directoryCaptcha)))
                    {
                        Directory.CreateDirectory(Server.MapPath(directoryCaptcha));

                    }
                    //lấy thông tin thư mục
                    DirectoryInfo direcInfo = new DirectoryInfo(Server.MapPath(directoryCaptcha));
                    foreach (FileInfo file in direcInfo.GetFiles(".jpg"))
                    {
                        try
                        {
                            //Xóa tất cả các tập tin hình trong thư mục hiện tại
                            file.Delete();
                        }
                        catch { }
                    }
                    bmp.Save(Server.MapPath(directoryCaptcha + imgFile));
                    return directoryCaptcha + imgFile;
                }
            }
        }
        public Color GetRandomColor()
        {
            Random rnd = new Random();
            int ri = rnd.Next(255);
            if (ri == rrandom)
            { ri = rnd.Next(255); }
            else { rrandom = ri; }

            int gi = rnd.Next(255);
            if (gi == grandom)
            { gi = rnd.Next(255); }
            else { grandom = gi; }

            int bi = rnd.Next(255);
            if (bi == brandom)
            { bi = rnd.Next(255); }
            else { brandom = bi; }

            byte r = Convert.ToByte(ri);
            byte g = Convert.ToByte(gi);
            byte b = Convert.ToByte(bi);
            return Color.FromArgb(r, g, b);
        }
    }

    public partial class uc_Register_Nguoi_Tim_Viec : System.Web.UI.UserControl
    {
        CaptchaProvider captcha = new CaptchaProvider();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                captchaImage.ImageUrl = captcha.CreateCaptcha();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            captchaImage.ImageUrl = captcha.CreateCaptcha();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (CaptchaText.Text.ToString().Equals(Session["captcha"].ToString(), StringComparison.OrdinalIgnoreCase))
            {
                //code luu du lieu
            }
            else
            {
                //bao loi
            }

        }
    }
}