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

namespace Disco.Web.Views.User
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/_UserDeviceAssignmentHistoryTable.cshtml")]
    public partial class UserDeviceAssignmentHistoryTable : System.Web.Mvc.WebViewPage<Disco.Models.Repository.User>
    {
        public UserDeviceAssignmentHistoryTable()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
  
    var userId = Model.Id;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
 if (Model.DeviceUserAssignments.Count > 0)
{ 

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"genericData smallTable\"");

WriteAttribute("id", Tuple.Create(" id=\"", 162), Tuple.Create("\"", 204)
, Tuple.Create(Tuple.Create("", 167), Tuple.Create("User_AssignedDevice_History_", 167), true)
            
            #line 7 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
, Tuple.Create(Tuple.Create("", 195), Tuple.Create<System.Object, System.Int32>(userId
            
            #line default
            #line hidden
, 195), false)
);

WriteLiteral(@">
        <tr>
            <th>
                Device Serial #
            </th>
            <th>
                Device Asset #
            </th>
            <th>
                Device Model
            </th>
            <th>
                Assigned
            </th>
            <th>
                Unassigned
            </th>
        </tr>
");

            
            #line 25 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
         foreach (var dua in Model.DeviceUserAssignments.OrderByDescending(m => m.AssignedDate))
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 695), Tuple.Create("\"", 763)
, Tuple.Create(Tuple.Create("", 703), Tuple.Create("assignmentActive", 703), true)
            
            #line 27 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
, Tuple.Create(Tuple.Create("", 719), Tuple.Create<System.Object, System.Int32>((!dua.UnassignedDate.HasValue).ToString()
            
            #line default
            #line hidden
, 719), false)
);

WriteLiteral(">\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
               Write(Html.ActionLink(dua.Device.SerialNumber, MVC.Device.Show(dua.DeviceSerialNumber)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 32 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
               Write(dua.Device.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
               Write(dua.Device.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
               Write(CommonHelpers.FriendlyDate(dua.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
               Write(CommonHelpers.FriendlyDate(dua.UnassignedDate, "Current"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 44 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 45 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
         if (Model.DeviceUserAssignments.Count(m => !m.UnassignedDate.HasValue) == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr");

WriteLiteral(" class=\"noActiveAssignments\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Active Assignments</span>\r\n                </td>\r\n            </tr>\r\n");

            
            #line 52 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

WriteLiteral("    <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1711), Tuple.Create("\"", 1761)
, Tuple.Create(Tuple.Create("", 1716), Tuple.Create("User_AssignedDevice_History_Trigger_", 1716), true)
            
            #line 54 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
, Tuple.Create(Tuple.Create("", 1752), Tuple.Create<System.Object, System.Int32>(userId
            
            #line default
            #line hidden
, 1752), false)
);

WriteLiteral(" class=\"smallLink\"");

WriteLiteral(">Show\r\n        All Assignment History (<span");

WriteAttribute("id", Tuple.Create(" id=\"", 1824), Tuple.Create("\"", 1878)
, Tuple.Create(Tuple.Create("", 1829), Tuple.Create("User_AssignedDevice_History_RecordCount_", 1829), true)
            
            #line 55 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
   , Tuple.Create(Tuple.Create("", 1869), Tuple.Create<System.Object, System.Int32>(userId
            
            #line default
            #line hidden
, 1869), false)
);

WriteLiteral("></span>)</a>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var $table = $(\'#User_AssignedDevice_Hist" +
"ory_");

            
            #line 58 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
                                                     Write(userId);

            
            #line default
            #line hidden
WriteLiteral(@"');
            var $inactiveRecords = $table.find('tr.assignmentActiveFalse').hide();
            if ($inactiveRecords.length != 0) {
                var recordCountText = $inactiveRecords.length + ' record';
                if ($inactiveRecords.length != 1)
                    recordCountText += 's';
                $('#User_AssignedDevice_History_RecordCount_");

            
            #line 64 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
                                                        Write(userId);

            
            #line default
            #line hidden
WriteLiteral("\').text(recordCountText);\r\n                $(\'#User_AssignedDevice_History_Trigge" +
"r_");

            
            #line 65 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
                                                    Write(userId);

            
            #line default
            #line hidden
WriteLiteral(@"').click(function () {
                    $(this).hide();
                    $table.find('tr.noActiveAssignments').hide();
                    $inactiveRecords.show();
                    return false;
                });
            } else {
                $('#User_AssignedDevice_History_Trigger_");

            
            #line 72 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
                                                    Write(userId);

            
            #line default
            #line hidden
WriteLiteral("\').hide();\r\n            }\r\n        });\r\n    </script>\r\n");

            
            #line 76 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
}
else
{ 

            
            #line default
            #line hidden
WriteLiteral("    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Assignment History Available</span>\r\n");

            
            #line 80 "..\..\Views\User\_UserDeviceAssignmentHistoryTable.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
