<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true" CodeFile="yanchushow.aspx.cs" Inherits="yanchushow" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 746px; float:right;">
                    <div class="cen_nei_div">
                        <div class="cen_nei_div_top">
                            集团项目
                        </div>
                        <div class="cen_nei_div_mid">
                              <div style="">
                                <%=Content%>
                    <div style="text-align:center; margin-top:10px; clear:both; clear:left; vertical-align:bottom" class="page_list" ><%=getpage %></div>
                            </div>
                        </div>
                    </div>
                  
                </div>
</asp:Content>

