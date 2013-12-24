﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Config/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.Config.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Config\Index.cshtml"
  
    Authorization.Require(Claims.Config.Show);
    ViewBag.Title = "Configuration";

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"pageMenu\"");

WriteLiteral(">\r\n    <tr>\r\n");

            
            #line 8 "..\..\Areas\Config\Views\Config\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\Config\Views\Config\Index.cshtml"
         if (Authorization.HasAny(Claims.Config.System.Show, Claims.Config.Organisation.Show, Claims.DiscoAdminAccount, Claims.Config.Logging.Show))
        {

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n                <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                    <h2>Hosting</h2>\r\n");

            
            #line 13 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.System.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 15 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("System", MVC.Config.SystemConfig.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                           

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Update system configuration, such as the Data Stor" +
"age Location and Proxy settings.\r\n                        </div>\r\n");

            
            #line 19 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 20 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.Organisation.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 22 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Organisation Details", MVC.Config.Organisation.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                                         

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Update the Organisation Name, Logo and Addresses a" +
"ssociated with this organisation.\r\n                        </div>\r\n");

            
            #line 26 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 27 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.DiscoAdminAccount))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 29 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Authorization Roles", MVC.Config.AuthorizationRole.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                                             

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Configure roles and permissions for users.\r\n      " +
"                  </div>\r\n");

            
            #line 33 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 34 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.Logging.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 36 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Logging", MVC.Config.Logging.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                       

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Export Log files from various Disco Modules and vi" +
"ew Live Logging.\r\n                        </div>\r\n");

            
            #line 40 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </td>\r\n");

            
            #line 43 "..\..\Areas\Config\Views\Config\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 44 "..\..\Areas\Config\Views\Config\Index.cshtml"
         if (Authorization.HasAny(Claims.Config.DeviceModel.Show, Claims.Config.DeviceBatch.Show, Claims.Config.DeviceProfile.Show, Claims.Config.Enrolment.Show))
        {

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n                <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                    <h2>Devices</h2>\r\n");

            
            #line 49 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.DeviceModel.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 51 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Models", MVC.Config.DeviceModel.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                          

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Configure Components, Product Images and default s" +
"ettings for Device Models.\r\n                        </div>\r\n");

            
            #line 55 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 56 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.DeviceBatch.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 58 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Batches", MVC.Config.DeviceBatch.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                           

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Create and Configure Device Batches.\r\n            " +
"            </div>\r\n");

            
            #line 62 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 63 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.DeviceProfile.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 65 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Profiles", MVC.Config.DeviceProfile.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                              

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Configure Device Profiles including computer name " +
"generation, distribution and Active\r\n                    Directory OU layout.\r\n " +
"                       </div>\r\n");

            
            #line 70 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 71 "..\..\Areas\Config\Views\Config\Index.cshtml"
                     if (Authorization.Has(Claims.Config.Enrolment.Show))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 73 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                 
            
            #line default
            #line hidden
            
            #line 73 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                            Write(Html.ActionLinkClass("Enrolment", MVC.Config.Enrolment.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 73 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                           

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                            Configure Enrolment settings including secure cred" +
"entials.\r\n                        </div>\r\n");

            
            #line 77 "..\..\Areas\Config\Views\Config\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </td>\r\n");

            
            #line 80 "..\..\Areas\Config\Views\Config\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 81 "..\..\Areas\Config\Views\Config\Index.cshtml"
         if (Authorization.HasAny(Claims.Config.JobPreferences.Show, Claims.Config.DocumentTemplate.Show, Claims.Config.Plugin.Show))
        {

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n");

            
            #line 84 "..\..\Areas\Config\Views\Config\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 84 "..\..\Areas\Config\Views\Config\Index.cshtml"
                 if (Authorization.HasAny(Claims.Config.JobPreferences.Show))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"pageMenuArea noSeperator\"");

WriteLiteral(">\r\n                        <h2>Jobs</h2>\r\n");

            
            #line 88 "..\..\Areas\Config\Views\Config\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 88 "..\..\Areas\Config\Views\Config\Index.cshtml"
                         if (Authorization.Has(Claims.Config.JobPreferences.Show))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 90 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                     
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                Write(Html.ActionLinkClass("General Preferences", MVC.Config.JobPreferences.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                                              

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                                Configure general preferences related to jobs." +
"\r\n                            </div>\r\n");

            
            #line 94 "..\..\Areas\Config\Views\Config\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 96 "..\..\Areas\Config\Views\Config\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 98 "..\..\Areas\Config\Views\Config\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 98 "..\..\Areas\Config\Views\Config\Index.cshtml"
                 if (Authorization.HasAny(Claims.Config.DocumentTemplate.Show, Claims.Config.Plugin.Show))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                        <h2>Features</h2>\r\n");

            
            #line 102 "..\..\Areas\Config\Views\Config\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 102 "..\..\Areas\Config\Views\Config\Index.cshtml"
                         if (Authorization.Has(Claims.Config.DocumentTemplate.Show))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 104 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                     
            
            #line default
            #line hidden
            
            #line 104 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                Write(Html.ActionLinkClass("Document Templates", MVC.Config.DocumentTemplate.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 104 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                                               

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                                Create, Update and Bulk Generate documents bas" +
"ed on PDF Templates for Jobs, Devices\r\n                    and Users.\r\n         " +
"                   </div>\r\n");

            
            #line 109 "..\..\Areas\Config\Views\Config\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 110 "..\..\Areas\Config\Views\Config\Index.cshtml"
                         if (Authorization.Has(Claims.Config.Plugin.Show))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i>");

            
            #line 112 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                     
            
            #line default
            #line hidden
            
            #line 112 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                Write(Html.ActionLinkClass("Plugins", MVC.Config.Plugins.Index(), "config"));

            
            #line default
            #line hidden
            
            #line 112 "..\..\Areas\Config\Views\Config\Index.cshtml"
                                                                                                                           

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                                Manage extensions to the Disco platform.\r\n    " +
"                        </div>\r\n");

            
            #line 116 "..\..\Areas\Config\Views\Config\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 118 "..\..\Areas\Config\Views\Config\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n");

            
            #line 120 "..\..\Areas\Config\Views\Config\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tr>\r\n</table>\r\n");

            
            #line 123 "..\..\Areas\Config\Views\Config\Index.cshtml"
  
    if (Model.UpdateAvailable)
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"updateAvailableContainer\"");

WriteLiteral(">\r\n        <div>An updated version of Disco is available</div>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6601), Tuple.Create("\"", 6637)
            
            #line 128 "..\..\Areas\Config\Views\Config\Index.cshtml"
, Tuple.Create(Tuple.Create("", 6608), Tuple.Create<System.Object, System.Int32>(Model.UpdateResponse.UrlLink
            
            #line default
            #line hidden
, 6608), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download Disco v");

            
            #line 128 "..\..\Areas\Config\Views\Config\Index.cshtml"
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

            
            #line 136 "..\..\Areas\Config\Views\Config\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 136 "..\..\Areas\Config\Views\Config\Index.cshtml"
                  
        if (Model.UpdateResponse.VersionReleasedTimestamp < DateTime.Now.AddDays(-7))
        {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("\r\n                updateAvailableContainer.effect(\"shake\", { times: 3 }, 100);\r\n " +
"               ");

WriteLiteral("\r\n");

            
            #line 142 "..\..\Areas\Config\Views\Config\Index.cshtml"
        }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            });\r\n        })();\r\n    </script>\r\n");

            
            #line 147 "..\..\Areas\Config\Views\Config\Index.cshtml"
    }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
