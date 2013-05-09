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

namespace Disco.Web.Views.Device.DeviceParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/DeviceParts/Resources.cshtml")]
    public partial class Resources : System.Web.Mvc.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public Resources()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\DeviceParts\Resources.cshtml"
  
    Html.BundleDeferred("~/Style/Shadowbox");
    Html.BundleDeferred("~/ClientScripts/Modules/Shadowbox");

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"deviceShowResources\"");

WriteLiteral(">\r\n    <tr>\r\n        <td");

WriteLiteral(" id=\"Attachments\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"attachmentOutput\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                 if (Model.Device.DeviceAttachments != null)
                {
                    foreach (var da in Model.Device.DeviceAttachments)
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 476), Tuple.Create("\"", 536)
            
            #line 14 "..\..\Views\Device\DeviceParts\Resources.cshtml"
, Tuple.Create(Tuple.Create("", 483), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentDownload(da.Id))
            
            #line default
            #line hidden
, 483), false)
);

WriteLiteral(" data-attachmentid=\"");

            
            #line 14 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                                                  Write(da.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-mimetype=\"");

            
            #line 14 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                                                                         Write(da.MimeType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"icon\"");

WriteAttribute("title", Tuple.Create(" title=\"", 638), Tuple.Create("\"", 658)
            
            #line 15 "..\..\Views\Device\DeviceParts\Resources.cshtml"
, Tuple.Create(Tuple.Create("", 646), Tuple.Create<System.Object, System.Int32>(da.Filename
            
            #line default
            #line hidden
, 646), false)
);

WriteLiteral(">\r\n                            <img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteAttribute("src", Tuple.Create(" src=\"", 721), Tuple.Create("\"", 783)
            
            #line 16 "..\..\Views\Device\DeviceParts\Resources.cshtml"
, Tuple.Create(Tuple.Create("", 727), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentThumbnail(da.Id))
            
            #line default
            #line hidden
, 727), false)
);

WriteLiteral(" /></span>\r\n                        <span");

WriteLiteral(" class=\"comments\"");

WriteAttribute("title", Tuple.Create(" title=\"", 842), Tuple.Create("\"", 862)
            
            #line 17 "..\..\Views\Device\DeviceParts\Resources.cshtml"
, Tuple.Create(Tuple.Create("", 850), Tuple.Create<System.Object, System.Int32>(da.Comments
            
            #line default
            #line hidden
, 850), false)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                              if (!string.IsNullOrEmpty(da.DocumentTemplateId))
                              { 
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                           Write(da.DocumentTemplate.Description);

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                }
                              else
                              { 
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                           Write(da.Comments);

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                             }
            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                               Write(da.TechUser.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span><span");

WriteLiteral(" class=\"remove\"");

WriteLiteral("></span><span");

WriteLiteral(" class=\"timestamp\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1232), Tuple.Create("\"", 1270)
            
            #line 22 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 1240), Tuple.Create<System.Object, System.Int32>(da.Timestamp.ToFullDateTime()
            
            #line default
            #line hidden
, 1240), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                                                                                                                        Write(da.Timestamp.ToFuzzy());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </a>   \r\n");

            
            #line 24 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"attachmentInput clearfix\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"action upload\"");

WriteLiteral("></span><span");

WriteLiteral(" class=\"action photo\"");

WriteLiteral("></span>\r\n            </div>\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                Shadowbox.init({
                    skipSetup: true,
                    modal: true
                });
                $(function () {
                    if (!document.DiscoFunctions) {
                        document.DiscoFunctions = {};
                    }
                    document.DiscoFunctions.addAttachment = addAttachment;

                    $Attachments = $('#Attachments');
                    $attachmentOutput = $Attachments.find('.attachmentOutput');

                    $attachmentOutput.find('span.remove').click(removeAttachment);

                    $('#dialogUpload').dialog({ autoOpen: false,
                        draggable: false,
                        modal: true,
                        resizable: false,
                        width: 860,
                        height: 550,
                        close: function () {
                            silverlightUploadAttachment.content.Navigator.Navigate('/Hidden');
                        }
                    });

                    $('#dialogRemoveAttachment').dialog({
                        resizable: false,
                        height: 140,
                        modal: true,
                        autoOpen: false
                    });

                    var onLoadNavigation = null;
                    var isLoaded = null;
                    Silverlight.createObject(
                            '");

            
            #line 67 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                         Write(Links.ClientBin.Disco_Silverlight_AttachmentUpload_xap);

            
            #line default
            #line hidden
WriteLiteral(@"',
                            $('#silverlightHostUploadAttachment').get(0),
                            'silverlightUploadAttachment',
                            { width: '840px', height: '500px', background: 'white', version: '4.0.60310.0' },
                            { onLoad: function () {
                                if (onLoadNavigation) {
                                    silverlightUploadAttachment.content.Navigator.Navigate(onLoadNavigation);
                                    isLoaded = true;
                                }
                            }
                            },
                            'UploadUrl=");

            
            #line 78 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                   Write(Url.Action(MVC.API.Device.AttachmentUpload(Model.Device.SerialNumber, null)));

            
            #line default
            #line hidden
WriteLiteral(@"'
                        );

                    $attachmentInput = $Attachments.find('.attachmentInput');
                    $attachmentInput.find('.photo').click(function () {
                        showDialog('/WebCam');
                    });
                    $attachmentInput.find('.upload').click(function () {
                        showDialog('/File');
                    });

                    silverlightUploadAttachment = $('#silverlightUploadAttachment').get(0);
                    function showDialog(navigationPath) {
                        $('#dialogUpload').dialog('open');
                        if (isLoaded) {
                            silverlightUploadAttachment.content.Navigator.Navigate(navigationPath);
                        } else {
                            onLoadNavigation = navigationPath;
                        }
                    };
                    function addAttachment(id, quick) {
                        var data = { id: id };
                        $.ajax({
                            url: '");

            
            #line 101 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                             Write(Url.Action(MVC.API.Device.Attachment()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                            dataType: 'json',
                            data: data,
                            success: function (d) {
                                if (d.Result == 'OK') {
                                    var a = d.Attachment;

                                    var e = $('<a><span class=""icon""><img alt=""Attachment Thumbnail"" /></span><span class=""comments""></span><span class=""author""></span><span class=""remove""></span><span class=""timestamp""></span></a>');

                                    e.attr('data-attachmentid', a.Id).attr('data-mimetype', a.MimeType).attr('href', '");

            
            #line 110 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                                                                  Write(Url.Action(MVC.API.Device.AttachmentDownload()));

            
            #line default
            #line hidden
WriteLiteral("/\' + a.Id);\r\n                                    e.find(\'.icon img\').attr(\'src\', " +
"\'");

            
            #line 111 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                                                 Write(Url.Action(MVC.API.Device.AttachmentThumbnail()));

            
            #line default
            #line hidden
WriteLiteral("/\' + a.Id);\r\n                                    e.find(\'.comments\').text(a.Comme" +
"nts);\r\n                                    e.find(\'.author\').text(a.Author);\r\n  " +
"                                  e.find(\'.timestamp\').text(a.TimestampFuzzy).at" +
"tr(\'title\', a.TimestampFull);\r\n                                    e.find(\'.remo" +
"ve\').click(removeAttachment);\r\n                                    if (!quick)\r\n" +
"                                        e.hide();\r\n                             " +
"       $attachmentOutput.append(e);\r\n                                    if (!qu" +
"ick)\r\n                                        e.show(\'slow\');\r\n                 " +
"                   if (a.MimeType.toLowerCase().indexOf(\'image/\') == 0)\r\n       " +
"                                 e.shadowbox({ gallery: \'attachments\', player: \'" +
"img\', title: a.Comments });\r\n                                } else {\r\n         " +
"                           alert(\'Unable to add attachment: \' + d.Result);\r\n    " +
"                            }\r\n                            },\r\n                 " +
"           error: function (jqXHR, textStatus, errorThrown) {\r\n                 " +
"               alert(\'Unable to add attachment: \' + textStatus);\r\n              " +
"              }\r\n                        });\r\n                    }\r\n           " +
"         function removeAttachment() {\r\n                        $this = $(this)." +
"closest(\'a\');\r\n\r\n                        var data = { id: $this.attr(\'data-attac" +
"hmentid\') };\r\n                        var $dialogRemoveAttachment = $(\'#dialogRe" +
"moveAttachment\');\r\n                        $dialogRemoveAttachment.dialog(\"enabl" +
"e\");\r\n                        $dialogRemoveAttachment.dialog(\'option\', \'buttons\'" +
", {\r\n                            \"Remove\": function () {\r\n                      " +
"          $dialogRemoveAttachment.dialog(\"disable\");\r\n                          " +
"      $dialogRemoveAttachment.dialog(\"option\", \"buttons\", null);\r\n              " +
"                  $.ajax({\r\n                                    url: \'");

            
            #line 143 "..\..\Views\Device\DeviceParts\Resources.cshtml"
                                     Write(Url.Action(MVC.API.Device.AttachmentRemove()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                    dataType: \'json\',\r\n                      " +
"              data: data,\r\n                                    success: function" +
" (d) {\r\n                                        if (d == \'OK\') {\r\n              " +
"                              $this.hide(300).delay(300).queue(function () {\r\n  " +
"                                              var $this = $(this);\r\n            " +
"                                    if ($this.attr(\'data-mimetype\').toLowerCase(" +
").indexOf(\'image/\') == 0)\r\n                                                    S" +
"hadowbox.removeCache(this);\r\n                                                $th" +
"is.remove();\r\n                                            });\r\n                 " +
"                       } else {\r\n                                            ale" +
"rt(\'Unable to remove attachment: \' + d);\r\n                                      " +
"  }\r\n                                        $dialogRemoveAttachment.dialog(\"clo" +
"se\");\r\n                                    },\r\n                                 " +
"   error: function (jqXHR, textStatus, errorThrown) {\r\n                         " +
"               alert(\'Unable to remove attachment: \' + textStatus);\r\n           " +
"                             $dialogRemoveAttachment.dialog(\"close\");\r\n         " +
"                           }\r\n                                });\r\n             " +
"               },\r\n                            \"Cancel\": function () {\r\n        " +
"                        $dialogRemoveAttachment.dialog(\"close\");\r\n              " +
"              }\r\n                        });\r\n\r\n                        $dialogR" +
"emoveAttachment.dialog(\'open\');\r\n                        \r\n                     " +
"   return false;\r\n                    }\r\n\r\n                    $attachmentOutput" +
".children(\'a\').each(function () {\r\n                        $this = $(this);\r\n   " +
"                     if ($this.attr(\'data-mimetype\').toLowerCase().indexOf(\'imag" +
"e/\') == 0)\r\n                            $this.shadowbox({ gallery: \'attachments\'" +
", player: \'img\', title: $this.find(\'.comments\').text() });\r\n                    " +
"});\r\n                });\r\n            </script>\r\n        </td>\r\n    </tr>\r\n</tab" +
"le>\r\n<div");

WriteLiteral(" id=\"dialogUpload\"");

WriteLiteral(" title=\"Upload Attachment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"silverlightHostUploadAttachment\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"dialogRemoveAttachment\"");

WriteLiteral(" title=\"Remove this Attachment?\"");

WriteLiteral(">\r\n    <p>\r\n        <span");

WriteLiteral(" class=\"ui-icon ui-icon-alert\"");

WriteLiteral(" style=\"float: left; margin: 0 7px 20px 0;\"");

WriteLiteral("></span>\r\n        Are you sure?</p>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
