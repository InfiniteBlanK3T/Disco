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
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/LogWarranty.cshtml")]
    public partial class LogWarranty : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.LogWarrantyModel>
    {
        public LogWarranty()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\LogWarranty.cshtml"
  
    Authorization.Require(Claims.Job.Actions.LogWarranty);

    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), string.Format("Job: {0}", Model.Job.Id), MVC.Job.Show(Model.Job.Id), "Log Warranty");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Job\LogWarranty.cshtml"
 using (Html.BeginForm(MVC.Job.LogWarranty(), FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogWarranty.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.HiddenFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogWarranty.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.ValidationMessageFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogWarranty.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SubmissionAction\"");

WriteAttribute("value", Tuple.Create(" value=\"", 497), Tuple.Create("\"", 554)
            
            #line 12 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Model.IsManualProvider ? "Manual" : "Disclose"
            
            #line default
            #line hidden
, 505), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobForm\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>Internal Job Id:\r\n     " +
"           </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 19 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.JobId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Serial Number:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.Job.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Model:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.Job.Device.DeviceModel.Manufacturer);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 33 "..\..\Views\Job\LogWarranty.cshtml"
                                                          Write(Model.Job.Device.DeviceModel.Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Technician:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.TechUser.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">\r\n                        Email Address: ");

            
            #line 42 "..\..\Views\Job\LogWarranty.cshtml"
                                  Write(Model.TechUser.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                        Phone Number: ");

            
            #line 43 "..\..\Views\Job\LogWarranty.cshtml"
                                 Write(Model.TechUser.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">Repair Address:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.DropDownListFor(model => model.OrganisationAddressId, Model.OrganisationAddresses.ToSelectListItems(Model.OrganisationAddressId, (Model.OrganisationAddress == null))));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 52 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.OrganisationAddressId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" id=\"organisationAddressDetails\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..\Views\Job\LogWarranty.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Job\LogWarranty.cshtml"
                          
    var oa = Model.OrganisationAddress;
    if (oa != null)
    {

            
            #line default
            #line hidden
WriteLiteral("                            <span>");

            
            #line 58 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.Address);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 60 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.Suburb);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 60 "..\..\Views\Job\LogWarranty.cshtml"
                                         Write(oa.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 62 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.State);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 62 "..\..\Views\Job\LogWarranty.cshtml"
                                        Write(oa.Country);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 63 "..\..\Views\Job\LogWarranty.cshtml"
    }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th>Warranty Provider:\r\n                </th>\r\n        " +
"        <td>\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.DropDownListFor(model => model.WarrantyProviderId, Model.WarrantyProviders.ToSelectListItems(Model.WarrantyProviderId, AdditionalItems: new Dictionary<string, string>() { { "MANUAL", "<Manually Submitted Claim>" } })));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 73 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.WarrantyProviderId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 74 "..\..\Views\Job\LogWarranty.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Job\LogWarranty.cshtml"
                     if (Model.WarrantyProviders.Count == 0 && Authorization.Has(Claims.Config.Plugin.Install))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-info-circle\"");

WriteLiteral("></i>View the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3317), Tuple.Create("\"", 3367)
            
            #line 78 "..\..\Views\Job\LogWarranty.cshtml"
    , Tuple.Create(Tuple.Create("", 3324), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.Plugins.Install())
            
            #line default
            #line hidden
, 3324), false)
);

WriteLiteral(">Plugin Catalogue</a> to discover and install warranty provider plugins.\r\n       " +
"                     </p>\r\n                        </div>\r\n");

            
            #line 81 "..\..\Views\Job\LogWarranty.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 84 "..\..\Views\Job\LogWarranty.cshtml"
            
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Job\LogWarranty.cshtml"
             if (Model.IsManualProvider)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <th>Provider Name:</th>\r\n              " +
"      <td>\r\n");

WriteLiteral("                        ");

            
            #line 89 "..\..\Views\Job\LogWarranty.cshtml"
                   Write(Html.EditorFor(model => model.ManualProviderName));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                        ");

            
            #line 90 "..\..\Views\Job\LogWarranty.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ManualProviderName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

WriteLiteral("                <tr>\r\n                    <th>Provider Job Reference:</th>\r\n     " +
"               <td>\r\n");

WriteLiteral("                        ");

            
            #line 96 "..\..\Views\Job\LogWarranty.cshtml"
                   Write(Html.EditorFor(model => model.ManualProviderReference));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                        ");

            
            #line 97 "..\..\Views\Job\LogWarranty.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ManualProviderReference));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 100 "..\..\Views\Job\LogWarranty.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobFaultDescription\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n        <h2>Fault Description</h2>\r\n        <table>\r\n            <tr>\r\n       " +
"         <td>\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.EditorFor(model => model.FaultDescription));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 109 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.FaultDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

            
            #line 114 "..\..\Views\Job\LogWarranty.cshtml"
            if (!Model.IsManualProvider && Authorization.Has(Claims.Job.ShowAttachments) && Model.Job.JobAttachments.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n        <h2>Send Attachments</h2>\r\n        <table>\r\n            <tr>\r\n        " +
"        <td>\r\n                    <div");

WriteLiteral(" id=\"publishJobAttachments\"");

WriteLiteral(">\r\n");

            
            #line 122 "..\..\Views\Job\LogWarranty.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Job\LogWarranty.cshtml"
                         foreach (var ja in Model.Job.JobAttachments)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5195), Tuple.Create("\"", 5252)
            
            #line 124 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 5202), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Job.AttachmentDownload(ja.Id))
            
            #line default
            #line hidden
, 5202), false)
);

WriteLiteral(" data-attachmentid=\"");

            
            #line 124 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                                       Write(ja.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-mimetype=\"");

            
            #line 124 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                                                              Write(ja.MimeType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"select\"");

WriteLiteral(" name=\"PublishAttachmentIds\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5409), Tuple.Create("\"", 5423)
            
            #line 125 "..\..\Views\Job\LogWarranty.cshtml"
                         , Tuple.Create(Tuple.Create("", 5417), Tuple.Create<System.Object, System.Int32>(ja.Id
            
            #line default
            #line hidden
, 5417), false)
);

WriteLiteral(" ");

            
            #line 125 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                                             Write(Model.PublishAttachmentIds.Contains(ja.Id) ? "checked" : null);

            
            #line default
            #line hidden
WriteLiteral(" />\r\n                                <span");

WriteLiteral(" class=\"icon\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5544), Tuple.Create("\"", 5564)
            
            #line 126 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 5552), Tuple.Create<System.Object, System.Int32>(ja.Filename
            
            #line default
            #line hidden
, 5552), false)
);

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5635), Tuple.Create("\"", 5694)
            
            #line 127 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 5641), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Job.AttachmentThumbnail(ja.Id))
            
            #line default
            #line hidden
, 5641), false)
);

WriteLiteral(" /></span>\r\n                                <span");

WriteLiteral(" class=\"comments\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5761), Tuple.Create("\"", 5781)
            
            #line 128 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 5769), Tuple.Create<System.Object, System.Int32>(ja.Comments
            
            #line default
            #line hidden
, 5769), false)
);

WriteLiteral(">\r\n");

            
            #line 129 "..\..\Views\Job\LogWarranty.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Job\LogWarranty.cshtml"
                                      if (!string.IsNullOrEmpty(ja.DocumentTemplateId))
                                      { 
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Job\LogWarranty.cshtml"
                                   Write(ja.DocumentTemplate.Description);

            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Job\LogWarranty.cshtml"
                                                                        }
                                      else
                                      { 
            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Job\LogWarranty.cshtml"
                                   Write(ja.Comments);

            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Job\LogWarranty.cshtml"
                                                     }
            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral(">");

            
            #line 133 "..\..\Views\Job\LogWarranty.cshtml"
                                                       Write(ja.TechUser.ToStringFriendly());

            
            #line default
            #line hidden
WriteLiteral("</span><span");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(" data-livestamp=\"");

            
            #line 133 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                                                                      Write(ja.Timestamp.ToUnixEpoc());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("title", Tuple.Create(" title=\"", 6217), Tuple.Create("\"", 6255)
            
            #line 133 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                               , Tuple.Create(Tuple.Create("", 6225), Tuple.Create<System.Object, System.Int32>(ja.Timestamp.ToFullDateTime()
            
            #line default
            #line hidden
, 6225), false)
);

WriteLiteral(">");

            
            #line 133 "..\..\Views\Job\LogWarranty.cshtml"
                                                                                                                                                                                                          Write(ja.Timestamp.ToFullDateTime());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>   \r\n");

            
            #line 135 "..\..\Views\Job\LogWarranty.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </td>\r\n            </tr>\r\n        </t" +
"able>\r\n    </div>\r\n");

            
            #line 141 "..\..\Views\Job\LogWarranty.cshtml"
            }
            if (Model.WarrantyProvider != null && Model.WarrantyProviderSubmitJobViewType != null)
            { 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobProviderProperties\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 145 "..\..\Views\Job\LogWarranty.cshtml"
   Write(Html.PartialCompiled(Model.WarrantyProviderSubmitJobViewType, Model.WarrantyProviderSubmitJobModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 147 "..\..\Views\Job\LogWarranty.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 149 "..\..\Views\Job\LogWarranty.cshtml"
        
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Job\LogWarranty.cshtml"
         if (Model.IsManualProvider)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Save Warranty Claim\"");

WriteLiteral(" />\r\n");

            
            #line 152 "..\..\Views\Job\LogWarranty.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Preview Warranty Claim\"");

WriteLiteral(" />\r\n");

            
            #line 156 "..\..\Views\Job\LogWarranty.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 158 "..\..\Views\Job\LogWarranty.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var $providerId = $(\'#WarrantyProviderId\');\r\n    " +
"    var $addressId = $(\'#OrganisationAddressId\');\r\n\r\n        function updateDeta" +
"ils() {\r\n            $(\'<form>\').attr({\r\n                action: $providerId.clo" +
"sest(\'form\').attr(\'action\'),\r\n                method: \'post\'\r\n            }).app" +
"end(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'SubmissionActio" +
"n\', value: \'Update\' })\r\n            ).append(\r\n                $(\'<input>\').attr" +
"({ type: \'hidden\', name: \'JobId\', value: $(\'#JobId\').val() })\r\n            ).app" +
"end(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'WarrantyProvide" +
"rId\', value: $providerId.val() })\r\n            ).append(\r\n                $(\'<in" +
"put>\').attr({ type: \'hidden\', name: \'OrganisationAddressId\', value: $addressId.v" +
"al() })\r\n            ).append(\r\n                $(\'<input>\').attr({ type: \'hidde" +
"n\', name: \'FaultDescription\', value: $(\'#FaultDescription\').val() })\r\n          " +
"  ).append(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'ManualPr" +
"oviderName\', value: $(\'#ManualProviderName\').val() })\r\n            ).append(\r\n  " +
"              $(\'<input>\').attr({ type: \'hidden\', name: \'ManualProviderReference" +
"\', value: $(\'#ManualProviderReference\').val() })\r\n            ).appendTo(\'body\')" +
".submit();\r\n        }\r\n\r\n        $providerId.change(updateDetails);\r\n        $ad" +
"dressId.change(updateDetails);\r\n\r\n        var manualProvider = $(\'#ManualProvide" +
"rName\');\r\n        if (manualProvider.length > 0 && !manualProvider.val()) {\r\n   " +
"         manualProvider.focus();\r\n        } else {\r\n            $(\'#FaultDescrip" +
"tion\').focus();\r\n        }\r\n\r\n        $(\'#publishJobAttachments\').on(\'click\', \'i" +
"nput\', function (e) {\r\n            e.preventDefault();\r\n            setTimeout(f" +
"unction () {\r\n                var $i = $(e.currentTarget);\r\n                $i.p" +
"rop(\'checked\', !$i.prop(\'checked\'));\r\n            }, 0);\r\n            return fal" +
"se;\r\n        });\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
