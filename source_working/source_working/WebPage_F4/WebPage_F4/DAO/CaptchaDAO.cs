using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CaptchaDAO
    {
        #region Receive
        public String GetCaptchaString(int ID)
        {
            SqlConnection connect = new SqlConnection(SqlDataAccess.ConnectionString);
            connect.Open();

            StringBuilder command = new StringBuilder();
            command.Append("select * from CAPTCHA where ID='");
            command.Append(ID);
            command.Append("'");
            SqlCommand cmd = new SqlCommand(command.ToString(), connect);
            SqlDataReader r = cmd.ExecuteReader();
            CaptchaDTO returnrecord = new CaptchaDTO();
            r.Read();
            object[] obj = new object[2];
            r.GetValues(obj);

            //returnrecord.ID = int.Parse(obj[0].ToString());
            returnrecord.CaptchaString = obj[1].ToString().TrimEnd(' ');

            connect.Close();
            return returnrecord.CaptchaString;
        }
        #endregion
    }
}
