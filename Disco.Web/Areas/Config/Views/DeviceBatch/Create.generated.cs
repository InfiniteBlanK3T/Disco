﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.DeviceBatch
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceBatch/Create.cshtml")]
    public partial class Create : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceBatch.CreateModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
  
    Authorization.Require(Claims.Config.DeviceBatch.Create);
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Batches", MVC.Config.DeviceBatch.Index(null), "Create");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
 using (Html.BeginForm())
{ 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    N" +
"ame:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 15 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
               Write(Html.EditorFor(model => model.DeviceBatch.Name));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 15 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
                                                                     Write(Html.ValidationMessageFor(model => model.DeviceBatch.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Purchase Date:\r\n                </th>\r\n                <t" +
"d>");

            
            #line 22 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
               Write(Html.EditorFor(model => model.DeviceBatch.PurchaseDate));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 22 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
                                                                             Write(Html.ValidationMessageFor(model => model.DeviceBatch.PurchaseDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" />\r\n        </p>\r\n    </div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $('#Name').focus().select();
            $('#PurchaseDate').datepicker({
                changeYear: true,
                changeMonth: true,
                dateFormat: 'yy/mm/dd'
            })
        });
    </script>
");

            
            #line 40 "..\..\Areas\Config\Views\DeviceBatch\Create.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
