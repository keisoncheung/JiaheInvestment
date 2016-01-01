<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/css.css" rel="stylesheet" type="text/css" />

    <script src="js/jQuery.blockUI.js" type="text/javascript"></script>

    <script src="js/jquery-1.9.1.min.js" type="text/javascript"></script>
    <script src="js/jquery.pack.js" type="text/javascript"></script>
 

    <script src="js/jquery.SuperSlide.js" type="text/javascript"></script>
<style>

</style>


    <script type="text/javascript">

        $(function() {

            $(".menubg_main1 div").each(function() {
                $(this).css("background-image", "none");
            });

            $(".menubg_main1 div").mouseover(function() {
                $(this).css("background-image", "url(images/menubg2.jpg)");
            }).mouseout(function() {
                $(this).css("background-image", "none");
            });

            $("#leftMarquee").slide({ mainCell: ".bd ul", effect: "leftMarquee", vis: 3, interTime: 40, autoPlay: true });

        });

        
    </script>
    

</head>
<body>
    <form id="form1" runat="server">
    <div class="top1">
        <div>
            <img src="images/logo.jpg" />
        </div>
    </div>
    <div class="jiahe_main">
        <div style="width: 964px; margin: 0px auto;">
            <div class="menubg">
                <div class="menubg_left">
                </div>
                <div class="menubg_main1">
                    <div style="background: url(images/menubg2.jpg);">
                        <a href="#">首页</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">集团简介</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">集团新闻</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">行业新闻</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">企业优势</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">集团项目</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">在线留言</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">联系我们</a>
                    </div>
                    <span></span>
                    <div>
                        <a href="#">人才招聘</a>
                    </div>
                </div>
                <div class="menubg_rig">
                </div>
            </div>
            <div class="menubg3">
            </div>
            <div style="width: 964px; height: 303px;">
                <img src="images/flash.jpg" />
            </div>
            <div style="width: 100%;">
                <div style="width: 210px; float: left;">
                    <div class="left_main_div">
                        <div class="left_main_div_top">
                            项目分类
                        </div>
                        <div class="left_main_div_mid">
                            <ul>
                                <li><a href="#">别墅</a></li>
                                <li><a href="#">别墅</a></li>
                                <li><a href="#">别墅</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="left_main_div">
                        <div class="left_main_div_top">
                            联系我们
                        </div>
                        <div class="left_main_div_mid">
                            <div style="width: 95%; margin: 0px auto;">
                                联系人：<br />
                                邮箱：<br />
                                电话:<br />
                                地址：</div>
                        </div>
                    </div>
                </div>
                <div style="width: 536px; float: left;">
                    <div class="cen_main_div">
                        <div class="cen_main_div_top">
                            公司简介
                        </div>
                        <div class="cen_main_div_mid">
                            公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介公司简介
                        </div>
                    </div>
                    <div class="cen_main_div">
                        <div class="cen_main_div_top">
                            集团项目
                        </div>
                        <div class="cen_main_div_mid">
                     <div id="leftMarquee" class="leftLoop">
						
						<div class="bd">
							<ul class="picList">
								<li>
									<div class="pic"><a href=""><img src="images/ad1.jpg" /></a></div>
									<div class="title"><a href="">效果图1</a></div>
								</li>
								<li>
									<div class="pic"><a href=""><img src="images/ad2.jpg" /></a></div>
									<div class="title"><a href="">效果图2</a></div>
								</li>
								<li>
									<div class="pic"><a href=""><img src="images/ad3.jpg" /></a></div>
									<div class="title"><a href="">效果图3</a></div>
								</li>
							</ul>
						</div>
					</div>
                        
                        </div>
                    </div>
                </div>
                <div style="width: 210px; float: right;">
                    <div class="left_main_div">
                        <div class="left_main_div_top">
                            行业新闻<span><a href="#"> 更多>></a></span>
                        </div>
                        <div class="left_main_div_mid">
                            <span>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                            </span>
                        </div>
                    </div>
                     <div class="left_main_div">
                        <div class="left_main_div_top">
                            集团新闻<span><a href="#"> 更多>></a></span>
                        </div>
                        <div class="left_main_div_mid">
                            <span>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                                <dl>
                                    <dt></dt>
                                    <dd>
                                        <a href="#">别墅</a></dd>
                                </dl>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
             
        </div>
        <div style=" clear:both; background:url(images/botbgline.jpg); height:8px; width:100%;"></div>
        <div style="width: 964px; margin: 0px auto; height:100px;">
        <div style="width: 99%; margin: 10px auto;">
                                广州佳和公司 &nbsp;&nbsp;&nbsp;版权所有 CopyRight©2013 <br />
                                
                                电话/Tel: 传真/Fax: <br />
                                邮箱/Email: 联系人/Contact: <br />
                                地址/Address：</div>
        </div>
        
    </div>
    
   
    </form>
</body>
</html>
