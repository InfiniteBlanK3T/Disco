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
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    
    #line 2 "..\..\Views\User\_UserTable.cshtml"
    using Disco.Services.Users.UserFlags;
    
    #line default
    #line hidden
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/_UserTable.cshtml")]
    public partial class _UserTable : Disco.Services.Web.WebViewPage<IEnumerable<Disco.Models.Services.Searching.UserSearchResultItem>>
    {
        public _UserTable()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\User\_UserTable.cshtml"
  
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-DataTableHelpers");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"genericData userTable\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\User\_UserTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\User\_UserTable.cshtml"
     if (Model != null && Model.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData userTable\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>Id
                    </th>
                    <th>Surname
                    </th>
                    <th>Given Name
                    </th>
                    <th>Display Name
                    </th>
                    <th>Assigned Devices
                    </th>
                    <th>Jobs
                    </th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 27 "..\..\Views\User\_UserTable.cshtml"
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\User\_UserTable.cshtml"
                 foreach (var item in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>\r\n");

            
            #line 31 "..\..\Views\User\_UserTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\User\_UserTable.cshtml"
                             if (Authorization.Has(Claims.User.Show))
                            {
                                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\User\_UserTable.cshtml"
                           Write(Html.ActionLink(item.FriendlyId, MVC.User.Show(item.Id)));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\User\_UserTable.cshtml"
                                                                                         
                            }
                            else
                            {
                                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\User\_UserTable.cshtml"
                           Write(item.FriendlyId);

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\User\_UserTable.cshtml"
                                                
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 39 "..\..\Views\User\_UserTable.cshtml"
                             if (item.UserFlagAssignments != null && item.UserFlagAssignments.Count > 0)
                            {
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"flags\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Views\User\_UserTable.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\User\_UserTable.cshtml"
                                 foreach (var flag in item.UserFlagAssignments.Where(f => !f.RemovedDate.HasValue).Select(f => Tuple.Create(f, UserFlagService.GetUserFlag(f.UserFlagId))))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1722), Tuple.Create("\"", 1792)
, Tuple.Create(Tuple.Create("", 1730), Tuple.Create("flag", 1730), true)
, Tuple.Create(Tuple.Create(" ", 1734), Tuple.Create("fa", 1735), true)
, Tuple.Create(Tuple.Create(" ", 1737), Tuple.Create("fa-", 1738), true)
            
            #line 43 "..\..\Views\User\_UserTable.cshtml"
, Tuple.Create(Tuple.Create("", 1741), Tuple.Create<System.Object, System.Int32>(flag.Item2.Icon
            
            #line default
            #line hidden
, 1741), false)
, Tuple.Create(Tuple.Create(" ", 1759), Tuple.Create("fa-fw", 1760), true)
, Tuple.Create(Tuple.Create(" ", 1765), Tuple.Create("d-", 1766), true)
            
            #line 43 "..\..\Views\User\_UserTable.cshtml"
     , Tuple.Create(Tuple.Create("", 1768), Tuple.Create<System.Object, System.Int32>(flag.Item2.IconColour
            
            #line default
            #line hidden
, 1768), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"details\"");

WriteLiteral("><span");

WriteLiteral(" class=\"name\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\User\_UserTable.cshtml"
                                                                                                                                                  Write(flag.Item2.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 43 "..\..\Views\User\_UserTable.cshtml"
                                                                                                                                                                               if (flag.Item1.Comments != null)
                                                                                                                                                                              {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"comments\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\User\_UserTable.cshtml"
                                                                                                                                                                                                 Write(flag.Item1.Comments.ToHtmlComment());

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 44 "..\..\Views\User\_UserTable.cshtml"
                                                                                                                                                                                                                                                 }
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"added\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\User\_UserTable.cshtml"
                                                                                                                                                                                                                                                                 Write(CommonHelpers.FriendlyDateAndUser(flag.Item1.AddedDate, flag.Item1.AddedUserId));

            
            #line default
            #line hidden
WriteLiteral("</span></span></i>\r\n");

            
            #line 45 "..\..\Views\User\_UserTable.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>");

            
            #line 46 "..\..\Views\User\_UserTable.cshtml"
                                  }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.Surname);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 52 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.GivenName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 55 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.AssignedDevicesCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 61 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.JobCountOpen);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 61 "..\..\Views\User\_UserTable.cshtml"
                                                if (item.JobCount > item.JobCountOpen)
                                               {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(");

            
            #line 63 "..\..\Views\User\_UserTable.cshtml"
                                                        Write(item.JobCount - item.JobCountOpen);

            
            #line default
            #line hidden
WriteLiteral(" Closed)</span>\r\n");

            
            #line 64 "..\..\Views\User\_UserTable.cshtml"
                                               }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                    </tr>\r\n");

            
            #line 67 "..\..\Views\User\_UserTable.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                var userTable = $(\'table.userTabl" +
"e\');\r\n\r\n                userTable.each(function () {\r\n                    var $t" +
"his = $(this);\r\n\r\n                    if (!$this.data(\'userTable_Flags\')) {\r\n   " +
"                     $this.tooltip({\r\n                            items: \'i.flag" +
"\',\r\n                            content: function () {\r\n                        " +
"        var $this = $(this);\r\n                                return $this.child" +
"ren(\'.details\').html();\r\n                            },\r\n                       " +
"     tooltipClass: \'User_FlagAssignment_Tooltip\',\r\n                            p" +
"osition: {\r\n                                my: \"right top\",\r\n                  " +
"              at: \"right bottom\",\r\n                                collision: \"f" +
"lipfit flip\"\r\n                            },\r\n                            hade: " +
"{\r\n                                effect: \'\'\r\n                            },\r\n " +
"                           close: function (e, ui) {\r\n                          " +
"      ui.tooltip.hover(\r\n                                    function () {\r\n    " +
"                                    $(this).stop(true).fadeTo(100, 1);\r\n        " +
"                            },\r\n                                    function () " +
"{\r\n                                        $(this).fadeOut(100, function () { $(" +
"this).remove(); });\r\n                                    });\r\n                  " +
"          }\r\n                        });\r\n\r\n                        $this.data(\'" +
"userTable_Flags\', true)\r\n                    }\r\n                });\r\n           " +
" });\r\n        </script>\r\n");

            
            #line 109 "..\..\Views\User\_UserTable.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Users Found</span>\r\n");

            
            #line 113 "..\..\Views\User\_UserTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
