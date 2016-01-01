
var delta=0.15
var collection;
function floaters() {
this.items = [];
this.addItem = function(id,x,y,content)
{
	document.write('<DIV id='+id+' style="Z-INDEX: 10; POSITION: absolute;right:10px; width:149px; height:110px; background-image:url(Images/scrollpic.gif); background-repeat:no-repeat; color:#ffffff;"><div style="margin:13px 5px 5px 8px;">'+content+'</div></DIV>');
	var newItem = {};
	newItem.object = document.getElementById(id);
	newItem.x = x;
	newItem.y = y; 
	this.items[this.items.length] = newItem;
}
this.play = function()
{
	collection = this.items
	setInterval('play()',10);
}
}
function play()
{
	if(screen.width<=800)
	{
		for(var i=0;i<collection.length;i++)
		{
			collection[i].object.style.display = 'none';
		}
		return;
	}
	for(var i=0;i<collection.length;i++)
	{
		var followObj = collection[i].object;
		var followObj_x = (typeof(collection[i].x)=='string'?eval(collection[i].x):collection[i].x);
		var followObj_y = (typeof(collection[i].y)=='string'?eval(collection[i].y):collection[i].y); 
		if(followObj.offsetLeft!=(document.body.scrollLeft+followObj_x)) 
		{
			var dx=(document.body.scrollLeft+followObj_x-followObj.offsetLeft)*delta;
			dx=(dx>0?1:-1)*Math.ceil(Math.abs(dx));
			followObj.style.left=followObj.offsetLeft+dx;
		} 
		if(followObj.offsetTop!=(document.documentElement.scrollTop+followObj_y)) 
		{
			var dy=(document.documentElement.scrollTop+followObj_y-followObj.offsetTop)*delta;
			dy=(dy>0?1:-1)*Math.ceil(Math.abs(dy));
			followObj.style.top=followObj.offsetTop+dy;
		}
		followObj.style.display = '';
	}
} 

function disp()
{
document.getElementById("tab").style.display="none";
}
var theFloaters = new floaters();
theFloaters.addItem('followDiv1', 'document.body.clientWidth-154', 230, '<table  id="tab" border="0" width="110" cellspacing="0" cellpadding="0"><tr><td width="110"><span style="font-size: 9pt"><a href="javascript:disp();"><img border=0 src="images/qqtop.jpg"></a></span></td></tr><tr><td><img border=0 src="images/qqcen.jpg"></td></tr><tr><td valign=middle  background="images/qqcenbg.jpg">&nbsp;&nbsp;<img src="images/msn.gif" width="18" height="17" border="0" alt="Online Chat 1" /> <a href="msnim:chat?contact=Vicemanager-linkrich@hotmail.com" target="_blank">Online Chat 1</a></td></tr><tr><td width="110"><span style="font-size: 9pt"><img border=0 src=images/qqbot.jpg></span></td></tr></table>');
//theFloaters.addItem('followDiv2',8,100,''); 

theFloaters.play(); 

