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
using WebPage_F4.Feed;
using WebPage_F4.UserControl;
using System.Text;
using System.Collections.Generic;

namespace WebPage_F4
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IsLogin"] = 0;
            
            //TimViecNhanh.com
            List<Article> list = GetFeed.getTimViecNhanh();

            Label ltemp = new Label();
            HyperLink htemp = new HyperLink();

            ltemp = (Label)uc_Feed1.FindControl("Label1");
            ltemp.Text = list[0].desc;
            htemp = (HyperLink)uc_Feed1.FindControl("HyperLink1");
            htemp.Text = list[0].title;
            htemp.NavigateUrl = list[0].link;

            ltemp = (Label)uc_Feed1.FindControl("Label2");
            ltemp.Text = list[1].desc;
            htemp = (HyperLink)uc_Feed1.FindControl("HyperLink2");
            htemp.Text = list[1].title;
            htemp.NavigateUrl = list[1].link;

            ltemp = (Label)uc_Feed1.FindControl("Label3");
            ltemp.Text = list[2].desc;
            htemp = (HyperLink)uc_Feed1.FindControl("HyperLink3");
            htemp.Text = list[2].title;
            htemp.NavigateUrl = list[2].link;


            //ChonViec.com
            list = GetFeed.getChonViec();

            ltemp = (Label)uc_Feed2.FindControl("Label1");
            ltemp.Text = list[0].desc;
            htemp = (HyperLink)uc_Feed2.FindControl("HyperLink1");
            htemp.Text = list[0].title;
            htemp.NavigateUrl = list[0].link;

            ltemp = (Label)uc_Feed2.FindControl("Label2");
            ltemp.Text = list[1].desc;
            htemp = (HyperLink)uc_Feed2.FindControl("HyperLink2");
            htemp.Text = list[1].title;
            htemp.NavigateUrl = list[1].link;

            ltemp = (Label)uc_Feed2.FindControl("Label3");
            ltemp.Text = list[2].desc;
            htemp = (HyperLink)uc_Feed2.FindControl("HyperLink3");
            htemp.Text = list[2].title;
            htemp.NavigateUrl = list[2].link;


            //KiemViec.com
            list = GetFeed.getKiemViec();

            ltemp = (Label)uc_Feed3.FindControl("Label1");
            ltemp.Text = list[0].desc;
            htemp = (HyperLink)uc_Feed3.FindControl("HyperLink1");
            htemp.Text = list[0].title;
            htemp.NavigateUrl = list[0].link;

            ltemp = (Label)uc_Feed3.FindControl("Label2");
            ltemp.Text = list[1].desc;
            htemp = (HyperLink)uc_Feed3.FindControl("HyperLink2");
            htemp.Text = list[1].title;
            htemp.NavigateUrl = list[1].link;

            ltemp = (Label)uc_Feed3.FindControl("Label3");
            ltemp.Text = list[2].desc;
            htemp = (HyperLink)uc_Feed3.FindControl("HyperLink3");
            htemp.Text = list[2].title;
            htemp.NavigateUrl = list[2].link;
            
        }
    }
}
