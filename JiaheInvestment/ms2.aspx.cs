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

public partial class ms2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request["pars"] != null)
        {
            Response.Clear();
            string[] cc = Request["pars"].Split('-');
            string mz = cc[0].ToString().Trim();
            string sex = cc[1].ToString().Trim();
            string message = null;
            try
            {
                string sql = "insert into GuessBook(Title,Content,email,RealName,Tel,LanguageId,createDate,pos,address)values('" + cc[0] + "','" +
                    cc[1] + "','" + cc[2] + "','" + cc[3] + "','" + cc[4] + "','" + cc[7] + "','" + DateTime.Now.ToString() + "','" + cc[5] + "','" + cc[6] + "')";
                if (Public2.Igs(sql))
                {
                    message = "Congratulations!!";
                }
                else
                {
                    message = "Sorry,you lose!!";
                }
                Response.Write(message.ToString());
            }
            catch (Exception ee)
            {
                Response.Write(ee.ToString());
            }
        }
        else
        {
            Response.Write("empty!!");
        }

    }
}
