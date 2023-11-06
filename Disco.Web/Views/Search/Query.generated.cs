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

namespace Disco.Web.Views.Search
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Query.cshtml")]
    public partial class Query : Disco.Services.Web.WebViewPage<Disco.Web.Models.Search.QueryModel>
    {
        public Query()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Search\Query.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>\r\n    Query: \'<span");

WriteLiteral(" style=\"font-weight: bold;\"");

WriteLiteral(">");

            
            #line 6 "..\..\Views\Search\Query.cshtml"
                                         Write(Model.FriendlyTerm != null ? Model.FriendlyTerm : Model.Term);

            
            #line default
            #line hidden
WriteLiteral("</span>\'</h2>\r\n");

            
            #line 7 "..\..\Views\Search\Query.cshtml"
 if (Model.Success)
{
    if (Model.Jobs != null && Authorization.Has(Claims.Job.Search))
    { 

            
            #line default
            #line hidden
WriteLiteral("    <h2>\r\n        Jobs</h2>\r\n");

WriteLiteral("    <div>\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Search\Query.cshtml"
   Write(Html.Partial(MVC.Shared.Views._JobTable, @Model.Jobs));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 16 "..\..\Views\Search\Query.cshtml"
    }
    if (Model.Devices != null && Authorization.Has(Claims.Device.Search))
    { 

            
            #line default
            #line hidden
WriteLiteral("    <h2>\r\n        Devices</h2>\r\n");

WriteLiteral("    <div>\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Search\Query.cshtml"
   Write(Html.Partial(MVC.Device.Views._DeviceTable, @Model.Devices));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 24 "..\..\Views\Search\Query.cshtml"
    }
    if (Model.Users != null && Authorization.Has(Claims.User.Search))
    { 

            
            #line default
            #line hidden
WriteLiteral("    <h2>\r\n        Users</h2>\r\n");

WriteLiteral("    <div>\r\n");

WriteLiteral("        ");

            
            #line 30 "..\..\Views\Search\Query.cshtml"
   Write(Html.Partial(MVC.User.Views._UserTable, @Model.Users));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 32 "..\..\Views\Search\Query.cshtml"
    }
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <h2>");

            
            #line 36 "..\..\Views\Search\Query.cshtml"
   Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 37 "..\..\Views\Search\Query.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
