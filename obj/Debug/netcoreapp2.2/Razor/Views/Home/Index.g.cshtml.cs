#pragma checksum "F:\core22\p22\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94facad87440aa2c82b36334fd5c3d0a8cc49fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94facad87440aa2c82b36334fd5c3d0a8cc49fb1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53a396f04646e609347482f46f12d2cb080ad1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\core22\p22\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "婚姻登记信息";

#line default
#line hidden
            BeginContext(42, 2639, true);
            WriteLiteral(@"
<!-- <div class=""text-center"">// 于树红, 370602197912051347
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div> -->

<div class=""container"">
     <h4 style=""color:cornflowerblue"">省民政厅_婚姻登记信息(单人)_接口查询小技巧</h4>
	<p>身份证号、姓名，必须全部正确输入才可能查询到结果。</p>
	<div style=""margin:20px 0;""></div>
	<table id=""hunyintable"" class=""easyui-datagrid"" title=""婚姻登记信息"" style=""width:900px;height:400px""
			data-options=""rownumbers:true,singleSelect:true,url:'',method:'get',toolbar:'#tb',footer:'#ft'"">
		<thead>
			<tr>
				<th data-options=""field:'cert_no',width:120"">登记信息</th>
				<th data-options=""field:'op_date',width:180"">登记日期</th>
                	<th data-options=""field:'id_card',width:200"">身份证号</th>
				<th data-options=""field:'name',width:100"">姓名</th>
			</tr>
		</thead>
	</table>
    
	<div id=""tb"" style=""padding:2px 5px;"">
		<input class=""easyui-text"" style=""width:210px"" id=""id_card""  placeholder=""身份证号"">
");
            WriteLiteral(@"        <input class=""easyui-text"" style=""width:110px""id=""fullname"" placeholder=""姓名"">
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-search"" id=""searchAllButton"">搜索</a>
	</div>
    <div id=""ft"" style=""padding:2px 5px;"">
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-add"" plain=""true""></a>
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-edit"" plain=""true""></a>
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-save"" plain=""true""></a>
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-cut"" plain=""true""></a>
		<a href=""#"" class=""easyui-linkbutton"" iconCls=""icon-remove"" plain=""true""></a>
	</div>
    <div class=""row"">&nbsp;</div>
    <div class=""row"">       
        
         <div id=""provincetip""></div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
                <!-- <input type=""button"" id=""clickme"" value=""click me"" /> -->
            <hr />
        </div>
    </div>
     <div class=""card-deck mb-3 text-center"">
     
      </div>
    <div class");
            WriteLiteral(@"=""row"">
        <div class=""col-6"">&nbsp;</div>
        <div class=""col-6"">
            <ul id=""messagesList""></ul>
        </div>
    </div>
</div>
<script src=""/lib/signalr/dist/browser/signalr.js""></script>
<script src=""/js/hunyin.js""></script>
<script src=""/lib/jquery/dist/jquery.js""></script>
<script type=""text/javascript"">
    $(document).ready(function() {
        $(""#searchAllButton"").click(function(){
            $('#searchAllButton').menubutton('disable');
            $(""#provincetip"").text(""烟台市政务信息资源共享交换平台查询进行中，结果会自动返回，请稍等。。。"")
        });
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
