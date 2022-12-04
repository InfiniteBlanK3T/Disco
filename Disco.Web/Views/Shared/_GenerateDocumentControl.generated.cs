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

namespace Disco.Web.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_GenerateDocumentControl.cshtml")]
    public partial class _GenerateDocumentControl : Disco.Services.Web.WebViewPage<Disco.Web.Models.Shared.GenerateDocumentControlModel>
    {
        public _GenerateDocumentControl()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
 if (Model.Templates.Count > 0 || Model.TemplatePackages.Count > 0)
{
    var selectListItems = new List<SelectListItem>();
    selectListItems.Add(new SelectListItem() { Selected = true, Value = string.Empty, Text = "Generate Document" });
    selectListItems.AddRange(Model.Templates.ToSelectListItems());
    selectListItems.AddRange(Model.TemplatePackages.ToSelectListItems());

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"Document_Generation_Container\"");

WriteLiteral(" data-targetid=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                      Write(HttpUtility.UrlEncode(Model.Target.AttachmentReferenceId));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-targettype=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                                                                                                   Write(Model.Target.HasAttachmentType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-generatepdfurl=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                                                                                                                                                         Write(Url.Action(MVC.API.DocumentTemplate.Generate()));

            
            #line default
            #line hidden
WriteLiteral("/\"");

WriteLiteral(" data-generatepackageurl=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                                                                                                                                                                                                                                     Write(Url.Action(MVC.API.DocumentTemplatePackage.Generate()));

            
            #line default
            #line hidden
WriteLiteral("/\"");

WriteLiteral(" data-handlerspresent=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                                                                                                                                                                                                                                                                                                                      Write(Model.HandlersPresent ? "true" : "false");

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-handlersurl=\"");

            
            #line 8 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Url.Action(MVC.API.DocumentTemplate.DocumentHandlers()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
   Write(Html.DropDownList("Document_Generate", selectListItems));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
         if (Model.HandlersPresent)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"Document_Generation_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Generate Document\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"handlerPicker\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-id=\"download\"");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-download fa-fw fa-lg\"");

WriteLiteral("></i>Download\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"Document_Generation_Dialog_Handlers_Loading\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"ajaxLoading\"");

WriteLiteral(" title=\"Loading\"");

WriteLiteral("></i>\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"details\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"Document_Generation_Dialog_Download_Container\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" id=\"Document_Generation_Dialog_Download\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Download Document</a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"Document_Generation_Dialog_HandlerUI\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 29 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 31 "..\..\Views\Shared\_GenerateDocumentControl.cshtml"
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-DocumentGenerator");
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591