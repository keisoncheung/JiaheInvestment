﻿ function setms(cans)
    {
    
    var can1,can2,can3,can4,url;
    switch(cans)
    {
    case 1:
    can1="留言标题和内容不能为空!";
    can2="留言标题不能为空!";
    can3="留言内容不能为空!";
    can4="提交成功!";
    url='ms.aspx';
    break;
    case 2:
    can1="Message title and content can not be empty!";
    can2="Title can not be empty!";
    can3="Message content can not be empty!";
    can4="Success,thanks!";
    url='../ms.aspx';
    
    
    case 3:
    can1="Message title and content can not be empty!";
    can2="Title can not be empty!";
    can3="Message content can not be empty!";
    can4="Success,thanks!";
    url='../ms.aspx';
    
    case 4:
    can1="Message title and content can not be empty!";
    can2="Title can not be empty!";
    can3="Message content can not be empty!";
    can4="Success,thanks!";
    url='../ms.aspx';
    
    break;
    default:
    can1="留言标题和内容不能为空!";
    can2="留言标题不能为空!";
    can3="留言内容不能为空!";
    can4="提交成功!";
    url='ms.aspx';
    break;  
    }
//    if(cans==1)
//    {
//    can1="留言标题和内容不能为空!";
//    can2="留言标题不能为空!";
//    can3="留言内容不能为空!";
//    can4="提交成功!";
//    }
//    else 
//    {
//    can1="Message title and content can not be empty!";
//    can2="Title can not be empty!";
//    can3="Message content can not be empty!";
//    can4="Success,thanks!";
//    }
    
      if ($('#txtTitle').val() == "" && $('#txtContent').val()=="")
        {
            alert(can1);
        }
        else if($('#txtTitle').val()=="")
        {
        alert(can2);
        }
        else if($('#txtContent').val()=="")
        {
        alert(can3);
        }
        else {

            $.post(url, { "pars": $('#txtTitle').val() + '-' + $('#txtContent').val() + '-' + $('#email').val() + '-' + $('#txtName').val() + '-' + $('#tel').val() + '-' + $('#zip').val() + '-' + $('#address').val() + '-' + cans }, function(e) {

            alert("提交成功！");
                window.location.href =location.href;
            });
        
        
        }  
    }
    
    
    
//图片现实功能
function Searchresult(id,pic)
{
var url="Ajax_product.aspx?v="+id+"&time="+(new Date()).getTime();
var pars='v='+id+'&time='+(new Date()).getTime();
var myAjax=new Ajax.Request(
        url,{method:'POST',
        parameters: pars,
        onComplete: showms
        });
        function showms(ms)
        {
        $('cpjj').innerHTML=ms.responseText;
        $('proimg').innerHTML="<a href='upfile/"+pic+ "' rel='lightbox[asd]'><img style='width: 320px; border:0px;' src='upfile/s"+pic+ "' />";
        }
 }



//判断登录状态
function ActViewQA_Form()
{
var url="Judgement.aspx?time="+(new Date()).getTime();
var loginstr='loginstr=1';
var myAjax=new Ajax.Request(
        url,{method:'POST',
        parameters: loginstr,
        onComplete: showms
        });

        function showms(ms)
        {
        if(ms.responseText!="2")
        {
        window.location.href="MyQAMSGList.aspx";
        }
        else
        {
         alert("对不起,您还没有登录!");
        }
        }
}