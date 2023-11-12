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

namespace Disco.Web.Areas.Config.Views.UserFlag
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
    
    #line 1 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
    using Disco.Web.Areas.Config.Models.UserFlag;
    
    #line default
    #line hidden
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/UserFlag/Export.cshtml")]
    public partial class Export : Disco.Services.Web.WebViewPage<ExportModel>
    {
        public Export()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
  
    Authorization.RequireAny(Claims.Config.UserFlag.Export);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "User Flags", MVC.Config.UserFlag.Index(null), "Export");

    var optionsMetadata = ModelMetadata.FromLambdaExpression(m => m.Options, ViewData);
    var optionGroups = optionsMetadata.Properties.Where(p => p.ShortDisplayName != null && p.ModelType == typeof(bool) && p.PropertyName != "CurrentOnly")
        .GroupBy(m => m.ShortDisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"UserFlag_Export\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
     using (Html.BeginForm(MVC.API.UserFlag.Export()))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"UserFlag_Export_Scope\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 570px\"");

WriteLiteral(">\r\n            <h2>Export Scope</h2>\r\n            <table>\r\n                <tr>\r\n" +
"                    <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">\r\n                        User Flags:\r\n                    </th>\r\n              " +
"      <td>\r\n");

            
            #line 23 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                         foreach (var userFlag in Model.UserFlags)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div>\r\n                                <label>\r\n     " +
"                               <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"Options_UserFlagIds\"");

WriteLiteral(" name=\"Options.UserFlagIds\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1234), Tuple.Create("\"", 1254)
            
            #line 27 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                      , Tuple.Create(Tuple.Create("", 1242), Tuple.Create<System.Object, System.Int32>(userFlag.Id
            
            #line default
            #line hidden
, 1242), false)
);

WriteLiteral(" ");

            
            #line 27 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                Write(((bool)Model.Options.UserFlagIds.Contains(userFlag.Id)) ? "checked " : null);

            
            #line default
            #line hidden
WriteLiteral(" />\r\n                                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1377), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create("fa", 1385), true)
, Tuple.Create(Tuple.Create(" ", 1387), Tuple.Create("fa-", 1388), true)
            
            #line 28 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
, Tuple.Create(Tuple.Create("", 1391), Tuple.Create<System.Object, System.Int32>(userFlag.Icon
            
            #line default
            #line hidden
, 1391), false)
, Tuple.Create(Tuple.Create(" ", 1407), Tuple.Create("fa-lg", 1408), true)
, Tuple.Create(Tuple.Create(" ", 1413), Tuple.Create("d-", 1414), true)
            
            #line 28 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
, Tuple.Create(Tuple.Create("", 1416), Tuple.Create<System.Object, System.Int32>(userFlag.IconColour
            
            #line default
            #line hidden
, 1416), false)
);

WriteLiteral("></i>\r\n                                    <span>");

            
            #line 29 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                     Write(userFlag.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </label>\r\n                            </" +
"div>\r\n");

            
            #line 32 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n         " +
"           <th>");

            
            #line 36 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                   Write(Html.LabelFor(m => m.Options.CurrentOnly));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                   Write(Html.CheckBoxFor(m => m.Options.CurrentOnly));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <p>Uncheck to include all historical user flag assignme" +
"nts.</p>\r\n                    </td>\r\n                </tr>\r\n                <tr>" +
"\r\n                    <th>");

            
            #line 43 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                   Write(Html.LabelFor(m => m.Options.Format));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 45 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                   Write(Html.DropDownListFor(m => m.Options.Format, Enum.GetNames(typeof(Disco.Models.Exporting.ExportFormat)).Select(v => new SelectListItem() { Value = v, Text = v })));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n       " +
" </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"UserFlag_Export_Fields\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 570px; margin-top: 15px;\"");

WriteLiteral(">\r\n            <h2>Export Fields <a");

WriteLiteral(" id=\"UserFlag_Export_Fields_Defaults\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">(Defaults)</a></h2>\r\n            <table>\r\n");

            
            #line 53 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                 foreach (var optionGroup in optionGroups)
                {
                    var optionFields = optionGroup.ToList();
                    var itemsPerColumn = (int)Math.Ceiling((double)optionFields.Count / 2);

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <th");

WriteLiteral(" style=\"width: 120px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 59 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                       Write(optionGroup.Key);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 60 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                             if (optionFields.Count > 2)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(" class=\"select\"");

WriteLiteral("><a");

WriteLiteral(" class=\"selectAll\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">ALL</a> | <a");

WriteLiteral(" class=\"selectNone\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">NONE</a></span>\r\n");

            
            #line 63 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </th>\r\n                        <td>\r\n                    " +
"        <div");

WriteLiteral(" class=\"UserFlag_Export_Fields_Group\"");

WriteLiteral(">\r\n                                <table");

WriteLiteral(" class=\"none\"");

WriteLiteral(">\r\n                                    <tr>\r\n                                    " +
"    <td");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n                                            <ul");

WriteLiteral(" class=\"none\"");

WriteLiteral(">\r\n");

            
            #line 71 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                 foreach (var optionItem in optionFields.Take(itemsPerColumn))
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <li");

WriteAttribute("title", Tuple.Create(" title=\"", 3824), Tuple.Create("\"", 3855)
            
            #line 73 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
, Tuple.Create(Tuple.Create("", 3832), Tuple.Create<System.Object, System.Int32>(optionItem.Description
            
            #line default
            #line hidden
, 3832), false)
);

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3937), Tuple.Create("\"", 3974)
, Tuple.Create(Tuple.Create("", 3942), Tuple.Create("Options_", 3942), true)
            
            #line 74 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
           , Tuple.Create(Tuple.Create("", 3950), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 3950), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 3975), Tuple.Create("\"", 4014)
, Tuple.Create(Tuple.Create("", 3982), Tuple.Create("Options.", 3982), true)
            
            #line 74 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 3990), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 3990), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 74 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                                      Write(((bool)optionItem.Model) ? "checked " : null);

            
            #line default
            #line hidden
WriteLiteral("/><label");

WriteAttribute("for", Tuple.Create(" for=\"", 4084), Tuple.Create("\"", 4122)
, Tuple.Create(Tuple.Create("", 4090), Tuple.Create("Options_", 4090), true)
            
            #line 74 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 4098), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 4098), false)
);

WriteLiteral(">");

            
            #line 74 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                                                                                                                                    Write(optionItem.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label></li>\r\n");

            
            #line 75 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </ul>\r\n                              " +
"          </td>\r\n                                        <td");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n                                            <ul");

WriteLiteral(" class=\"none\"");

WriteLiteral(">\r\n");

            
            #line 80 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 80 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                 foreach (var optionItem in optionFields.Skip(itemsPerColumn))
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <li");

WriteAttribute("title", Tuple.Create(" title=\"", 4657), Tuple.Create("\"", 4688)
            
            #line 82 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
, Tuple.Create(Tuple.Create("", 4665), Tuple.Create<System.Object, System.Int32>(optionItem.Description
            
            #line default
            #line hidden
, 4665), false)
);

WriteLiteral(">\r\n                                                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("id", Tuple.Create(" id=\"", 4770), Tuple.Create("\"", 4807)
, Tuple.Create(Tuple.Create("", 4775), Tuple.Create("Options_", 4775), true)
            
            #line 83 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
           , Tuple.Create(Tuple.Create("", 4783), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 4783), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 4808), Tuple.Create("\"", 4847)
, Tuple.Create(Tuple.Create("", 4815), Tuple.Create("Options.", 4815), true)
            
            #line 83 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 4823), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 4823), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 83 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                                      Write(((bool)optionItem.Model) ? "checked " : null);

            
            #line default
            #line hidden
WriteLiteral("/><label");

WriteAttribute("for", Tuple.Create(" for=\"", 4917), Tuple.Create("\"", 4955)
, Tuple.Create(Tuple.Create("", 4923), Tuple.Create("Options_", 4923), true)
            
            #line 83 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 4931), Tuple.Create<System.Object, System.Int32>(optionItem.PropertyName
            
            #line default
            #line hidden
, 4931), false)
);

WriteLiteral(">");

            
            #line 83 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                                                                                                                                                                                                                                    Write(optionItem.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label></li>\r\n");

            
            #line 84 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral(@"                                            </ul>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>            
");

            
            #line 92 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </table>\r\n        </div>\r\n");

WriteLiteral("        <script>\r\n            $(function () {\r\n                var exportDefaultF" +
"ields = [\'Name\', \'AddedDate\', \'UserId\', \'UserDisplayName\', \'Comments\'];\r\n       " +
"         var $exportFields = $(\'#UserFlag_Export_Fields\');\r\n                var " +
"$exportScope = $(\'#UserFlag_Export_Scope\');\r\n                var $form = $export" +
"Scope.closest(\'form\');\r\n                var $exportingDialog = null;\r\n\r\n        " +
"        $exportFields.on(\'click\', \'a.selectAll,a.selectNone\', function () {\r\n   " +
"                 var $this = $(this);\r\n\r\n                    $this.closest(\'tr\')" +
".find(\'input\').prop(\'checked\', $this.is(\'.selectAll\'));\r\n\r\n                    r" +
"eturn false;\r\n                });\r\n\r\n                $(\'#UserFlag_Export_Fields_" +
"Defaults\').click(function () {\r\n\r\n                    $exportFields.find(\'input\'" +
").prop(\'checked\', false);\r\n\r\n                    $.each(exportDefaultFields, fun" +
"ction (index, value) {\r\n                        $(\'#Options_\' + value).prop(\'che" +
"cked\', true);\r\n                    });\r\n\r\n                    return false;\r\n   " +
"             });\r\n\r\n                // Submit Validation\r\n                functi" +
"on submitHandler() {\r\n                    var exportFieldCount = $exportFields.f" +
"ind(\'input:checked\').length;\r\n\r\n                    if (exportFieldCount > 0) {\r" +
"\n\r\n                        if ($exportingDialog == null) {\r\n                    " +
"        $exportingDialog = $(\'#UserFlag_Export_Exporting\').dialog({\r\n           " +
"                     width: 400,\r\n                                height: 164,\r\n" +
"                                resizable: false,\r\n                             " +
"   modal: true,\r\n                                autoOpen: false\r\n              " +
"              });\r\n                        }\r\n                        $exporting" +
"Dialog.dialog(\'open\');\r\n\r\n                        $form[0].submit();\r\n          " +
"          }\r\n                    else\r\n                        alert(\'Select at " +
"least one field to export.\');\r\n                }\r\n                $.validator.un" +
"obtrusive.parse($form);\r\n                $form.data(\"validator\").settings.submit" +
"Handler = submitHandler;\r\n\r\n                $(\'#UserFlag_Export_Download_Dialog\'" +
").dialog({\r\n                    width: 400,\r\n                    height: 164,\r\n " +
"                   resizable: false,\r\n                    modal: true,\r\n        " +
"            autoOpen: true\r\n                });\r\n                $(\'#UserFlag_Ex" +
"port_Button\').click(function () {\r\n                    $form.submit();\r\n        " +
"        });\r\n            });\r\n        </script>\r\n");

            
            #line 159 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 161 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
 if (Model.ExportSessionId != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"UserFlag_Export_Download_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Export User Flags\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 164 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
       Write(Model.ExportSessionResult.RecordCount);

            
            #line default
            #line hidden
WriteLiteral(" record");

            
            #line 164 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
                                                     Write(Model.ExportSessionResult.RecordCount != 1 ? "s" : null);

            
            #line default
            #line hidden
WriteLiteral(" were successfully exported.</h4>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 8226), Tuple.Create("\"", 8300)
            
            #line 165 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
, Tuple.Create(Tuple.Create("", 8233), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.UserFlag.ExportRetrieve(Model.ExportSessionId))
            
            #line default
            #line hidden
, 8233), false)
);

WriteLiteral(" class=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-download fa-lg\"");

WriteLiteral("></i>Download User Flag Export</a>\r\n    </div>\r\n");

WriteLiteral(@"    <script>
        $(function () {
            $('#UserFlag_Export_Download_Dialog')
                .dialog({
                    width: 400,
                    height: 164,
                    resizable: false,
                    modal: true,
                    autoOpen: true
                });
        });
    </script>
");

            
            #line 179 "..\..\Areas\Config\Views\UserFlag\Export.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" id=\"UserFlag_Export_Exporting\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Exporting User Flags...\"");

WriteLiteral(">\r\n    <h4><i");

WriteLiteral(" class=\"fa fa-lg fa-cog fa-spin\"");

WriteLiteral(" title=\"Please Wait\"");

WriteLiteral("></i>Exporting user flags...</h4>\r\n</div>\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"UserFlag_Export_Button\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Export User Flags</a>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591