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
using System.Text;
using DLL;

public partial class messages : System.Web.UI.Page
{
    private string page_text = "";
    private int RecordPerPage = 3;//每页显示行数
    protected System.Web.UI.HtmlControls.HtmlTableRow ttr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.ViewState["CurrentPg"] = 1;
        }
    }
    private string Ini()
    {
        StringBuilder sbr = new StringBuilder();
        string nid = Request["nid"] + "";
        string ntype = Request["type"] + "";
        string where = " where languageId=1";
        if (ntype.Length > 1)
        {
            where = " where languageId=1";
        }
        ViewState["max_c"] = OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select count(Id) from GuessBook" + where, null);
        ViewState["MaxPg"] = Convert.ToString(System.Math.Ceiling(Convert.ToDouble(Convert.ToInt32(Convert.ToString(ViewState["max_c"])) / Convert.ToDouble(this.RecordPerPage))));
        if (Request["pg"] != null)
        {
            ViewState["CurrentPg"] = Request["pg"] + "";
        }
        else
        {
            ViewState["CurrentPg"] = 1;
        }
        tpate();
        int StartNum = Convert.ToInt32(ViewState["CurrentPg"]) * RecordPerPage;
        int intTemNum = StartNum - RecordPerPage;
        string sql = "select * from (select top " + StartNum + " Id,Title,CreateDate,parid,realname,content,feedback from GuessBook " + where + " order by Id desc) a where a.Id not in (Select top " + intTemNum + "  Id from GuessBook " + where + " order by Id desc)";
        if (intTemNum <= 0)
        {
            sql = "select top " + RecordPerPage + " Id,Title,CreateDate,parid,realname,content,feedback  from GuessBook " + where + " order by Id desc";
        }
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            string title = Convert.ToString(dr["Title"]);
            if (title.Length > 30)
            {
                title = title.Substring(0, 30) + "..";
            }
            sbr.Append(" <div style='margin:0px; width:100%;border:1px #cccccc solid; line-height:20px; list-style-type:none; '>");
            sbr.Append("<div><strong>标题：" + dr["title"] + "</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;留言人：" + dr["realname"] + "</div>");
            sbr.Append("<div><strong>内容：</strong>" + dr["content"] + "</div><div><hr size='1'></div>");
            sbr.Append("<div style='line-height:20px;height: auto !important;height: 25px; min-height: 25px;'><strong>回复内容：</strong><font style='color:red;'>" + dr["feedback"] + "</font></div>");
            sbr.Append("<div><hr size='1'></div>");
            sbr.Append("<div style='text-align:right;'>[" + DateTime.Parse(Convert.ToString(dr["CreateDate"])).ToString("yyyy-MM-dd") + "]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div></div>");
        }
        dt.Dispose();

        return sbr.ToString();
    }
    private string roadNewType(string tid)
    {
        return OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select ClsName from NewType where id=" + tid, null) + "";
    }
    #region 分页显示
    private void tpate()
    {
        string control = Convert.ToString(this.Request["pg"]);
        ViewState["CurrentPg"] = control;
        int pg, p, n = 0;
        switch (control)
        {
            case "f":
                ViewState["CurrentPg"] = 1;
                break;
            case "n":
                ViewState["CurrentPg"] = Convert.ToInt32(ViewState["CurrentPg"]) + 1;
                break;
            case "p":
                ViewState["CurrentPg"] = Convert.ToInt32(ViewState["CurrentPg"]) - 1;
                break;
            case "l":
                ViewState["CurrentPg"] = ViewState["MaxPg"];
                break;
        }
        if (Convert.ToInt32(ViewState["CurrentPg"]) < 1)
        {
            ViewState["CurrentPg"] = 1;
        }
        string urlq = turnQ();
        if (Convert.ToInt32(ViewState["MaxPg"]) > 1)
        {
            pg = Convert.ToInt32(ViewState["CurrentPg"]);
            p = ((pg - 1) >= 1) ? (pg - 1) : 1;
            n = ((pg + 1) <= Convert.ToInt32(ViewState["MaxPg"])) ? (pg + 1) : Convert.ToInt32(ViewState["MaxPg"]);
            page_text = "<div  style='text-align:right; width:712px;'><table border='0' cellspacing='0' cellpadding='0' width='40%'><tr>" +
                "<td><a style='' href='" + urlq + "&pg=1'>首页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + p + "'>上一页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + n + "'>下一页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + ViewState["MaxPg"] + "'>尾页</a></td> " +
                "<td>页次：<span style='font-weight:bold;'>" + ViewState["CurrentPg"] + "/" + ViewState["MaxPg"] + "</span>页</td> " +
                "<td width='10'></td>" +
                "</tr></table></div>";
        }
    }
    private string turnQ()
    {
        string urls = Request.Url.Query;
        string url = "";
        if (urls.IndexOf("?") >= 0)
        {
            urls = urls.Replace("?", "");
            foreach (string u in urls.Split('&'))
            {
                if (u.IndexOf("pg") == -1)
                {
                    url += "&" + u;
                }
            }
        }
        return Request.Url.AbsolutePath + "?" + url.Substring(0);
    }
    public string Page_Text
    {
        get
        {
            return (page_text != null) ? page_text : "";
        }
    }
    public string New_list
    {
        get
        {
            return Ini();
        }
    }
    #endregion
}
