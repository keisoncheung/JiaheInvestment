using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;
using System.Text;
using System.Data;

public partial class index : System.Web.UI.Page
{
    public string tel, fax, email, qq, msn, skype, lxr, addr, mobilep, addr2, tel2, beian, name2, zip, content;
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public string sintro(int id)
    {

        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select title,content1 from Article Where Id=" + id + "", null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(Convert.ToString(dr["content1"]));
        }
        dt.Dispose();
        return sbr.ToString();
    }

    public string return_news(int parid, int topindex)
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top " + topindex + " id, title,parid,linkpic,createdate from news where parid=" + parid + " order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='news.aspx?key=" + dr["parid"] + "&mu=6&nid=" + dr["id"] + "'title='" + dr["title"] + "'><img src='pic/" + dr["linkpic"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='news.aspx?key=" + dr["parid"] + "&mu=6&nid=" + dr["id"] + "'title='" + dr["title"] + "'>" + title + "</a></li></ul></div></td> ");
            sbr.Append(@"<dl>
                                <dt></dt><dd><a href='news.aspx?key=" + dr["parid"] + "&mu=6&nid=" + dr["id"] + "'title='" + dr["title"] + "'>·" + dr["title"] + "</a></dd></dl>");



        }
        return sbr.ToString();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string return_Friends()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 6 id, Title,LinkUrl from Links  order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='news.aspx?key=" + dr["parid"] + "&mu=6&nid=" + dr["id"] + "'title='" + dr["title"] + "'><img src='pic/" + dr["linkpic"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='news.aspx?key=" + dr["parid"] + "&mu=6&nid=" + dr["id"] + "'title='" + dr["title"] + "'>" + title + "</a></li></ul></div></td> ");
            sbr.Append(@" <dl>
                                <dt></dt><dd><a href='" + dr["LinkUrl"] + "'title='" + dr["title"] + "' target='_blank'>·" + dr["title"] + "</a></dd></dl>");



        }
        return sbr.ToString();

    }


    public string pro()
    {
        StringBuilder Html = new StringBuilder();
        string sql = "select top 12 id,pictures,proname,Promode,Procolor,ProSize from product where grade=1 order by txtsortid desc,id desc";
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        string title;
        if (dt.Rows.Count > 0)
        {
            int i = 1;

            foreach (DataRow dr in dt.Select())
            {
                Html.Append("<ul class='productul'><li class='productul_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'><img src='pic/" + dr["PictureS"] + "' alt='" + dr["proname"] + "' /></a> </li><li class='productul_li2'>Model：" + dr["proname"] + "</li></ul>");
                i++;
            }
            dt.Dispose();

        }
        return Html.ToString();
    }

    public string index_case_list()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 10 id, ProName,PictureS from product where grade=1 order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["ProName"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li></ul></div></td> ");

            sbr.Append("<li><div class='pic'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></div><div class='title'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></div></li>");


        }
        return sbr.ToString();



    }

}
