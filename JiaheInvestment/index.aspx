<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 536px; float: left;">
        <div class="cen_main_div">
            <div class="cen_main_div_top">
                ��˾���
            </div>
            <div class="cen_main_div_mid">
                <%=sintro(33)%>
            </div>
        </div>
        <div class="cen_main_div">
            <div class="cen_main_div_top">
                ������Ŀ
            </div>
            <div class="cen_main_div_mid">
                <div style="margin: 0px auto;" id="asplpaMain2">
                    <div id="leftMarquee" class="leftLoop">
                        <div class="bd">
                            <ul class="picList">
                                <%= index_case_list() %>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="width: 210px; float: right;">
        <div class="left_main_div">
            <div class="left_main_div_top">
                ��ҵ����<span><a href="news.aspx?key=26"> ����>></a></span>
            </div>
            <div class="left_main_div_mid">
                <span>
                    <div class="topLoop" id="topLoop1">
                        <div class="bd">
                            <div>
                                <%=return_news(26,12)%>
                            </div>
                        </div>
                    </div>

                    <script type="text/javascript">                        $("#topLoop1").slide({ mainCell: ".bd div", effect: "topMarquee", vis: 6, interTime: 40, autoPlay: true });</script>

                </span>
            </div>
        </div>
        <div class="left_main_div">
            <div class="left_main_div_top">
                ��������<span><a href="news.aspx?key=54"> ����>></a></span>
            </div>
            <div class="left_main_div_mid">
                <span>
                    <div class="topLoop" id="topLoop2">
                        <div class="bd">
                            <div>
                                <%=return_news(54,12)%>
                            </div>
                        </div>
                    </div>

                    <script type="text/javascript">                        $("#topLoop2").slide({ mainCell: ".bd div", effect: "topMarquee", vis: 6, interTime: 40, autoPlay: true });</script>

                </span>
            </div>
        </div>
        <%-- <div class="left_main_div">
                        <div class="left_main_div_top">
                            ��������<span><a href="news.aspx?key=54"></a></span>
                        </div>
                        <div class="left_main_div_mid">
                            <span>
                                <%=return_Friends()%>
                            </span>
                        </div>
                    </div>--%>
    </div>
</asp:Content>
