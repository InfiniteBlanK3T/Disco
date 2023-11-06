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

namespace Disco.Web.Areas.Config.Views.Logging
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
    
    #line 2 "..\..\Areas\Config\Views\Logging\Index.cshtml"
    using Disco.Services.Logging;
    
    #line default
    #line hidden
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Logging/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.Logging.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Config\Views\Logging\Index.cshtml"
  
    Authorization.Require(Claims.Config.Logging.Show);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Logging");
    Html.BundleDeferred("~/ClientScripts/Modules/jQueryUI-TimePicker");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\Config\Views\Logging\Index.cshtml"
 using (Html.BeginForm(MVC.API.Logging.RetrieveEvents()))
{ 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 520px;\"");

WriteLiteral(">\r\n        <h2>Export Logs</h2>\r\n        <table>\r\n            <tr>\r\n             " +
"   <th");

WriteLiteral(" style=\"width: 105px;\"");

WriteLiteral(">Start Filter\r\n                </th>\r\n                <td>\r\n                    <" +
"input");

WriteLiteral(" id=\"filterStart\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"Start\"");

WriteLiteral(" />\r\n                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">* Optional</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n " +
"               <th>End Filter\r\n                </th>\r\n                <td>\r\n    " +
"                <input");

WriteLiteral(" id=\"filterEnd\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"End\"");

WriteLiteral(" />\r\n                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">* Optional</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n " +
"               <th>Limit Filter\r\n                </th>\r\n                <td>\r\n  " +
"                  <select");

WriteLiteral(" name=\"Take\"");

WriteLiteral(">\r\n                        <option");

WriteLiteral(" selected=\"selected\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">- All Events -</option>\r\n                        <option");

WriteLiteral(" value=\"1000\"");

WriteLiteral(">1,000 Events</option>\r\n                        <option");

WriteLiteral(" value=\"500\"");

WriteLiteral(">500 Events</option>\r\n                        <option");

WriteLiteral(" value=\"100\"");

WriteLiteral(">100 Events</option>\r\n                        <option");

WriteLiteral(" value=\"50\"");

WriteLiteral(">50 Events</option>\r\n                        <option");

WriteLiteral(" value=\"10\"");

WriteLiteral(">10 Events</option>\r\n                    </select>\r\n                </td>\r\n      " +
"      </tr>\r\n            <tr>\r\n                <th>Module Filter\r\n              " +
"  </th>\r\n                <td>\r\n                    <select");

WriteLiteral(" id=\"moduleId\"");

WriteLiteral(" name=\"ModuleId\"");

WriteLiteral(">\r\n                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected=\"selected\"");

WriteLiteral(">- All Modules -</option>\r\n");

            
            #line 50 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                         foreach (var lm in Model.LogModules.Keys.OrderBy(lm => lm.ModuleDescription))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2082), Tuple.Create("\"", 2102)
            
            #line 52 "..\..\Areas\Config\Views\Logging\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create<System.Object, System.Int32>(lm.ModuleId
            
            #line default
            #line hidden
, 2090), false)
);

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                                                    Write(lm.ModuleDescription);

            
            #line default
            #line hidden
WriteLiteral("</option>    \r\n");

            
            #line 53 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </td>\r\n            </tr>\r\n        " +
"    <tr");

WriteLiteral(" id=\"trLogModuleEventTypes\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n                <th>Event Type Filter <span");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(" class=\"checkboxBulkSelectContainer\"");

WriteLiteral(">Select: <a");

WriteLiteral(" id=\"eventTypesSelectAll\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">ALL</a> | <a");

WriteLiteral(" id=\"eventTypesSelectNone\"");

WriteLiteral("\r\n                    href=\"#\"");

WriteLiteral(">NONE</a></span>\r\n                </th>\r\n                <td>\r\n");

            
            #line 62 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 62 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                      int uniqueIdSeed = 0;
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 64 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                     foreach (var lm in Model.LogModules)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" data-logmoduleid=\"");

            
            #line 66 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                                          Write(lm.Key.ModuleId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"logModuleEventTypes\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                       Write(CommonHelpers.CheckBoxList("EventTypeIds", lm.Value.ToSelectListItems(), 2, false, uniqueIdSeed));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 69 "..\..\Areas\Config\Views\Logging\Index.cshtml"
                        uniqueIdSeed += lm.Value.Count;
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <th><" +
"/th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 76 "..\..\Areas\Config\Views\Logging\Index.cshtml"
               Write(Html.Hidden("Format", "CSV"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Download CSV\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                var filterStart = $(\'#filterStart" +
"\').watermark(\'Start\').datetimepicker({\r\n                    ampm: true,\r\n       " +
"             stepMinute: 1,\r\n                    changeYear: true,\r\n            " +
"        changeMonth: true,\r\n                    dateFormat: \'yy/mm/dd\'\r\n        " +
"        });\r\n                var filterEnd = $(\'#filterEnd\').watermark(\'End\').da" +
"tetimepicker({\r\n                    ampm: true,\r\n                    stepMinute:" +
" 1,\r\n                    changeYear: true,\r\n                    changeMonth: tru" +
"e,\r\n                    dateFormat: \'yy/mm/dd\'\r\n                });\r\n           " +
"     var moduleId = $(\'#moduleId\');\r\n                var trLogModuleEventTypes =" +
" $(\'#trLogModuleEventTypes\');\r\n                var logModuleEventTypes = trLogMo" +
"duleEventTypes.find(\'.logModuleEventTypes\').hide();\r\n                var logModu" +
"leEventTypeCheckboxes = logModuleEventTypes.find(\'input[type=\"checkbox\"]\');\r\n\r\n " +
"               moduleId.change(function () {\r\n                    // Unselect Al" +
"l\r\n                    logModuleEventTypes.slideUp();\r\n                    logMo" +
"duleEventTypeCheckboxes.filter(\':checked\').prop(\'checked\', false);\r\n            " +
"        var selectedModule = moduleId.val();\r\n                    if (selectedMo" +
"dule) {\r\n                        trLogModuleEventTypes.show();\r\n                " +
"        var selectedModuleEventTypes = logModuleEventTypes.filter(\'[data-logmodu" +
"leid=\"\' + selectedModule + \'\"]\');\r\n                        if (selectedModuleEve" +
"ntTypes.length > 0) {\r\n                            var selectedModuleEventTypeCh" +
"eckboxes = selectedModuleEventTypes.find(\'input[type=\"checkbox\"]\');\r\n           " +
"                 selectedModuleEventTypeCheckboxes.prop(\'checked\', true);\r\n     " +
"                       trLogModuleEventTypes.show();\r\n                          " +
"  selectedModuleEventTypes.slideDown();\r\n                        } else {\r\n     " +
"                       trLogModuleEventTypes.hide();\r\n                        }\r" +
"\n                    } else {\r\n                        trLogModuleEventTypes.hid" +
"e();\r\n                    }\r\n                });\r\n\r\n                $(\'#eventTyp" +
"esSelectAll\').click(function () {\r\n                    var selectedModule = modu" +
"leId.val();\r\n                    if (selectedModule) {\r\n                        " +
"var selectedModuleEventTypes = logModuleEventTypes.filter(\'[data-logmoduleid=\"\' " +
"+ selectedModule + \'\"]\');\r\n                        if (selectedModuleEventTypes." +
"length > 0) {\r\n                            var selectedModuleEventTypeCheckboxes" +
" = selectedModuleEventTypes.find(\'input[type=\"checkbox\"]\');\r\n                   " +
"         selectedModuleEventTypeCheckboxes.prop(\'checked\', true);\r\n             " +
"           }\r\n                    }\r\n                    return false;\r\n        " +
"        });\r\n                $(\'#eventTypesSelectNone\').click(function () {\r\n   " +
"                 var selectedModule = moduleId.val();\r\n                    if (s" +
"electedModule) {\r\n                        var selectedModuleEventTypes = logModu" +
"leEventTypes.filter(\'[data-logmoduleid=\"\' + selectedModule + \'\"]\');\r\n           " +
"             if (selectedModuleEventTypes.length > 0) {\r\n                       " +
"     var selectedModuleEventTypeCheckboxes = selectedModuleEventTypes.find(\'inpu" +
"t[type=\"checkbox\"]\');\r\n                            selectedModuleEventTypeCheckb" +
"oxes.prop(\'checked\', false);\r\n                        }\r\n                    }\r\n" +
"                    return false;\r\n                });\r\n\r\n            });\r\n     " +
"   </script>\r\n    </div>\r\n");

            
            #line 149 "..\..\Areas\Config\Views\Logging\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<h2>Live Logging</h2>\r\n");

            
            #line 151 "..\..\Areas\Config\Views\Logging\Index.cshtml"
Write(Html.Partial(MVC.Config.Shared.Views.LogEvents, new Disco.Web.Areas.Config.Models.Shared.LogEventsModel()
{
    IsLive = true,
    TakeFilter = 100,
    StartFilter = DateTime.Today.AddDays(-1),
    ViewPortHeight = 450
}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
