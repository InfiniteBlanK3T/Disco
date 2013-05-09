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

namespace Disco.Web.Areas.Config.Views.Config
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Config/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Disco.Web.Areas.Config.Models.Config.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Config\Index.cshtml"
  
    ViewBag.Title = "Configuration";

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"pageMenu\"");

WriteLiteral(">\r\n    <tr>\r\n        <td>\r\n            <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                <h2>Hosting</h2>\r\n");

WriteLiteral("                ");

            
            #line 10 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("System", MVC.Config.SystemConfig.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Update system configuration, such as the Data Storage Loca" +
"tion and Proxy settings.\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Organisation Details", MVC.Config.Organisation.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Update the Organisation Name, Logo and Addresses associate" +
"d with this organisation.\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Logging", MVC.Config.Logging.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Export Log files from various Disco Modules and view Live " +
"Logging.\r\n                </div>\r\n            </div>\r\n        </td>\r\n        <td" +
">\r\n            <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                <h2>Devices</h2>\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Models", MVC.Config.DeviceModel.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Configure Components, Product Images and default settings " +
"for Device Models.\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Batches", MVC.Config.DeviceBatch.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Create and Configure Device Batches.\r\n                </di" +
"v>\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Profiles", MVC.Config.DeviceProfile.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Configure Device Profiles including computer name generati" +
"on, distribution and Active\r\n                    Directory OU layout.\r\n         " +
"       </div>\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Enrolment", MVC.Config.Enrolment.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Configure Enrolment settings including secure credentials." +
"\r\n                </div>\r\n            </div>\r\n        </td>\r\n        <td>\r\n     " +
"       <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                <h2>Features</h2>\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Document Templates", MVC.Config.DocumentTemplate.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Create, Update and Bulk Generate documents based on PDF Te" +
"mplates for Jobs, Devices\r\n                    and Users.\r\n                </div" +
">\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Areas\Config\Views\Config\Index.cshtml"
           Write(Html.ActionLinkClass("Plugins", MVC.Config.Plugins.Index(), "config"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Manage extensions to the Disco platform.\r\n                " +
"</div>\r\n            </div>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");

            
            #line 62 "..\..\Areas\Config\Views\Config\Index.cshtml"
  
    if (Model.UpdateAvailable)
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"updateAvailableContainer\"");

WriteLiteral(">\r\n        <div>An updated version of Disco is available</div>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3034), Tuple.Create("\"", 3070)
            
            #line 67 "..\..\Areas\Config\Views\Config\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3041), Tuple.Create<System.Object, System.Int32>(Model.UpdateResponse.UrlLink
            
            #line default
            #line hidden
, 3041), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download Disco v");

            
            #line 67 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                            Write(Model.UpdateResponse.Version);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n");

WriteLiteral(@"    <script>
        (function () {
            $(function () {
                var layout_PageHeading = $('#layout_PageHeading').height(80);
                var updateAvailableContainer = $('#updateAvailableContainer');
                updateAvailableContainer.appendTo(layout_PageHeading);
");

            
            #line 75 "..\..\Areas\Config\Views\Config\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Areas\Config\Views\Config\Index.cshtml"
                  
        if (Model.UpdateResponse.VersionReleasedTimestamp < DateTime.Now.AddDays(-7))
        {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("\r\n                updateAvailableContainer.effect(\"shake\", { times: 3 }, 100);\r\n " +
"               ");

WriteLiteral("\r\n");

            
            #line 81 "..\..\Areas\Config\Views\Config\Index.cshtml"
        }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            });\r\n        })();\r\n    </script>\r\n");

            
            #line 86 "..\..\Areas\Config\Views\Config\Index.cshtml"
    }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
