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

namespace Disco.Web.Areas.Config.Views.JobQueue
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/JobQueue/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.JobQueue.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
  
    Authorization.Require(Claims.Config.JobQueue.Show);
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Job Queues");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Config_JobQueues_Index\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
     if (Model.Tokens.Count == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n            <h2>No job queues are configured</h2>\r\n        </div>  \r\n");

            
            #line 12 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Descripti" +
"on</th>\r\n                <th>Priority</th>\r\n                <th>Linked Groups/Us" +
"ers</th>\r\n            </tr>\r\n");

            
            #line 22 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
             foreach (var item in Model.Tokens)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 818), Tuple.Create("\"", 881)
            
            #line 26 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 825), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.JobQueue.Index(item.JobQueue.Id))
            
            #line default
            #line hidden
, 825), false)
);

WriteLiteral(">\r\n                            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 915), Tuple.Create("\"", 986)
, Tuple.Create(Tuple.Create("", 923), Tuple.Create("fa", 923), true)
, Tuple.Create(Tuple.Create(" ", 925), Tuple.Create("fa-", 926), true)
            
            #line 27 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 929), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Icon
            
            #line default
            #line hidden
, 929), false)
, Tuple.Create(Tuple.Create(" ", 950), Tuple.Create("fa-lg", 951), true)
, Tuple.Create(Tuple.Create(" ", 956), Tuple.Create("d-", 957), true)
            
            #line 27 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 959), Tuple.Create<System.Object, System.Int32>(item.JobQueue.IconColour
            
            #line default
            #line hidden
, 959), false)
);

WriteLiteral("></i>\r\n");

WriteLiteral("                            ");

            
            #line 28 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                       Write(item.JobQueue.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d>");

            
            #line 31 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                         if (string.IsNullOrWhiteSpace(item.JobQueue.Description))
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;none&gt;</span>\r\n");

            
            #line 34 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        }
                        else
                        {
                        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                   Write(item.JobQueue.Description.ToHtmlComment());

            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                                                                  
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1541), Tuple.Create("\"", 1609)
, Tuple.Create(Tuple.Create("", 1549), Tuple.Create("fa", 1549), true)
, Tuple.Create(Tuple.Create(" ", 1551), Tuple.Create("d-priority-", 1552), true)
            
            #line 41 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1563), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Priority.ToString().ToLower()
            
            #line default
            #line hidden
, 1563), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1610), Tuple.Create("\"", 1663)
            
            #line 41 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        , Tuple.Create(Tuple.Create("", 1618), Tuple.Create<System.Object, System.Int32>(item.JobQueue.Priority.ToString()
            
            #line default
            #line hidden
, 1618), false)
, Tuple.Create(Tuple.Create(" ", 1654), Tuple.Create("Priority", 1655), true)
);

WriteLiteral("></i>\r\n                    </td>\r\n                    <td>\r\n");

            
            #line 44 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                         if (item.SubjectIds.Count == 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None&gt;</span>\r\n");

            
            #line 47 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                        Write(string.Join(", ", item.SubjectIds.OrderBy(i => i)));

            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
                                                                                 
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");

            
            #line 54 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 56 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 57 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
     if (Authorization.Has(Claims.Config.JobQueue.Create))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 60 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
       Write(Html.ActionLinkButton("Create Job Queue", MVC.Config.JobQueue.Create()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 62 "..\..\Areas\Config\Views\JobQueue\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
