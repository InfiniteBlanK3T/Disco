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

namespace Disco.Web.Views.User
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\User\Index.cshtml"
  
    ViewBag.Title = "Users";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\User\Index.cshtml"
 if (Authorization.Has(Claims.User.Search))
{

            
            #line default
            #line hidden
WriteLiteral("    <h3>Search for a User</h3>\r\n");

            
            #line 7 "..\..\Views\User\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\User\Index.cshtml"
Write(Html.Partial(MVC.Shared.Views._SearchDialog, "users"));

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\User\Index.cshtml"
                                                          
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
