﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Device
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/Import.cshtml")]
    public partial class Import : System.Web.Mvc.WebViewPage<Disco.Web.Models.Device.ImportModel>
    {
        public Import()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\Import.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Devices", MVC.Device.Index(), "Import Devices");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Device\Import.cshtml"
 using (Html.BeginForm(MVC.API.Device.ImportParse(), FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Device\Import.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Device\Import.cshtml"
                             

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"importDialog\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 12 "..\..\Views\Device\Import.cshtml"
               Write(Html.LabelFor(m => m.ImportFile));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    <input");

WriteLiteral(" id=\"ImportFile\"");

WriteLiteral(" name=\"ImportFile\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"An Import File is required.\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Import\"");

WriteLiteral(" />\r\n        </p>\r\n    </div>\r\n");

            
            #line 23 "..\..\Views\Device\Import.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
