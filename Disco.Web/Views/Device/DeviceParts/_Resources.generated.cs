﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/DeviceParts/_Resources.cshtml")]
    public partial class Resources : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public Resources()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
  
    Authorization.Require(Claims.Device.ShowAttachments);

    var canAddAttachments = Authorization.Has(Claims.Device.Actions.AddAttachments);
    var canRemoveAnyAttachments = Authorization.Has(Claims.Device.Actions.RemoveAnyAttachments);
    var canRemoveOwnAttachments = Authorization.Has(Claims.Device.Actions.RemoveOwnAttachments);

    Html.BundleDeferred("~/Style/Shadowbox");
    Html.BundleDeferred("~/ClientScripts/Modules/Shadowbox");

    if (Authorization.Has(Claims.Device.Actions.AddAttachments))
    {
        Html.BundleDeferred("~/ClientScripts/Modules/Silverlight");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"DeviceDetailTab-Resources\"");

WriteLiteral(" class=\"DevicePart\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"deviceShowResources\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"Attachments\"");

WriteAttribute("class", Tuple.Create(" class=\"", 796), Tuple.Create("\"", 871)
            
            #line 20 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 804), Tuple.Create<System.Object, System.Int32>(canAddAttachments ? "canAddAttachments" : "cannotAddAttachments"
            
            #line default
            #line hidden
, 804), false)
);

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"attachmentOutput\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                     if (Model.Device.DeviceAttachments != null)
                    {
                        foreach (var da in Model.Device.DeviceAttachments)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1141), Tuple.Create("\"", 1201)
            
            #line 26 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1148), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentDownload(da.Id))
            
            #line default
            #line hidden
, 1148), false)
);

WriteLiteral(" data-attachmentid=\"");

            
            #line 26 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                      Write(da.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-mimetype=\"");

            
            #line 26 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                             Write(da.MimeType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"icon\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1307), Tuple.Create("\"", 1327)
            
            #line 27 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create<System.Object, System.Int32>(da.Filename
            
            #line default
            #line hidden
, 1315), false)
);

WriteLiteral(">\r\n                                <img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1394), Tuple.Create("\"", 1456)
            
            #line 28 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1400), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Device.AttachmentThumbnail(da.Id))
            
            #line default
            #line hidden
, 1400), false)
);

WriteLiteral(" /></span>\r\n                            <span");

WriteLiteral(" class=\"comments\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1519), Tuple.Create("\"", 1539)
            
            #line 29 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
, Tuple.Create(Tuple.Create("", 1527), Tuple.Create<System.Object, System.Int32>(da.Comments
            
            #line default
            #line hidden
, 1527), false)
);

WriteLiteral(">\r\n");

            
            #line 30 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                  if (!string.IsNullOrEmpty(da.DocumentTemplateId))
                                  { 
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                               Write(da.DocumentTemplate.Description);

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                    }
                                  else
                                  { 
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                               Write(da.Comments);

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                 }
            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                   Write(da.TechUser.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 34 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                       if (canRemoveAnyAttachments || (canRemoveOwnAttachments && da.TechUserId == CurrentUser.Id))
                                                                                      {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"remove fa fa-times-circle\"");

WriteLiteral("></span>");

            
            #line 35 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                                   }
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"timestamp\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2144), Tuple.Create("\"", 2182)
            
            #line 35 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2152), Tuple.Create<System.Object, System.Int32>(da.Timestamp.ToFullDateTime()
            
            #line default
            #line hidden
, 2152), false)
);

WriteLiteral(">");

            
            #line 35 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                                                                                              Write(da.Timestamp.FromNow());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>   \r\n");

            
            #line 37 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                 if (canAddAttachments)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"attachmentInput clearfix\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"action upload fa fa-upload\"");

WriteLiteral(" title=\"Attach File\"");

WriteLiteral("></span><span");

WriteLiteral(" class=\"action photo fa fa-camera\"");

WriteLiteral(" title=\"Capture Image\"");

WriteLiteral("></span>\r\n                    </div>\r\n");

            
            #line 45 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    Shadowbox.init({
                        skipSetup: true,
                        modal: true
                    });
                    $(function () {
                        $Attachments = $('#Attachments');
                        $attachmentOutput = $Attachments.find('.attachmentOutput');

");

            
            #line 55 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                         if (canAddAttachments)
                        {
            
            #line default
            #line hidden
WriteLiteral(@"
                        //#region Add Attachments
                        if (!document.DiscoFunctions) {
                            document.DiscoFunctions = {};
                        }
                        document.DiscoFunctions.addAttachment = addAttachment;

                        $('#dialogUpload').dialog({
                            autoOpen: false,
                            draggable: false,
                            modal: true,
                            resizable: false,
                            width: 860,
                            height: 550,
                            close: function () {
                                silverlightUploadAttachment.content.Navigator.Navigate('/Hidden');
                            }
                        });



                        var onLoadNavigation = null;
                        var isLoaded = null;
                        Silverlight.createObject(
                                '");

            
            #line 80 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                             Write(Links.ClientBin.Disco_Silverlight_AttachmentUpload_xap);

            
            #line default
            #line hidden
WriteLiteral(@"',
                                $('#silverlightHostUploadAttachment').get(0),
                                'silverlightUploadAttachment',
                                { width: '840px', height: '500px', background: 'white', version: '4.0.60310.0' },
                                {
                                    onLoad: function () {
                                        if (onLoadNavigation) {
                                            silverlightUploadAttachment.content.Navigator.Navigate(onLoadNavigation);
                                            isLoaded = true;
                                        }
                                    }
                                },
                                'UploadUrl=");

            
            #line 92 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
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

            
            #line 116 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                 Write(Url.Action(MVC.API.Device.Attachment()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                                dataType: 'json',
                                data: data,
                                success: function (d) {
                                    if (d.Result == 'OK') {
                                        var a = d.Attachment;
");

            
            #line 122 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                         if (canRemoveAnyAttachments)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, true, quick);");

WriteLiteral("\r\n");

            
            #line 125 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }
                                        else if (canRemoveOwnAttachments)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, (a.AuthorId === \'");

            
            #line 128 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                              Write(CurrentUser.Id);

            
            #line default
            #line hidden
WriteLiteral("\'), quick);");

WriteLiteral("\r\n");

            
            #line 129 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("buildAttachment(a, false, quick);");

WriteLiteral("\r\n");

            
            #line 133 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral(@"                                    } else {
                                        alert('Unable to add attachment: ' + d.Result);
                                    }
                                },
                                    error: function (jqXHR, textStatus, errorThrown) {
                                        alert('Unable to add attachment: ' + textStatus);
                                    }
                                });
                        }

                        function buildAttachment(a, canRemove, quick) {
                            var t = '<a><span");

WriteLiteral(" class=\"icon\"");

WriteLiteral("><img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteLiteral(" /></span><span");

WriteLiteral(" class=\"comments\"");

WriteLiteral("></span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral("></span>\';\r\n                            if (canRemove)\r\n                         " +
"       t += \'<span");

WriteLiteral(" class=\"remove fa fa-times-circle\"");

WriteLiteral("></span>\';\r\n                            t += \'<span");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral("></span></a>\';\r\n\r\n                            var e = $(t);\r\n\r\n                  " +
"          e.attr(\'data-attachmentid\', a.Id).attr(\'data-mimetype\', a.MimeType).at" +
"tr(\'href\', \'");

            
            #line 152 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                          Write(Url.Action(MVC.API.Device.AttachmentDownload()));

            
            #line default
            #line hidden
WriteLiteral("/\' + a.Id);\r\n                            e.find(\'.icon img\').attr(\'src\', \'");

            
            #line 153 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                         Write(Url.Action(MVC.API.Device.AttachmentThumbnail()));

            
            #line default
            #line hidden
WriteLiteral(@"/' + a.Id);
                            e.find('.comments').text(a.Comments);
                            e.find('.author').text(a.Author);
                            e.find('.timestamp').text(a.TimestampFuzzy).attr('title', a.TimestampFull);
                            if (canRemove)
                                e.find('.remove').click(removeAttachment);
                            if (!quick)
                                e.hide();
                            $attachmentOutput.append(e);
                            if (!quick)
                                e.show('slow');
                            if (a.MimeType.toLowerCase().indexOf('image/') == 0)
                                e.shadowbox({ gallery: 'attachments', player: 'img', title: a.Comments });
                        }

                        //#endregion
                        ");

            
            #line 169 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                               }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 170 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                         if (canRemoveAnyAttachments || canRemoveOwnAttachments)
                        {
            
            #line default
            #line hidden
WriteLiteral(@"
                        //#region Remove Attachments
                        $attachmentOutput.find('span.remove').click(removeAttachment);

                        $('#dialogRemoveAttachment').dialog({
                            resizable: false,
                            height: 140,
                            modal: true,
                            autoOpen: false
                        });

                        function removeAttachment() {
                            $this = $(this).closest('a');

                            var data = { id: $this.attr('data-attachmentid') };
                            var $dialogRemoveAttachment = $('#dialogRemoveAttachment');
                            $dialogRemoveAttachment.dialog(""enable"");
                            $dialogRemoveAttachment.dialog('option', 'buttons', {
                                ""Remove"": function () {
                                    $dialogRemoveAttachment.dialog(""disable"");
                                    $dialogRemoveAttachment.dialog(""option"", ""buttons"", null);
                                    $.ajax({
                                        url: '");

            
            #line 193 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                         Write(Url.Action(MVC.API.Device.AttachmentRemove()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                        dataType: \'json\',\r\n                  " +
"                      data: data,\r\n                                        succe" +
"ss: function (d) {\r\n                                            if (d == \'OK\') {" +
"\r\n                                                $this.hide(300).delay(300).que" +
"ue(function () {\r\n                                                    var $this " +
"= $(this);\r\n                                                    if ($this.attr(\'" +
"data-mimetype\').toLowerCase().indexOf(\'image/\') == 0)\r\n                         " +
"                               Shadowbox.removeCache(this);\r\n                   " +
"                                 $this.remove();\r\n                              " +
"                  });\r\n                                            } else {\r\n   " +
"                                             alert(\'Unable to remove attachment:" +
" \' + d);\r\n                                            }\r\n                       " +
"                     $dialogRemoveAttachment.dialog(\"close\");\r\n                 " +
"                       },\r\n                                        error: functi" +
"on (jqXHR, textStatus, errorThrown) {\r\n                                         " +
"   alert(\'Unable to remove attachment: \' + textStatus);\r\n                       " +
"                     $dialogRemoveAttachment.dialog(\"close\");\r\n                 " +
"                       }\r\n                                    });\r\n             " +
"                   },\r\n                                \"Cancel\": function () {\r\n" +
"                                    $dialogRemoveAttachment.dialog(\"close\");\r\n  " +
"                              }\r\n                            });\r\n\r\n            " +
"                $dialogRemoveAttachment.dialog(\'open\');\r\n\r\n                     " +
"       return false;\r\n                        }\r\n                        //#endr" +
"egion\r\n                        ");

            
            #line 225 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                               }

            
            #line default
            #line hidden
WriteLiteral(@"
                    $attachmentOutput.children('a').each(function () {
                        $this = $(this);
                        if ($this.attr('data-mimetype').toLowerCase().indexOf('image/') == 0)
                            $this.shadowbox({ gallery: 'attachments', player: 'img', title: $this.find('.comments').text() });
                    });
                });
                </script>
            </td>
        </tr>
    </table>
    <div");

WriteLiteral(" id=\"dialogUpload\"");

WriteLiteral(" title=\"Upload Attachment\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"silverlightHostUploadAttachment\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"dialogRemoveAttachment\"");

WriteLiteral(" title=\"Remove this Attachment?\"");

WriteLiteral(">\r\n        <p>\r\n            <span");

WriteLiteral(" class=\"ui-icon ui-icon-alert\"");

WriteLiteral(" style=\"float: left; margin: 0 7px 20px 0;\"");

WriteLiteral("></span>\r\n            Are you sure?\r\n        </p>\r\n    </div>\r\n    <script>\r\n    " +
"    $(\'#DeviceDetailTabItems\').append(\'<li><a href=\"#DeviceDetailTab-Resources\" " +
"id=\"DeviceDetailTab-ResourcesLink\">Attachments [");

            
            #line 248 "..\..\Views\Device\DeviceParts\_Resources.cshtml"
                                                                                                                                Write(Model.Device.DeviceAttachments == null ? 0 : Model.Device.DeviceAttachments.Count);

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
