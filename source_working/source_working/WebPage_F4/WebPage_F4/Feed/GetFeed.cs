using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;

namespace WebPage_F4.Feed
{
    public class GetFeed
    {
        public static List<Article> getTimViecNhanh()
        {
            List<Article> list = new List<Article>();

            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument hd = hw.Load("http://www.timviecnhanh.com/");
            HtmlNode hn = hd.DocumentNode;
            HtmlNode parentNode = hd.DocumentNode.SelectSingleNode(".//div[@id='certifiedjobs']");
            HtmlNodeCollection anode = parentNode.SelectNodes(".//td");
            StringBuilder sb = new StringBuilder();

            int count = 0;

            foreach (HtmlNode hnode in anode)
            {
                HtmlNode artnode = hnode.SelectSingleNode(".//div[@class='itemjob']");
                string title = artnode.SelectSingleNode(".//a").Attributes[1].Value.Trim();
                string link = "http://www.timviecnhanh.com/" + artnode.SelectSingleNode(".//a").Attributes[0].Value.Trim();
                string desc = hnode.SelectSingleNode(".//div[@class='employername']").InnerText.Trim();

                Article arttemp = new Article();
                arttemp.title = title;
                arttemp.link = link;
                arttemp.desc = desc;
                list.Add(arttemp);

                count++;
                if (count == 3)
                    break;
            }

            return list;
        }

        public static void getTimViec24h()
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument hd = hw.Load("http://timviec24h.vn/");
            HtmlNode hn = hd.DocumentNode;
            HtmlNode parentNode = hd.DocumentNode.SelectSingleNode(".//table[@id='tblCongViecMoi']");
            HtmlNodeCollection anode = parentNode.SelectNodes(".//td//tr");
            StringBuilder sb = new StringBuilder();

            foreach (HtmlNode hnode in anode)
            {
                HtmlNode artnode = hnode.SelectSingleNode(".//td");
                string title = artnode.SelectSingleNode(".//a").InnerText.Trim();
                string link = "http://timviec24h.vn/" + artnode.SelectSingleNode(".//a").Attributes[1].Value.Trim();

                sb.Append("<font face='arial'><p><b><a href='");
                sb.Append(link);
                sb.Append("'>");
                sb.Append(title);
                sb.Append("</a></b></p></font>");
            }

            FileStream fileStream = new FileStream("./RSSTimViec24h.html", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, UnicodeEncoding.UTF8);
            streamWriter.Write(sb.ToString());
            streamWriter.Close();
            fileStream.Close();
        }

        public static List<Article> getChonViec()
        {
            List<Article> list = new List<Article>();

            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument hd = hw.Load("http://www.chonviec.com/");
            HtmlNode hn = hd.DocumentNode;
            HtmlNode parentNode = hd.DocumentNode.SelectSingleNode(".//div[@class='new-job-content']");
            HtmlNodeCollection anode = parentNode.SelectNodes(".//ul//li");
            StringBuilder sb = new StringBuilder();

            int count = 0;

            foreach (HtmlNode hnode in anode)
            {
                string temp = hnode.SelectSingleNode(".//a[@class='linkblack2']").Attributes[2].Value.Trim();
                int i = temp.IndexOf("-");
                string title = temp.Substring(0, i).Trim();
                string desc = temp.Substring(i + 2).Trim();
                string link = hnode.SelectSingleNode(".//a[@class='linkblack2']").Attributes[0].Value.Trim();

                Article arttemp = new Article();
                arttemp.title = title;
                arttemp.link = link;
                arttemp.desc = desc;
                list.Add(arttemp);

                count++;
                if (count == 3)
                    break;
            }

            return list;
        }

        public static List<Article> getKiemViec()
        {
            List<Article> list = new List<Article>();
            
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument hd = hw.Load("http://www.kiemviec.com/");
            HtmlNode hn = hd.DocumentNode;
            HtmlNode parentNode = hd.DocumentNode.SelectSingleNode(".//div[@id='cont1']");
            HtmlNodeCollection anode = parentNode.SelectNodes(".//ul//li");
            StringBuilder sb = new StringBuilder();

            int count = 0;

            foreach (HtmlNode hnode in anode)
            {
                string title = hnode.SelectSingleNode(".//a").Attributes[1].Value.Trim();
                string link = hnode.SelectSingleNode(".//a").Attributes[0].Value.Trim();
                string desc = hnode.SelectSingleNode(".//a[@class='c_o']").InnerText.Trim();

                Article arttemp = new Article();
                arttemp.title = title;
                arttemp.link = link;
                arttemp.desc = desc;
                list.Add(arttemp);

                count++;
                if (count == 3)
                    break;
            }

            return list;
        }
    }
}
