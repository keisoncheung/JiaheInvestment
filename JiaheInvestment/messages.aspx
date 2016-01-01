<%@ Page Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true" CodeFile="messages.aspx.cs" Inherits="messages" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 746px; float:right;">
                    <div class="cen_nei_div">
                        <div class="cen_nei_div_top">
                             在线留言
                        </div>
                        <div class="cen_nei_div_mid">
                            <div style="margin:0px auto;width:100%;">
<%=New_list%></div>

                    <br />
                    <%=Page_Text%>
                    <div id="guestset" style=" display:; margin:20px 0px 0px 0px; ">
                            <table style="border-style: none; border-color: inherit; border-width: 0px; width: 563px; height: 298px; " 
                            cellpadding=0 cellspacing=0 align=center>
                            
     <tr><td style="width: 70px">您的姓名：</td><td><input type=text id="txtName" style="width: 162px" />&nbsp;&nbsp;&nbsp;您的邮箱：<input type=text id="email" style="width: 162px" /></td></tr>
     <tr><td style="width: 70px">联系电话：</td><td >
         <input type=text 
             id="tel" style="width: 162px" />&nbsp;&nbsp;&nbsp;邮&nbsp;&nbsp;&nbsp;&nbsp;编：<input type=text id="zip" 
             style="width: 162px" /></td></tr>
             <tr><td style="width: 70px">地址：</td><td ><input type=text id="address" 
                     style="width: 403px" /></td></tr>
     <tr><td style="width: 70px">主题：</td><td ><input type=text id="txtTitle" 
             style="width: 403px" /></td></tr>
     <tr><td style="width: 70px">留言內容：</td><td><textarea id="txtContent" 
             style="width: 403px; height: 84px;"></textarea>
         </td></tr>
     <tr><td colspan=2 align=center style="height: 27px">
         <input type=button value="提交" style="width: 83px"  onclick="setms(1);"/>
         &nbsp; &nbsp;&nbsp;
         </td></tr>
     
     </table></div>
                        </div>
                    </div>
                  
                </div>
</asp:Content>


