#pragma checksum "F:\core22\p22\Views\Home\synthesis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9e40ff7705c7480f01c67cec584eae62d7fad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_synthesis), @"mvc.1.0.view", @"/Views/Home/synthesis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/synthesis.cshtml", typeof(AspNetCore.Views_Home_synthesis))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\core22\p22\Views\_ViewImports.cshtml"
using p22;

#line default
#line hidden
#line 2 "F:\core22\p22\Views\_ViewImports.cshtml"
using p22.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9e40ff7705c7480f01c67cec584eae62d7fad2", @"/Views/Home/synthesis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53a396f04646e609347482f46f12d2cb080ad1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_synthesis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\core22\p22\Views\Home\synthesis.cshtml"
  
    ViewData["Title"] = "综合搜索";

#line default
#line hidden
            BeginContext(40, 12842, true);
            WriteLiteral(@"
<div class=""container"">
     <h4 style=""color:cornflowerblue"">烟台市公安局本地大数据服务综合查询小技巧</h4>
	<p>身份证号、姓名、电话输入任意组合都可进行模糊匹配查询。</p>
	<div style=""margin:20px 0;""></div>
	<div id=""ttbigtabs"" class=""easyui-tabs"" style=""width:1150px;height:510px"">
    	<!-- <div title=""搜索条件"" id=""tb""  style=""padding:10px"" data-options=""iconCls:'icon-search',closable:true"">
            <input class=""easyui-text"" style=""width:210px"" id=""id_card""  placeholder=""身份证号"">
            <input class=""easyui-text"" style=""width:110px"" id=""fullname""  placeholder=""姓名"">
            <input class=""easyui-text"" style=""width:110px"" id=""phone""  placeholder=""电话"">
            <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""searchAllButton"">搜索</a>
        </div> -->
		<div title=""出生医学证明"" style=""padding:10px"" data-options=""iconCls:'icon-tip',closable:true"">
			<table id=""birthtable"" class=""easyui-datagrid"" style=""width:1100px;height:450px"" data-options=""rownumbers:true,singleSelect:true,toolbar:'#chushengtb'"">
                <thead");
            WriteLiteral(@">
                    <tr>
                        <th data-options=""field:'bh',width:100"">编号</th>
                        <th data-options=""field:'fqsfzhm',width:160"">父亲身份证号码</th>
                        <th data-options=""field:'fqxm',width:100"">父亲姓名</th>
                        <th data-options=""field:'mqsfzhm',width:160"">母亲身份证号码</th>
                        <th data-options=""field:'mqxm',width:100"">母亲姓名</th>
                        <th data-options=""field:'qfjgmc',width:200"">签发机构名称</th>
                        <th data-options=""field:'xsecsrq',width:100"">出生日期</th>
                        <th data-options=""field:'xsexm',width:100"">新生儿姓名</th>
                    </tr>
                </thead>
            </table>
             <div id=""chushengtb"" style=""padding:2px 5px;"">
                <input class=""easyui-text"" style=""width:210px"" id=""birthid_card""  placeholder=""父亲/母亲身份证号"">
                <input class=""easyui-text"" style=""width:210px""id=""birthfullname"" placeholder=""父亲/母亲/新生儿姓名"">
         ");
            WriteLiteral(@"       <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localbirth"">搜索</a>
                <p>身份证号、姓名输入任意一项可进行模糊匹配查询。</p>
            </div>
		</div>
		<div title=""农保参保"" style=""padding:10px"" data-options=""iconCls:'icon-tip',closable:true"">
			<table id=""nongbaocanbaotable"" class=""easyui-datagrid""  style=""width:1100px;height:450px""
                    data-options=""rownumbers:true,singleSelect:true,toolbar:'#nonbaotb'"">
                <thead>
                    <tr>
                        <th data-options=""field:'jbsj',width:150"">经办时间</th>
                        <th data-options=""field:'jdmc',width:170"">街道名称</th>
                        <th data-options=""field:'sqmc',width:170"">社区名称</th>
                        <th data-options=""field:'xm',width:90"">姓名</th>
                        <th data-options=""field:'sfzh',width:180"">身份证号</th>
                        <th data-options=""field:'ryid',width:200"">ryid</th>
                        <th data-options=""field:'grbh',width:70"">个人编号</");
            WriteLiteral(@"th>
                    </tr>
                </thead>
            </table>
               <div id=""nonbaotb"" style=""padding:2px 5px;"">
                <input class=""easyui-text"" style=""width:210px"" id=""nongbaoid_card""  placeholder=""身份证号"">
                <input class=""easyui-text"" style=""width:210px""id=""nongbaofullname"" placeholder=""姓名"">
                <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localnongbao"">搜索</a>
                <p>身份证号、姓名输入任意一项可进行模糊匹配查询。</p>
            </div>
		</div>
		<div title=""参保职工"" data-options=""iconCls:'icon-tip',closable:true"" style=""padding:10px"">
            <table id=""canbaozhigongtable"" class=""easyui-datagrid"" style=""width:1120px;height:450px""	 
                    data-options=""rownumbers:true,singleSelect:true,toolbar:'#canbaotb'"">
                <thead>
                    <tr>
                        <th data-options=""field:'jbrq',width:130"">经办日期</th>
                        <th data-options=""field:'dwbh',width:100"">单位编号</th>
     ");
            WriteLiteral(@"                 
                        <th data-options=""field:'lxdh',width:100"">联系电话</th>
                        <th data-options=""field:'xm',width:100"">姓名</th>
                        <th data-options=""field:'sfzh',width:200"">身份证号</th>
                        <th data-options=""field:'ryid',width:200"">ryid</th>

                        <th data-options=""field:'domicile',width:200"">家庭住址</th>
                    </tr>
                </thead>
            </table>
            <div id=""canbaotb"" style=""padding:2px 5px;"">
                <input class=""easyui-text"" style=""width:210px"" id=""canbaoid_card""  placeholder=""身份证号"">
                <input class=""easyui-text"" style=""width:110px""id=""canbaofullname"" placeholder=""姓名"">
                 <input class=""easyui-text"" style=""width:110px"" id=""canbaophone""  placeholder=""电话"">
                <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localcanbao"">搜索</a>
                <p>身份证号、姓名、电话输入任意一项可进行模糊匹配查询。</p>
            </div>
		</div");
            WriteLiteral(@">
        <div title=""婚姻登记信息"" data-options=""iconCls:'icon-tip',closable:true"" style=""padding:10px"">
            <table id=""hunyintable"" class=""easyui-datagrid""  style=""width:900px;height:450px""
                    data-options=""rownumbers:true,singleSelect:true,toolbar:'#hunyintb'"">
                <thead>
                    <tr>
                        <th data-options=""field:'cert_no',width:280"">登记信息</th>
                        <th data-options=""field:'op_date',width:100"">登记日期</th>
                        <th data-options=""field:'id_card',width:200"">身份证号</th>
                        <th data-options=""field:'name',width:100"">姓名</th>
                    </tr>
                </thead>
            </table>
            <div id=""hunyintb"" style=""padding:2px 5px;"">
                <input class=""easyui-text"" style=""width:210px"" id=""marriageid_card""  placeholder=""身份证号"">
                <input class=""easyui-text"" style=""width:110px""id=""marriagefullname"" placeholder=""姓名"">
                <a href=""#"" ");
            WriteLiteral(@"class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localmarriage"">搜索</a>
                <p>身份证号、姓名输入任意一项可进行模糊匹配查询。</p>
            </div>
		</div>
          <div title=""殡葬火化"" data-options=""iconCls:'icon-tip',closable:true"" style=""padding:10px"">
            <table id=""binzangtable"" class=""easyui-datagrid""  style=""width:1000px;height:450px""
                    data-options=""rownumbers:true,singleSelect:true,toolbar:'#binzangtb'"">
                <thead>
                    <tr>
                        <th data-options=""field:'chapeln',width:280"">地点</th>
                        <th data-options=""field:'cremation_time',width:200"">时间</th>
                        <th data-options=""field:'id_card',width:200"">身份证号</th>
                        <th data-options=""field:'name',width:100"">姓名</th>
                        <th data-options=""field:'sex',width:100"">性别</th>
                    </tr>
                </thead>
            </table>
            <div id=""binzangtb"" style=""padding:2px 5px;"">
      ");
            WriteLiteral(@"          <input class=""easyui-text"" style=""width:210px"" id=""binzangid_card""  placeholder=""身份证号"">
                <input class=""easyui-text"" style=""width:110px""id=""binzangfullname"" placeholder=""姓名"">
                <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localbinzang"">搜索</a>
                <p>身份证号、姓名输入任意一项可进行模糊匹配查询。</p>
            </div>
		</div>
         <div title=""职业资格证书"" data-options=""iconCls:'icon-tip',closable:true"" style=""padding:10px"">
            <table id=""zhiyetable"" class=""easyui-datagrid""  style=""width:1000px;height:450px""
                    data-options=""rownumbers:true,singleSelect:true,toolbar:'#zhiyetb'"">
                <thead>
                    <tr>
                        <th data-options=""field:'zy',width:280"">职业</th>
                        <th data-options=""field:'zsbh',width:200"">证书编号</th>
                        <th data-options=""field:'jdjb',width:200"">鉴定级别</th>
                        <th data-options=""field:'bzrq',width:100"">日期</th>
     ");
            WriteLiteral(@"                   <th data-options=""field:'xm',width:100"">姓名</th>
                    </tr>
                </thead>
            </table>
            <div id=""zhiyetb"" style=""padding:2px 5px;"">
                <input class=""easyui-text"" style=""width:110px""id=""zhiyefullname"" placeholder=""姓名"">
                <a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""localzhiye"">搜索</a>
            </div>
		</div>
	</div>

    <div class=""row"">&nbsp;</div>
    <div class=""row""> 
        <!-- <div class=""col-6"">
            <input type=""text"" id=""ryid"" style=""width:25em"" placeholder=""社保人员编号"" />
            <br />
            <input type=""button"" id=""search_shebao"" value=""社保缴费搜索"" />
        </div> -->
        <ul id=""messagesList""></ul>
         <div id=""provincetip""></div>
    </div>
</div>
<!-- <script src=""/js/chat.js""></script> -->
<script src=""/lib/jquery/dist/jquery.js""></script>
<script type=""text/javascript"">
    $(document).ready(function() {
        // $(""#search_shebao"").");
            WriteLiteral(@"click(function(){
        //     $(""#provincetip"").text(""社保职工养老缴费历史查询进行中，数据量大，查询时间长，请稍等。。。"")
        // }); 
        var tip=""查询进行中，结果会自动返回，请稍等。。。"";
        $(""#localbirth"").click(function(){
        	if($(this).linkbutton('options').disabled==false){                
				$('#localbirth').linkbutton('disable');
				 var id = document.getElementById(""birthid_card"").value;
                var name = document.getElementById(""birthfullname"").value;
                connection.invoke(""localbirth"", id, name).catch(function (err) {
                    return console.error(err.toString());
                });
				$(""#provincetip"").text(tip)
			}
        });
         $(""#localmarriage"").click(function(){
        	if($(this).linkbutton('options').disabled==false){                
				$('#localmarriage').linkbutton('disable');
				 var id = document.getElementById(""marriageid_card"").value;
                var name = document.getElementById(""marriagefullname"").value;
                connection.invoke(""l");
            WriteLiteral(@"ocalmarriage"", id, name).catch(function (err) {
                    return console.error(err.toString());
                });
				$(""#provincetip"").text(tip)
			}
        });
         $(""#localzhiye"").click(function(){
        	if($(this).linkbutton('options').disabled==false){                
				$('#localzhiye').linkbutton('disable');
				 var name = document.getElementById(""zhiyefullname"").value;
                connection.invoke(""localzhiye"",name).catch(function (err) {
                    return console.error(err.toString());
                });
				$(""#provincetip"").text(tip)
			}
        });
          $(""#localnongbao"").click(function(){
        	if($(this).linkbutton('options').disabled==false){                
				$('#localnongbao').linkbutton('disable');
				var id = document.getElementById(""nongbaoid_card"").value;
                var name = document.getElementById(""nongbaofullname"").value;
                connection.invoke(""localnongbao"", id, name).catch(function (err) {
     ");
            WriteLiteral(@"               return console.error(err.toString());
                });
				$(""#provincetip"").text(tip)
			}
        });
        $(""#localcanbao"").click(function(){
        	if($(this).linkbutton('options').disabled==false){                
				$('#localcanbao').linkbutton('disable');
				 var id = document.getElementById(""canbaoid_card"").value;
                var name = document.getElementById(""canbaofullname"").value;
                var phone = document.getElementById(""canbaophone"").value;
                connection.invoke(""localcanbao"", id, name, phone).catch(function (err) {
                    return console.error(err.toString());
                });
				$(""#provincetip"").text(tip)
			}
        });
        $(""#localbinzang"").click(function(){
        	if($(this).linkbutton('options').disabled==false){
				var id = document.getElementById(""binzangid_card"").value;
                var name = document.getElementById(""binzangfullname"").value;
                connection.invoke(""localbinz");
            WriteLiteral(@"ang"", id, name).catch(function (err) {
                    return console.error(err.toString());
                });
				$('#localbinzang').linkbutton('disable');
				$(""#provincetip"").text(tip)
			}
        });
    });
    
    $(function(){
        var tabs = $('#ttbigtabs').tabs().tabs('tabs');
        for(var i=0; i<tabs.length; i++){
            tabs[i].panel('options').tab.unbind().bind('mouseenter',{index:i},function(e){
                $('#ttbigtabs').tabs('select', e.data.index);
            });
        }
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
