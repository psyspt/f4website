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
using System.IO;

namespace WebPage_F4.UserControl
{
    public partial class uc_UploadCV : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butUploadCV_Click(object sender, EventArgs e)
        {
            if (FileInput.PostedFile != null)
            {
                HttpPostedFile postedFile = FileInput.PostedFile;

                int nFileLen = postedFile.ContentLength;

                if (nFileLen > 0)
                {
                    byte[] dataFile = new byte[nFileLen];
                    postedFile.InputStream.Read(dataFile, 0, nFileLen);
                    string FileName = postedFile.FileName;
                    FileStream newFile = new FileStream(Server.MapPath(FileName), FileMode.Create);
                    newFile.Write(dataFile, 0, nFileLen);
                    newFile.Close();
                }
            }
            
        }
    }
}