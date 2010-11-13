using System;
using System.Data;
using System.Configuration;
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
    public class ThemeManager
    {

        public static List<Theme> GetThemes()
        {
            DirectoryInfo dInfo = new DirectoryInfo(System.Web.HttpContext.Current.Server.MapPath("App_Themes"));
            DirectoryInfo[] dArrInfo = dInfo.GetDirectories();
            List<Theme> list = new List<Theme>();

            foreach (DirectoryInfo d in dArrInfo)
            {
                Theme temp = new Theme(d.Name);
                list.Add(temp);
            }

            return list;
        }

    }
}
