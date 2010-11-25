using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WebPage_F4.Feed
{
    public class Article
    {
        public string title;
        public string link;
        public string desc;

        public Article()
        {
            title = "";
            link = "";
            desc = "";
        }
    }
}
