"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/allhub").build();

connection.on("fromshareResult", function (message) {
    console.log(message)
    if(!message.ok){
        $.messager.alert(message.title+"，用时" + message.milliseconds + "毫秒！",message.message,'error');       
       // return;
    }
    switch (message.dataid) {
        case 8://waiguoren
            $('#search_foreigner').linkbutton('enable');
            using('datagrid', function(){
                $('#foreignertable').datagrid('loadData',{total:0,rows:[]});
            });
            using('datagrid', function(){
                $('#foreignertable').datagrid('loadData',message.datalist);
            });     
            break;
        case 9://shengyu
            $('#shengyusearch').linkbutton('enable');
            using('datagrid', function(){
                $('#shengyutable').datagrid('loadData',{total:0,rows:[]});
            });
            using('datagrid', function(){
                $('#shengyutable').datagrid('loadData',message.datalist);
            });
           break;
        case 4://chushengzhengming
            $('#birthsearch').linkbutton('enable');
            using('datagrid', function(){
                $('#birthtable').datagrid('loadData',{total:0,rows:[]});
            });
            using('datagrid', function(){
                $('#birthtable').datagrid('loadData',message.datalist);
            });   
            break;
        default:
            li2.textContent = "default"
            break;
    }
});

connection.on("SearchAllResult", function (message) {
    console.log(message)
    if(!message.ok){
        $.messager.alert(message.title+"，用时" + message.milliseconds + "毫秒！",message.message,'error');       
       // return;
    }
    switch (message.dataid) {
        case 0://hunyi
        $('#localmarriage').linkbutton('enable');
        using('datagrid', function(){
            $('#hunyintable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#hunyintable').datagrid('loadData',message.datalist);
        });
        break;
        case 1:
        $('#localzhiye').linkbutton('enable');
        using('datagrid', function(){
            $('#zhiyetable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#zhiyetable').datagrid('loadData',message.datalist);
        }); 
         break;
        // case 2:
        // $('#birthsearch').linkbutton('enable');
        // using('datagrid', function(){
        //     $('#nongbaocanbaotable').datagrid('loadData',{total:0,rows:[]});
        // });
        // using('datagrid', function(){
        //     $('#nongbaocanbaotable').datagrid('loadData',message.datalist);
        // }); 
        // break;
        case 3:
        $('#localnongbao').linkbutton('enable');
        using('datagrid', function(){
            $('#nongbaocanbaotable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#nongbaocanbaotable').datagrid('loadData',message.datalist);
        }); 
        break;
        case 4:
        $('#localbirth').linkbutton('enable');
        using('datagrid', function(){
            $('#birthtable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#birthtable').datagrid('loadData',message.datalist);
        }); 
        break;
        case 5:
        $('#localcanbao').linkbutton('enable');
        using('datagrid', function(){
            $('#canbaozhigongtable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#canbaozhigongtable').datagrid('loadData',message.datalist);
        });    
        break;
        case 6:
        $('#localbinzang').linkbutton('enable');
        using('datagrid', function(){
            $('#binzangtable').datagrid('loadData',{total:0,rows:[]});
        });
        using('datagrid', function(){
            $('#binzangtable').datagrid('loadData',message.datalist);
        }); 
        break;
        // case 7:
        // $('#birthsearch').linkbutton('enable');
        // using('datagrid', function(){
        //     $('#farentable').datagrid('loadData',{total:0,rows:[]});
        // });
        // break;
        case 10:
            $('#farensearch').linkbutton('enable');
            using('datagrid', function(){
                $('#farentable').datagrid('loadData',{total:0,rows:[]});
            });
            using('datagrid', function(){
                $('#farentable').datagrid('loadData',message.datalist);
            });
            break;
        default:
            break;
    }
 
    // var li = document.createElement("li");
    // var msglist = "messagesList";
    // if (message.remote) {
    //     msglist = "remote_messagesList";
    // }

    // if (message.na) {
    //     li.textContent = "未涉及" + message.title;
    //     document.getElementById(msglist).appendChild(li);
    //     return;
    // }

    // li.textContent = message.title + "，用时" + message.milliseconds + "毫秒！";
    // li.style.fontStyle = "italic";
    // document.getElementById(msglist).appendChild(li);

    // if (!message.ok) {
    //     var li1 = document.createElement("li");
    //     li1.textContent = message.title + message.message;
    //     document.getElementById(msglist).appendChild(li1);
    //     return;
    // }

    // hunyi,zigezhengshu,yiyuanyaodian,nongbaocanbao,   chushengzhengming,
    // canbaozhigong,binzanghuohua,yanglaolishi,waiguoren,shengyu,
    // faren
    // message.datalist.forEach(element => {
    //     console.log(element);
    //     var li2 = document.createElement("li");
   

    //     document.getElementById(msglist).appendChild(li2);
    // });
});

connection.on("SearchAllDone", function (message) {
    document.getElementById("provincetip").innerHTML = "所有结果返回！";
  //  $.messager.alert("提示","所有结果返回！",'info');
});
connection.onclose( function (message) {
    $.messager.alert("网络不稳定",message+"请稍后重新刷新页面！",'error');
});

connection.start().catch(function (err) {
  //  $.messager.alert("网络不稳定","请重新刷新页面！",'error');
    return console.error("omg: "+err.toString());
});
