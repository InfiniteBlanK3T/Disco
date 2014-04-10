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
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Logging/TaskStatus.cshtml")]
    public partial class TaskStatus : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.Logging.TaskStatusModel>
    {
        public TaskStatus()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Logging\TaskStatus.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Logging", MVC.Config.Logging.Index(), "Task Status");
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" style=\"min-height: 300px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"scheduledTaskStatus\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 520px;\"");

WriteLiteral(" data-bind=\"visible: Initialized\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" data-bind=\"text: TaskName\"");

WriteLiteral(">&nbsp;</h2>\r\n        <table>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" class=\"process\"");

WriteLiteral(" data-bind=\"text: CurrentProcess\"");

WriteLiteral(">&nbsp;\r\n                </th>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(" data-bind=\"text: CurrentDescription\"");

WriteLiteral(">&nbsp;\r\n                </td>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-bind=\"progressValue: Progress\"");

WriteLiteral(">\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        " +
"    <tr");

WriteLiteral(" data-bind=\"visible: FinishedTimestamp\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"finishedTimestamp\"");

WriteLiteral(">\r\n                    <h3>Finished: <span");

WriteLiteral(" data-bind=\"text: FinishedTimestampFormatted\"");

WriteLiteral("></span>\r\n                    </h3>\r\n                </td>\r\n            </tr>\r\n  " +
"          <tr");

WriteLiteral(" data-bind=\"visible: FinishedTimestamp() && !TaskExceptionMessage()\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"finishedMessage\"");

WriteLiteral(" data-bind=\"css: { finishedRedirect: FinishedUrl }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: FinishedMessage\"");

WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: TaskExceptionMessage\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"exception\"");

WriteLiteral(">Last Error:\r\n                    <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(" data-bind=\"text: TaskExceptionMessage\"");

WriteLiteral(">\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        " +
"    <tr");

WriteLiteral(" data-bind=\"visible: NextScheduledTimestamp\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"nextScheduledTimestamp\"");

WriteLiteral(">Next Scheduled: <span");

WriteLiteral(" data-bind=\"text: NextScheduledTimestampFormatted\"");

WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r" +
"\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    ko.bindingHandlers.progressValue = {\r\n        init: function (element, val" +
"ueAccessor, allBindingsAccessor, viewModel) {\r\n            var $element = $(elem" +
"ent);\r\n            if (!$element.is(\'.ui-progressbar\'))\r\n                $elemen" +
"t.progressbar();\r\n        },\r\n        update: function (element, valueAccessor, " +
"allBindingsAccessor, viewModel) {\r\n            var v = ko.utils.unwrapObservable" +
"(valueAccessor());\r\n            var vInt = parseInt(v);\r\n            if (vInt >=" +
" 0) {\r\n                $(element).progressbar(\'option\', \'value\', vInt);\r\n       " +
"     }\r\n        }\r\n    };\r\n    //* http://webcloud.se/log/JavaScript-and-ISO-860" +
"1/\r\n    Date.prototype.setISO8601 = function (string) {\r\n        var regexp = \"(" +
"[0-9]{4})(-([0-9]{2})(-([0-9]{2})\" +\r\n        \"(T([0-9]{2}):([0-9]{2})(:([0-9]{2" +
"})(\\.([0-9]+))?)?\" +\r\n        \"(Z|(([-+])([0-9]{2}):([0-9]{2})))?)?)?)?\";\r\n     " +
"   var d = string.match(new RegExp(regexp));\r\n\r\n        var offset = 0;\r\n       " +
" var date = new Date(d[1], 0, 1);\r\n\r\n        if (d[3]) { date.setMonth(d[3] - 1)" +
"; }\r\n        if (d[5]) { date.setDate(d[5]); }\r\n        if (d[7]) { date.setHour" +
"s(d[7]); }\r\n        if (d[8]) { date.setMinutes(d[8]); }\r\n        if (d[10]) { d" +
"ate.setSeconds(d[10]); }\r\n        if (d[12]) { date.setMilliseconds(Number(\"0.\" " +
"+ d[12]) * 1000); }\r\n        if (d[14]) {\r\n            offset = (Number(d[16]) *" +
" 60) + Number(d[17]);\r\n            offset *= ((d[15] == \'-\') ? 1 : -1);\r\n       " +
" }\r\n\r\n        offset -= date.getTimezoneOffset();\r\n        time = (Number(date) " +
"+ (offset * 60 * 1000));\r\n        this.setTime(Number(time));\r\n        return th" +
"is;\r\n    }\r\n</script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var sessionId = \'");

            
            #line 93 "..\..\Areas\Config\Views\Logging\TaskStatus.cshtml"
                     Write(Model.SessionId);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var sessionStatusUrl = \'");

            
            #line 94 "..\..\Areas\Config\Views\Logging\TaskStatus.cshtml"
                            Write(Url.Action(MVC.API.Logging.ScheduledTaskStatus(Model.SessionId)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        var view = $(\'#scheduledTaskStatus\');\r\n        var vm = null;\r\n\r\n  " +
"      var liveConnection = null;\r\n\r\n        var statusViewModel = function (sess" +
"ionId) {\r\n            var self = this;\r\n\r\n            self.Initialized = ko.obse" +
"rvable(false);\r\n\r\n            self.TimestampParse = function (timestamp) {\r\n    " +
"            if (timestamp) {\r\n                    if (timestamp.indexOf(\"\\/Date(" +
"\") == 0)\r\n                        return new Date(parseInt(timestamp.substr(6)))" +
";\r\n                    else\r\n                        return (new Date()).setISO8" +
"601(timestamp);\r\n                }\r\n                return new Date();\r\n        " +
"    }\r\n            self.TimestampFormat = function (timestamp) {\r\n              " +
"  var addZero = function (v) { v = v + \'\'; if (v.length == 1) v = \'0\' + v; retur" +
"n v; }\r\n                return timestamp.getFullYear() + \'/\' + addZero((1 + time" +
"stamp.getMonth())) + \'/\' + addZero(timestamp.getDate()) + \' \' + addZero(timestam" +
"p.getHours()) + \':\' + addZero(timestamp.getMinutes()) + \':\' + addZero(timestamp." +
"getSeconds());\r\n            }\r\n\r\n            self.SessionId = sessionId;\r\n      " +
"      self.TaskName = ko.observable(null);\r\n            self.StatusVersion = -1;" +
"\r\n\r\n            self.Progress = ko.observable(0);\r\n            self.CurrentProce" +
"ss = ko.observable(null);\r\n            self.CurrentDescription = ko.observable(n" +
"ull);\r\n\r\n            self.IsRunning = ko.observable(null);\r\n\r\n            self.T" +
"askExceptionMessage = ko.observable(null);\r\n\r\n            self.FinishedTimestamp" +
" = ko.observable(null);\r\n            self.NextScheduledTimestamp = ko.observable" +
"(null)\r\n\r\n            self.NextScheduledTimestampFormatted = ko.computed(functio" +
"n () {\r\n                return self.TimestampFormat(self.TimestampParse(self.Nex" +
"tScheduledTimestamp()));\r\n            });\r\n            self.FinishedTimestampFor" +
"matted = ko.computed(function () {\r\n                return self.TimestampFormat(" +
"self.TimestampParse(self.FinishedTimestamp()));\r\n            });\r\n\r\n            " +
"self.FinishedUrl = ko.observable(null);\r\n            self.FinishedMessage = ko.o" +
"bservable(null);\r\n\r\n            self.Finished = function () {\r\n                i" +
"f (self.FinishedTimestamp()) {\r\n                    if (self.FinishedUrl() && !s" +
"elf.TaskExceptionMessage()) {\r\n                        if (self.FinishedMessage(" +
"))\r\n                            window.setTimeout(function () { window.location." +
"href = self.FinishedUrl(); }, 3000);\r\n                        else\r\n            " +
"                window.location.href = self.FinishedUrl();\r\n                    " +
"}\r\n                }\r\n            }\r\n\r\n            self.Initialize = function (t" +
"askStatus) {\r\n                self.TaskName(taskStatus.TaskName);\r\n             " +
"   self.FinishedUrl(taskStatus.FinishedUrl);\r\n\r\n                self.Progress(ta" +
"skStatus.Progress);\r\n                self.CurrentProcess(taskStatus.CurrentProce" +
"ss);\r\n                self.CurrentDescription(taskStatus.CurrentDescription);\r\n\r" +
"\n                self.IsRunning(taskStatus.IsRunning);\r\n\r\n                self.T" +
"askExceptionMessage(taskStatus.TaskExceptionMessage);\r\n\r\n                self.Fi" +
"nishedTimestamp(taskStatus.FinishedTimestamp);\r\n                self.NextSchedul" +
"edTimestamp(taskStatus.NextScheduledTimestamp);\r\n\r\n                self.Finished" +
"Message(taskStatus.FinishedMessage);\r\n\r\n                self.Initialized(true);\r" +
"\n\r\n                self.Finished();\r\n            }\r\n            self.Update = fu" +
"nction (taskStatus) {\r\n                if (!self.Initialized())\r\n               " +
"     return self.Initialize(taskStatus);\r\n\r\n                if (taskStatus.Statu" +
"sVersion < self.StatusVersion)\r\n                    return; // Have Newer Status" +
" Update\r\n                self.StatusVersion = taskStatus.StatusVersion;\r\n\r\n     " +
"           if (taskStatus.ChangedProperties) {\r\n                    for (var cha" +
"ngedPropertyIndex = 0; changedPropertyIndex < taskStatus.ChangedProperties.lengt" +
"h; changedPropertyIndex++) {\r\n                        switch (taskStatus.Changed" +
"Properties[changedPropertyIndex]) {\r\n                            case \'Progress\'" +
":\r\n                                self.Progress(taskStatus.Progress);\r\n        " +
"                        break;\r\n                            case \'CurrentProcess" +
"\':\r\n                                self.CurrentProcess(taskStatus.CurrentProces" +
"s);\r\n                                break;\r\n                            case \'C" +
"urrentDescription\':\r\n                                self.CurrentDescription(tas" +
"kStatus.CurrentDescription);\r\n                                break;\r\n          " +
"                  case \'IsRunning\':\r\n                                self.IsRunn" +
"ing(taskStatus.IsRunning);\r\n                                break;\r\n            " +
"                case \'TaskException\':\r\n                                self.Task" +
"ExceptionMessage(taskStatus.TaskExceptionMessage);\r\n                            " +
"    break;\r\n                            case \'NextScheduledTimestamp\':\r\n        " +
"                        self.NextScheduledTimestamp(taskStatus.NextScheduledTime" +
"stamp);\r\n                                break;\r\n                            cas" +
"e \'FinishedUrl\':\r\n                                self.FinishedUrl(taskStatus.Fi" +
"nishedUrl);\r\n                                break;\r\n                           " +
" case \'FinishedMessage\':\r\n                                self.FinishedMessage(t" +
"askStatus.FinishedMessage);\r\n                                break;\r\n           " +
"                 case \'FinishedTimestamp\':\r\n                                self" +
".FinishedTimestamp(taskStatus.FinishedTimestamp);\r\n                             " +
"   window.setTimeout(self.Finished, 1);\r\n                                break;\r" +
"\n                            default:\r\n                                // Ignore" +
"\r\n                        }\r\n                    }\r\n                }\r\n         " +
"   }\r\n        }\r\n\r\n        vm = new statusViewModel(sessionId);\r\n        ko.appl" +
"yBindings(vm, view[0]);\r\n\r\n        // Start Live Connection\r\n        updateWithL" +
"ive();\r\n\r\n        function updateWithAjax(onSuccess) {\r\n            $.ajax({\r\n  " +
"              url: sessionStatusUrl,\r\n                dataType: \'json\',\r\n       " +
"         type: \'POST\',\r\n                traditional: true,\r\n                succ" +
"ess: update_Received,\r\n                error: function (jqXHR, textStatus, error" +
"Thrown) {\r\n                    alert(\'Unable to load Session: \' + errorThrown);\r" +
"\n                }\r\n            });\r\n        }\r\n        function updateWithLive(" +
") {\r\n            liveConnection = $.connection(\'");

            
            #line 243 "..\..\Areas\Config\Views\Logging\TaskStatus.cshtml"
                                       Write(Url.Content("~/API/Logging/TaskStatusNotifications"));

            
            #line default
            #line hidden
WriteLiteral(@"', { addToGroups: sessionId });
            liveConnection.received(update_Received);
            liveConnection.error(function (e) { if (e.status != 200) alert('Live-Status Error: ' + e.statusText + ': ' + e.responseText); });
            liveConnection.start(function () {
                updateWithAjax();
            });
        }
        function update_Received(taskStatus) {
            vm.Update(taskStatus);
        }

    });
</script>
");

        }
    }
}
#pragma warning restore 1591
