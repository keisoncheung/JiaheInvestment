<%@ Page Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 746px; float:right;">
                    <div class="cen_nei_div">
                        <div class="cen_nei_div_top">
                             <%=stitle()%>
                        </div>
                        <div class="cen_nei_div_mid">
                            <div style=" width:100%; margin:0 auto;" class="centerspan"> 
                            <table cellpadding="3" cellspacing="4" border="0" style="table-layout: fixed; word-break: break-all; margin-bottom: 0px; width:100%;">
                <%=New_list%>
            </table><br />
            <%=Page_Text%>
            </div>
                        </div>
                    </div>
                  
                </div>
</asp:Content>


