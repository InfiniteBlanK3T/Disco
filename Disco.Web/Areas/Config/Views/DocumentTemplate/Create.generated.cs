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

namespace Disco.Web.Areas.Config.Views.DocumentTemplate
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/Create.cshtml")]
    public partial class Create : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DocumentTemplate.CreateModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
  
    Authorization.RequireAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates", MVC.Config.DocumentTemplate.Index(null), "Create");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
 using (Html.BeginForm(MVC.Config.DocumentTemplate.Create(), FormMethod.Post, new { enctype = "multipart/form-data" }))
{ 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    I" +
"d:\r\n                </th>\r\n                <td>");

            
            #line 15 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
               Write(Html.TextBoxFor(model => model.DocumentTemplate.Id));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 15 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
                                                                         Write(Html.ValidationMessageFor(model => model.DocumentTemplate.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Description:\r\n                </th>\r\n                <td>" +
"");

            
            #line 22 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
               Write(Html.TextBoxFor(model => model.DocumentTemplate.Description));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 22 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
                                                                                  Write(Html.ValidationMessageFor(model => model.DocumentTemplate.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Scope:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
               Write(Html.DropDownListFor(model => model.DocumentTemplate.Scope, Model.Scopes.ToSelectListItems(null)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Template PDF\r\n                </th>\r\n                <td>" +
"\r\n                    <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" name=\"Template\"");

WriteLiteral(" accept=\".pdf\"");

WriteLiteral(" /><br />");

            
            #line 38 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
                                                                        Write(Html.ValidationMessage("Template"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr");

WriteLiteral(" id=\"trJobTypes\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Types:\r\n                </th>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
               Write(CommonHelpers.CheckBoxList("Types", Model.JobTypes.ToSelectListItems(Model.Types), 2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 49 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
             foreach (var jt in Model.JobTypes)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteAttribute("id", Tuple.Create(" id=\"", 2046), Tuple.Create("\"", 2071)
, Tuple.Create(Tuple.Create("", 2051), Tuple.Create("trJobSubType", 2051), true)
            
            #line 51 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2063), Tuple.Create<System.Object, System.Int32>(jt.Id
            
            #line default
            #line hidden
, 2063), false)
);

WriteLiteral(" class=\"jobSubTypes\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 53 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
                   Write(jt.Description);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                        Sub Types<br />\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
               Write(CommonHelpers.CheckboxBulkSelect(string.Format("CheckboxBulkSelect_{0}", jt.Id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                    <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
                   Write(CommonHelpers.CheckBoxList("SubTypes", Model.JobSubTypes.Where(jst => jst.JobTypeId == jt.Id).ToList().ToSelectListItems(Model.SubTypes), 2));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>   \r\n");

            
            #line 61 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n        <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" />\r\n        </p>\r\n    </div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $('#Name').focus().select();

            var $scope = $('#DocumentTemplate_Scope');
            var $trJobTypes = $('#trJobTypes');
            var $jobTypes = $trJobTypes.find('input[type=""checkbox""]');
            $scope.change(scopeChange);
            $jobTypes.change(jobTypesChange);

            scopeChange();

            function scopeChange() {
                if ($scope.val() == 'Job') {
                    $trJobTypes.show();
                    jobTypesChange();
                } else {
                    $trJobTypes.hide();
                    $('.jobSubTypes').hide();
                }
            }

            function jobTypesChange() {
                $('.jobSubTypes').hide();
                $jobTypes.filter(':checked').each(function () {
                    $('#trJobSubType' + $(this).val()).show();    
                });
            }

        });
    </script>
");

            
            #line 98 "..\..\Areas\Config\Views\DocumentTemplate\Create.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
