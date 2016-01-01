using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;
using System.Data;
using System.Text;

public partial class mar1 : System.Web.UI.MasterPage
{
    public string tel, fax, email, qq, msn, skype, lxr, addr, mobilep, addr2, tel2, beian, name2, zip, content;
    protected void Page_Load(object sender, EventArgs e)
    {
        ContactUs();
    }



    public void ContactUs()//联系我们
    {
        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select * from Information where LanauageId=1", null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            tel = "" + Convert.ToString(dr["tel"]);
            addr = "" + Convert.ToString(dr["addr"]);
            qq = "" + Convert.ToString(dr["qq"]);
            lxr = Convert.ToString(dr["lxr"]);
            mobilep = "" + Convert.ToString(dr["mobilep"]);
            email = "" + Convert.ToString(dr["email"]);
            beian = Convert.ToString(dr["beian"]);
            name2 = Convert.ToString(dr["name2"]);
            zip = Convert.ToString(dr["zip"]);
            fax = Convert.ToString(dr["fax"]);
        }

    }

    /// <summary>
    /// 大图特效
    /// </summary>
    /// <returns></returns>
    public string returnpics()
    {
        StringBuilder sbr = new StringBuilder();
        StringBuilder sbr2 = new StringBuilder();
        int i = 0;
        string sql = "select id,stitle,weburl,spic from MainPic order by id ";
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            ++i;
            if (i == 1)
                sbr.Append("<div class='event-item' style='display: block;'>");
            else
                sbr.Append("<div class='event-item' style='display: none;'>");

            sbr.Append(@"
                            <a target='_blank' href='"+Convert.ToString(dr["weburl"])+@"' class='banner'>
                                <img src='pic/" + Convert.ToString(dr["spic"]) + @"' class='photo' alt='"+Convert.ToString(dr["stitle"])+@"' />
                            </a>
                        </div>");
            sbr2.Append(" <a href='#' onclick='return false;' class='current'>"+i+"</a> ");
        }
        sbr.Append("<div class='switch-tab'>");
        if(sbr2.Length!=0)
            sbr.Append(sbr2.ToString());
        sbr.Append("</div>");
        return (sbr.Length==0)?"":sbr.ToString();
    }


    public string protype()
    {
        StringBuilder sbr = new StringBuilder();
        string sql = "select id, clsname from productType where parid<>0 order by sortid,id";
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        int i = 0;
        string disp = "none";
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(" <li><a href='yanchushow.aspx?id="+dr[0]+"'>" + Convert.ToString(dr["clsname"]) + "</a></li>");
        }
        return sbr.ToString();
    }

    public string returnNews(int ntype)
    {
        StringBuilder sbr = new StringBuilder();
        string sql = "select id, Title from News where parid="+ntype+"";
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(" <li><a href='news.aspx?id=" + dr[0] + "'>" + Convert.ToString(dr["clsname"]) + "</a></li>");
        }
        return sbr.ToString();
    }
}
