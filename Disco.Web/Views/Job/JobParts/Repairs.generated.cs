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

namespace Disco.Web.Views.Job.JobParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/Repairs.cshtml")]
    public partial class Repairs : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public Repairs()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\JobParts\Repairs.cshtml"
  
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-PropertyChangeHelpers");

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"jobNonWarrantyRepairs\"");

WriteLiteral(">\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">\r\n            Repairer Name\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 11 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(Html.EditorFor(m => m.Job.JobMetaNonWarranty.RepairerName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                $(function () {\r\n                    document.DiscoFunctions.P" +
"ropertyChangeHelper(\r\n                            $(\'#Job_JobMetaNonWarranty_Rep" +
"airerName\'),\r\n                            \'Unknown\',\r\n                          " +
"  \'");

            
            #line 19 "..\..\Views\Job\JobParts\Repairs.cshtml"
                        Write(Url.Action(MVC.API.Job.UpdateNonWarrantyRepairerName(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            \'RepairerName\'\r\n                        );\r\n     " +
"           });\r\n            </script>\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n     " +
"   <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">\r\n            Repair Logged\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.RepairerLoggedDate, "Not Logged", "Job_JobMetaNonWarranty_RepairerLoggedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">\r\n            Repair Reference\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(Html.EditorFor(m => m.Job.JobMetaNonWarranty.RepairerReference));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                $(function () {\r\n                    document.DiscoFunctions.P" +
"ropertyChangeHelper(\r\n                            $(\'#Job_JobMetaNonWarranty_Rep" +
"airerReference\'),\r\n                            \'Unknown\',\r\n                     " +
"       \'");

            
            #line 47 "..\..\Views\Job\JobParts\Repairs.cshtml"
                        Write(Url.Action(MVC.API.Job.UpdateNonWarrantyRepairerReference(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                            \'RepairerReference\'\r\n                        );\r\n" +
"                });\r\n            </script>\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n" +
"        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">\r\n            Repair Completed\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Job\JobParts\Repairs.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.RepairerCompletedDate, "Not Completed", "Job_JobMetaNonWarranty_RepairerCompletedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<script>\r\n    $(function () {\r\n        var " +
"updateUrl = \'");

            
            #line 65 "..\..\Views\Job\JobParts\Repairs.cshtml"
                     Write(Url.Action(MVC.API.Job.Update(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var jobOpenDate = \'");

            
            #line 66 "..\..\Views\Job\JobParts\Repairs.cshtml"
                       Write(Model.Job.OpenedDate.ToJavascriptDateTime());

            
            #line default
            #line hidden
WriteLiteral(@"';

        document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, 'Repairer Name', 'Job_JobMetaNonWarranty_RepairerLoggedDate', null, 'NonWarrantyRepairerLoggedDate', 'Not Logged', jobOpenDate, false);
        document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, 'Repair Completed', 'Job_JobMetaNonWarranty_RepairerCompletedDate', null, 'NonWarrantyRepairerCompletedDate', 'Not Completed', jobOpenDate, false);
    });
</script>");

        }
    }
}
#pragma warning restore 1591
