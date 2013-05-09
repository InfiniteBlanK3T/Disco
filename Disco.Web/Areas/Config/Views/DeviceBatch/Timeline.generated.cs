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

namespace Disco.Web.Areas.Config.Views.DeviceBatch
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceBatch/Timeline.cshtml")]
    public partial class Timeline : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Timeline()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Config\Views\DeviceBatch\Timeline.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Batches", MVC.Config.DeviceBatch.Index(null), "Timeline");
    Html.BundleDeferred("~/Style/Timeline");
    Html.BundleDeferred("~/ClientScripts/Modules/Timeline");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"deviceBatchesTimeline\"");

WriteLiteral(" style=\"height: 550px;\"");

WriteLiteral(">\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    (function () {\r\n        var dataUrl = \'");

            
            #line 10 "..\..\Areas\Config\Views\DeviceBatch\Timeline.cshtml"
                   Write(Url.Action(MVC.API.DeviceBatch.Timeline()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var tl;\r\n\r\n        $(function () {\r\n\r\n            var eventSource = n" +
"ew Timeline.DefaultEventSource();\r\n\r\n            var currentDate = new Date();\r\n" +
"            currentDate = new Date(currentDate.getFullYear(), currentDate.getMon" +
"th(), currentDate.getDay(), 10, 0, 0);\r\n            var tomorrowDate = new Date(" +
");\r\n            tomorrowDate.setDate(currentDate.getDate() + 1);\r\n            va" +
"r sixMonthsDate = new Date();\r\n            sixMonthsDate.setDate(currentDate.get" +
"Date());\r\n            sixMonthsDate.setMonth(currentDate.getMonth() + 6);\r\n     " +
"       \r\n            var hotZoneStart1 = new Date(currentDate.getFullYear(), 0, " +
"1, 10, 0, 0);\r\n            var hotZoneEnd1 = new Date(currentDate.getFullYear()," +
" 11, 31, 10, 0, 0);\r\n            var hotZoneStart2 = new Date(currentDate.getFul" +
"lYear() + 1, 0, 1, 10, 0, 0);\r\n            var hotZoneEnd2 = new Date(currentDat" +
"e.getFullYear() + 1, 11, 31, 10, 0, 0);\r\n            //hotZoneEnd.setDate(hotZon" +
"eEnd.getDate() - 1);\r\n\r\n            //hotZoneStart = hotZoneStart.toLocaleDateSt" +
"ring();\r\n            //hotZoneEnd = hotZoneEnd.toLocaleDateString();\r\n\r\n\r\n      " +
"      var bandInfos = [\r\n                Timeline.createHotZoneBandInfo({\r\n     " +
"               zones: [\r\n                    {\r\n                        start: h" +
"otZoneStart1,\r\n                        end: hotZoneEnd1,\r\n                      " +
"  magnify: 4,\r\n                        unit: Timeline.DateTime.MONTH\r\n          " +
"          },\r\n                    {\r\n                        start: hotZoneStart" +
"2,\r\n                        end: hotZoneEnd2,\r\n                        magnify: " +
"4,\r\n                        unit: Timeline.DateTime.MONTH\r\n                    }" +
"\r\n                    ],\r\n                    eventSource: eventSource,\r\n       " +
"             width: \"85%\",\r\n                    intervalUnit: Timeline.DateTime." +
"YEAR,\r\n                    intervalPixels: 150,\r\n                    timeZone: 1" +
"0,\r\n                    date: sixMonthsDate\r\n                }),\r\n              " +
"  Timeline.createBandInfo({\r\n                    eventSource: eventSource,\r\n    " +
"                width: \"15%\",\r\n                    intervalUnit: Timeline.DateTi" +
"me.YEAR,\r\n                    intervalPixels: 150,\r\n                    overview" +
": true,\r\n                    timeZone: 10,\r\n                    date: sixMonthsD" +
"ate\r\n                })\r\n            ];\r\n            bandInfos[1].syncWith = 0;\r" +
"\n            bandInfos[1].highlight = true;\r\n\r\n            for (var i = 0; i < b" +
"andInfos.length; i++) {\r\n                bandInfos[i].decorators = [\r\n          " +
"          new Timeline.SpanHighlightDecorator({\r\n                        startDa" +
"te: currentDate,\r\n                        endDate: tomorrowDate,\r\n              " +
"          color: \"#CC2222\",\r\n                        opacity: 50\r\n              " +
"      }),\r\n                    new Timeline.SpanHighlightDecorator({\r\n          " +
"              startDate: hotZoneStart1,\r\n                        endDate: hotZon" +
"eEnd1,\r\n                        color: \"#CEA5A5\",\r\n                        opaci" +
"ty: 50\r\n                    }),\r\n                    new Timeline.SpanHighlightD" +
"ecorator({\r\n                        startDate: hotZoneStart2,\r\n                 " +
"       endDate: hotZoneEnd2,\r\n                        color: \"#CCB7B7\",\r\n       " +
"                 opacity: 50\r\n                    })\r\n                ];\r\n      " +
"      }\r\n\r\n            tl = Timeline.create($(\'#deviceBatchesTimeline\')[0], band" +
"Infos);\r\n\r\n            var tlResizeLayoutHandle = null;\r\n            $(window).r" +
"esize(function () {\r\n                if (tlResizeLayoutHandle)\r\n                " +
"    window.clearTimeout(tlResizeLayoutHandle);\r\n                tlResizeLayoutHa" +
"ndle = window.setTimeout(function () {\r\n                    tlResizeLayoutHandle" +
" = null;\r\n                    tl.layout();\r\n                }, 500);\r\n          " +
"  });\r\n\r\n            // Load Events\r\n            $.ajax({\r\n                url: " +
"dataUrl,\r\n                dataType: \'json\',\r\n                type: \'POST\',\r\n    " +
"            success: function (data) {\r\n                    eventSource.loadJSON" +
"(data, dataUrl);\r\n                },\r\n                error: function (jqXHR, te" +
"xtStatus, errorThrown) {\r\n                    alert(\'Unable to load Timeline Dat" +
"a: \' + errorThrown);\r\n                }\r\n            });\r\n        });\r\n\r\n    })(" +
");\r\n\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
