//检测数字
function checkNum(obj)
{
	str=document.getElementById("gopg").value;
	var Expression=/^[1-9]+(\d*$)/; 	
	var objExp=new RegExp(Expression);
	if(objExp.test(obj)==true)
	{
		return true;
	}
	return false;
}

//鼠标动作
function cd(id)
{
    document.getElementById(id).style.color = "#cc0000";
}
function cd2(id)
{
    document.getElementById(id).style.color = "#000000";
}

//删除---单一新闻
function delnews(id)
{
	document.getElementById("btn0"+id).className = "dp_none";
	document.getElementById("btn00"+id).className = "dp_show";
	
	var url = document.location.href;
	if(url.indexOf('?') > -1)
	{
	    window.location.href=url+"&ntype=del&id="+document.getElementById("newsid"+id).value;
	}
	else
	{
	    window.location.href=url+"?ntype=del&id="+document.getElementById("newsid"+id).value;
	}
	
//	window.location.href="./newsshow22.aspx?ntype=del&id="+document.getElementById("newsid"+id).value;

}
//删除---多条新闻
function delnewsall(num)
{
    var str = "0";
    for(var i = 1; i<=num;i++)
    {  
        if(document.getElementById("cb"+i).checked)
        {
            str += "-" + document.getElementById("newsid"+i).value;
        }
    }
    var url = document.location.href;
	if(url.indexOf('?') > -1)
	{
	    window.location.href=url+"&ntype=delall&id="+str;
	}
	else
	{
	    window.location.href=url+"?ntype=delall&id="+str;
	}
//	window.location.href="./newsshow22.aspx?ntype=delall&id="+str;
}

//全选，反选
function checkboxall()
{
    for(var i=1;i<=10;i++)
    {
        document.getElementById("cb"+i).click();
    }
    document.getElementById("btn_choose").value = "反选";
}


//页面跳转
function gopgEnter()
{
    if(event.keyCode == 13)
    {
        btn_gopg();
    }
}
function btn_gopg()
{
    var pg = document.getElementById("gopg").value;
    if(!checkNum(pg))
    {
        alert("请输入数字！");
        document.getElementById("gopg").value = "";
        document.getElementById("gopg").focus();
    }
    else
    {   
        var url = document.location.href.split('&gopg=')[0];
        if( url.indexOf('?') > -1)
        {
            window.location.href = url + "&gopg=" + pg;
        }
        else
        {
            window.location.href = url + "?news=0&gopg=" + pg;
        }
    }    
}

//向上 排序
function upnews(id,nt)
{   

    if($F("newsid"+id)=="")
    {
        alert("出错啦！");
    }
    else if(id > 1 )
    {
        var newsid = $F("newsid"+id);
        var newstxt = $("txt0"+id).innerHTML;
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url='newsajax.aspx';
        var newsinfo='upnewsinfo='+$F("newsid"+id)+'-'+$F("newsid"+(id-1))+'&time='+(new Date()).getTime();
        var myAjax=new Ajax.Request(
            url,{method:'POST',
            parameters: newsinfo,
            onComplete: showms
            });

            function showms(ms)
            {
                if(ms.responseText=="1")
                {
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                    
                    $("newsid"+id).value = $F("newsid"+(id-1));
                    $("txt0"+id).innerHTML = $("txt0"+(id-1)).innerHTML
                    $("newsid"+(id-1)).value = newsid;                    ;
                    $("txt0"+(id-1)).innerHTML = newstxt;                                 
                }
                else if(ms.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                    
                    alert("排序失败！");                    
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
    else if(id==1)
    {
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url2='newsajax.aspx';
        var newsinfo2='upnewsinfo2='+$F("newsid"+id)+'-'+nt+'&time='+(new Date()).getTime();
        var myAjax2=new Ajax.Request(
            url2,{method:'POST',
            parameters: newsinfo2,
            onComplete: showms2
            });

            function showms2(ms2)
            {
                if(ms2.responseText=="1")
                {                   
                    var url = document.location.href;
                    if(url.indexOf("&pg=") > -1)
                    {
                        var url2= url.split("&pg=")[0];
                        var url3= url.split("&pg=")[1];                        
                        url3 = url3 - 0 - 1;                        
                        window.location.href = url2 + "?news=0&pg=" + url3;
                    }
                    else
                    {
                        window.location.href = url;
                    } 
                    
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                          
                }
                else if(ms2.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                   
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
    else
    {
    }
}

//移到首位
function upfirstnews(id,nt)
{
    if($F("newsid"+id)=="")
    {
        alert("出错啦！");
    }
    else
    {
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url='newsajax.aspx';
        var newsinfo='upfirstnewsinfo='+$F("newsid"+id)+'-'+nt+'&time='+(new Date()).getTime();
        var myAjax=new Ajax.Request(
            url,{method:'POST',
            parameters: newsinfo,
            onComplete: showms
            });

            function showms(ms)
            {
                if(ms.responseText=="1")
                {
                    window.location.href = document.location.href.split('?')[0] + "?news=0&pg=1"; 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                }
                else if(ms.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("排序失败！");                    
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
}

//向下 排序
function downnews(id,nt,allnum)
{   

    if($F("newsid"+id)=="")
    {
        alert("出错啦！");
    }
    else if(id < allnum )
    {
        var newsid = $F("newsid"+id);
        var newstxt = $("txt0"+id).innerHTML;
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url='newsajax.aspx';
        var newsinfo='downnewsinfo='+$F("newsid"+id)+'-'+$F("newsid"+(id+1))+'&time='+(new Date()).getTime();
        var myAjax=new Ajax.Request(
            url,{method:'POST',
            parameters: newsinfo,
            onComplete: showms
            });

            function showms(ms)
            {
                if(ms.responseText=="1")
                {
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                    
                    $("newsid"+id).value = $F("newsid"+(id+1));
                    $("txt0"+id).innerHTML = $("txt0"+(id+1)).innerHTML;
                    $("newsid"+(id+1)).value = newsid;
                    $("txt0"+(id+1)).innerHTML = newstxt;                                 
                }
                else if(ms.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                    
                    alert("排序失败！");                    
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
    else if(id==allnum)
    {
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url2='newsajax.aspx';
        var newsinfo2='downnewsinfo2='+$F("newsid"+id)+'-'+nt+'&time='+(new Date()).getTime();
        var myAjax2=new Ajax.Request(
            url2,{method:'POST',
            parameters: newsinfo2,
            onComplete: showms2
            });

            function showms2(ms2)
            {
                if(ms2.responseText=="1")
                {                   
                    var url = document.location.href;
                    if(url.indexOf("&pg=") > -1)
                    {
                        var url2= url.split("&pg=")[0];
                        var url3= url.split("&pg=")[1];                        
                        url3 = url3 - 0 + 1;                        
                        window.location.href = url2 + "?news=0&pg=" + url3;
                    }
                    else
                    {
                        window.location.href = url;
                    } 
                    
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                          
                }
                else if(ms2.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                   
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
    else
    {
    }
}

//移到末位
function downlastnews(id,nt)
{
    if($F("newsid"+id)=="")
    {
        alert("出错啦！");
    }
    else
    {
        $("pic0"+id).className = "dp_none";
        $("pic00"+id).className = "dp_show";

        var url='newsajax.aspx';
        var newsinfo='downlastnewsinfo='+$F("newsid"+id)+'-'+nt+'&time='+(new Date()).getTime();
        var myAjax=new Ajax.Request(
            url,{method:'POST',
            parameters: newsinfo,
            onComplete: showms
            });

            function showms(ms)
            {
                if(ms.responseText=="1")
                {
                    window.location.href = document.location.href; 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";
                }
                else if(ms.responseText=="2")
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("排序失败！");                    
                }
                else
                { 
                    $("pic0"+id).className = "dp_show";
                    $("pic00"+id).className = "dp_none";                    
                    alert("出错啦！");
                }
            }
    }
}