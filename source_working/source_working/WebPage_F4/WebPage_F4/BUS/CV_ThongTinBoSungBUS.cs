using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WebPage_F4.DTO;
using WebPage_F4.DAO;
namespace WebPage_F4.BUS
{
    public class CV_ThongTinBoSungBUS
    {
        public int Insert(CV_ThongTinBoSungDTO record)
        {
            CV_ThongTinBoSungDAO dao = new CV_ThongTinBoSungDAO();
            return dao.Insert(record);
        }
    }
}
