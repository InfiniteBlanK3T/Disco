﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.InitialConfig
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InitialConfig/RestartWebApp.cshtml")]
    public partial class RestartWebApp : System.Web.Mvc.WebViewPage<dynamic>
    {
        public RestartWebApp()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\InitialConfig\RestartWebApp.cshtml"
  
    ViewBag.Title = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>");

            
            #line 4 "..\..\Views\InitialConfig\RestartWebApp.cshtml"
Write(CommonHelpers.Breadcrumbs("Initial Configuration > Starting Disco"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n<div");

WriteLiteral(" id=\"dialog\"");

WriteLiteral(" title=\"Please Wait\"");

WriteLiteral(" style=\"padding-top: 30px;\"");

WriteLiteral(">\r\n    <h2><span");

WriteLiteral(" class=\"ajaxLoading\"");

WriteLiteral(" style=\"margin-right: 15px;\"");

WriteLiteral("></span>Starting Disco</h2>\r\n    <div");

WriteLiteral(" style=\"padding-left: 31px;\"");

WriteLiteral(@">Please wait while the Disco environment is initialized</div>
</div>
<script>
    (function () {

        $(function () {

            $('#dialog').dialog({
                autoOpen: true,
                draggable: false,
                modal: true,
                resizable: false,
                width: 400,
                height: 150,
                closeOnEscape: false
            }).closest('.ui-dialog').find('.ui-dialog-titlebar-close').hide();

            var refresh = function () {
                window.location.href = '/';
            }
            window.setTimeout(refresh, 2000);

            $('#layout_Page').css('minHeight', '420px');

        });

    })();
</script>
");

        }
    }
}
#pragma warning restore 1591
