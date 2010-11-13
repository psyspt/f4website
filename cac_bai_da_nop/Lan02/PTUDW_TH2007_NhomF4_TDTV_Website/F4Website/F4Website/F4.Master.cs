using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;

namespace F4Website
{
    public partial class F4 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void choiceTheme_DataBound(object sender, EventArgs e)
        {
            choiceTheme.SelectedValue = Page.Theme;
        }

        protected void choiceTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Add("MyTheme", choiceTheme.SelectedValue);
            Server.Transfer(Request.FilePath);
        }

    }

    public class Theme
    {
        private string _name;

        // Lấy Tên.
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        // Contractor
        public Theme(string name)
        {
            Name = name;

        }
    }

    

    public class BasePage : System.Web.UI.Page
    {

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            if (Session["MyTheme"] == null)
            {
                Session.Add("MyTheme", "White");
                Page.Theme = (string)Session["MyTheme"];
            }
            else
            {
                Page.Theme = (string)Session["MyTheme"];
            }
        }
    }
}
