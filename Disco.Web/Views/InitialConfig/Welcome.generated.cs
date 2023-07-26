﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    using Disco;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InitialConfig/Welcome.cshtml")]
    public partial class Welcome : Disco.Services.Web.WebViewPage<Disco.Web.Models.InitialConfig.WelcomeModel>
    {
        public Welcome()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\InitialConfig\Welcome.cshtml"
  
    ViewBag.Title = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>Welcome to Disco ICT Management!</h1>\r\n<div");

WriteLiteral(" id=\"initialConfig_Welcome\"");

WriteLiteral(">\r\n    <p>The installation is complete, but a few things need to be configured be" +
"fore Disco ICT can be started.</p>\r\n");

            
            #line 8 "..\..\Views\InitialConfig\Welcome.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\InitialConfig\Welcome.cshtml"
     using (Html.BeginForm())
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 400px\"");

WriteLiteral(">\r\n            <h2>Organisation Name</h2>\r\n            <table>\r\n                <" +
"tr>\r\n                    <td>\r\n                        <div>\r\n");

WriteLiteral("                            ");

            
            #line 16 "..\..\Views\InitialConfig\Welcome.cshtml"
                       Write(Html.EditorFor(m => m.OrganisationName));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                            ");

            
            #line 17 "..\..\Views\InitialConfig\Welcome.cshtml"
                       Write(Html.ValidationMessageFor(m => m.OrganisationName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr" +
">\r\n            </table>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" id=\"submitForm\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Continue\"");

WriteLiteral(" />\r\n        </div>\r\n");

            
            #line 26 "..\..\Views\InitialConfig\Welcome.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<script>\r\n    (function () {\r\n        $(function () {\r\n            $(\'#Or" +
"ganisationName\').focus();\r\n        });\r\n    })();\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
