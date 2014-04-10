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

namespace Disco.Web.Views.Job
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/LogWarrantyError.cshtml")]
    public partial class LogWarrantyError : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.LogWarrantyModel>
    {
        public LogWarrantyError()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\LogWarrantyError.cshtml"
  
    Authorization.Require(Claims.Job.Actions.LogWarranty);
    
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), string.Format("Job: {0}", Model.Job.Id), MVC.Job.Show(Model.Job.Id), "Log Warranty Error");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n    <h2>\r\n        Submission Error</h2>\r\n    <table>\r\n        <tr>\r\n          " +
"  <td>\r\n                <div>\r\n                    <strong>");

            
            #line 14 "..\..\Views\Job\LogWarrantyError.cshtml"
                       Write(Model.Error.Message);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                </div>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"warrantyJobErrorShow\"");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(show more)</a>\r\n                <div");

WriteLiteral(" id=\"warrantyJobErrorMore\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n                    <br />\r\n                    <strong>Error Type: </strong>");

            
            #line 19 "..\..\Views\Job\LogWarrantyError.cshtml"
                                            Write(Model.Error.GetType().Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <br />\r\n                    <strong>Stack Trace:</strong>\r\n" +
"                    <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 23 "..\..\Views\Job\LogWarrantyError.cshtml"
                   Write(Model.Error.StackTrace.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 25 "..\..\Views\Job\LogWarrantyError.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Job\LogWarrantyError.cshtml"
                     if (Model.Error.InnerException != null)
                    { 

            
            #line default
            #line hidden
WriteLiteral("                        <hr />\r\n");

WriteLiteral("                        <div>\r\n                            <strong>Inner Exceptio" +
"n:</strong> ");

            
            #line 29 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                         Write(Model.Error.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                            <strong>Error Type:</strong> ");

            
            #line 30 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                    Write(Model.Error.GetType().Name);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                            <strong>Stack Trace:</strong>\r\n              " +
"              <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 33 "..\..\Views\Job\LogWarrantyError.cshtml"
                           Write(Model.Error.InnerException.StackTrace);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");

            
            #line 36 "..\..\Views\Job\LogWarrantyError.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        $('#warrantyJobErrorShow').click(function () {
                            $(this).hide();
                            $('#warrantyJobErrorMore').slideDown();
                        });
                    });
                </script>
            </td>
        </tr>
    </table>
</div>
<div");

WriteLiteral(" id=\"warrantyJobForm\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n    <h2>\r\n        Warranty Submission Details</h2>\r\n    <table>\r\n        <tr>\r" +
"\n            <th>\r\n                Internal Job Id:\r\n            </th>\r\n        " +
"    <td>\r\n");

WriteLiteral("                ");

            
            #line 59 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.JobId);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n             " +
"   Device Serial Number:\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 67 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.Job.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n             " +
"   Device Model:\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 75 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.Job.Device.DeviceModel.Manufacturer);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 75 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                      Write(Model.Job.Device.DeviceModel.Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n             " +
"   Technician:\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 83 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.TechUser.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">\r\n                    Email Address: ");

            
            #line 85 "..\..\Views\Job\LogWarrantyError.cshtml"
                              Write(Model.TechUser.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                    Phone Number: ");

            
            #line 86 "..\..\Views\Job\LogWarrantyError.cshtml"
                             Write(Model.TechUser.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n       " +
"     <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">\r\n                Repair Address:\r\n            </th>\r\n            <td>\r\n        " +
"        <div");

WriteLiteral(" id=\"organisationAddressDetails\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 96 "..\..\Views\Job\LogWarrantyError.cshtml"
               Write(Model.OrganisationAddress.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 98 "..\..\Views\Job\LogWarrantyError.cshtml"
                         Write(Model.OrganisationAddress.Address);

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                        <span>");

            
            #line 99 "..\..\Views\Job\LogWarrantyError.cshtml"
                         Write(Model.OrganisationAddress.Suburb);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 99 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                            Write(Model.OrganisationAddress.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                        <span>");

            
            #line 100 "..\..\Views\Job\LogWarrantyError.cshtml"
                         Write(Model.OrganisationAddress.State);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 100 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                           Write(Model.OrganisationAddress.Country);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </td>\r\n " +
"       </tr>\r\n        <tr>\r\n            <th>\r\n                Warranty Provider:" +
"\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 110 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.WarrantyProvider.Name);

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 110 "..\..\Views\Job\LogWarrantyError.cshtml"
                                         Write(Model.WarrantyProvider.Id);

            
            #line default
            #line hidden
WriteLiteral(") ");

            
            #line 110 "..\..\Views\Job\LogWarrantyError.cshtml"
                                                                     Write(Model.WarrantyProvider.PluginManifest.Version.ToString(3));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n             " +
"   Fault Description:\r\n            </th>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 118 "..\..\Views\Job\LogWarrantyError.cshtml"
           Write(Model.FaultDescription.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 124 "..\..\Views\Job\LogWarrantyError.cshtml"
Write(Html.ActionLinkButton("Try Again", MVC.Job.LogWarranty(Model.JobId, null, null)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 125 "..\..\Views\Job\LogWarrantyError.cshtml"
Write(Html.ActionLinkButton("Return to Job", MVC.Job.Show(Model.JobId)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
