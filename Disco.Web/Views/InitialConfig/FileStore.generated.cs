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

namespace Disco.Web.Views.InitialConfig
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InitialConfig/FileStore.cshtml")]
    public partial class FileStore : Disco.Services.Web.WebViewPage<Disco.Web.Models.InitialConfig.FileStoreModel>
    {
        public FileStore()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\InitialConfig\FileStore.cshtml"
  
    ViewBag.Title = null;
    Html.BundleDeferred("~/Style/jQueryUI/dynatree");
    Html.BundleDeferred("~/ClientScripts/Modules/jQueryUI-DynaTree");

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>");

            
            #line 7 "..\..\Views\InitialConfig\FileStore.cshtml"
Write(CommonHelpers.Breadcrumbs(Html.ToBreadcrumb("Initial Configuration", MVC.InitialConfig.Index(), "File Store")));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n<div");

WriteLiteral(" id=\"initialConfig_FileStore\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\InitialConfig\FileStore.cshtml"
Write(Html.ValidationSummary(false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n        <h2>File Store Location</h2>\r\n        <table>\r\n            <tr>\r\n     " +
"           <td>\r\n                    <div");

WriteLiteral(" id=\"treeFilesystem\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"treeFilesystemActions\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" id=\"createDirectory\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">Create Directory</a>\r\n                    </div>\r\n                </td>\r\n       " +
"     </tr>\r\n            <tr>\r\n                <td>\r\n                    <div>\r\n " +
"                       Selected Location: <span");

WriteLiteral(" id=\"locationPath\"");

WriteLiteral(" class=\"code\"");

WriteLiteral(">&lt;None&gt;</span> <span");

WriteLiteral(" id=\"locationPathInvalid\"");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(Invalid DataStore Location)</span>\r\n                    </div>\r\n               " +
" </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

            
            #line 32 "..\..\Views\InitialConfig\FileStore.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\InitialConfig\FileStore.cshtml"
     using (Html.BeginForm())
    {
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\InitialConfig\FileStore.cshtml"
   Write(Html.HiddenFor(m => m.FileStoreLocation));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\InitialConfig\FileStore.cshtml"
                                                 

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" id=\"submitForm\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Continue\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" />\r\n        </div>\r\n");

            
            #line 38 "..\..\Views\InitialConfig\FileStore.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" id=\"dialogWait\"");

WriteLiteral(" title=\"Please Wait\"");

WriteLiteral(">\r\n    <h2><span");

WriteLiteral(" class=\"ajaxLoading\"");

WriteLiteral("></span>Building and Validating File Store</h2>\r\n    <div>Please wait while the D" +
"isco File Store is created and/or validated</div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"dialogCreateDirectory\"");

WriteLiteral(" title=\"Create Directory\"");

WriteLiteral(">\r\n    <h2>Create Directory</h2>\r\n    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"createDirectoryName\"");

WriteLiteral(" />\r\n    <div>Parent: <span");

WriteLiteral(" id=\"createDirectoryParent\"");

WriteLiteral(" class=\"code\"");

WriteLiteral("></span></div>\r\n</div>\r\n<script>\r\n    (function () {\r\n        var fileSystemBranc" +
"hUrl = \'");

            
            #line 51 "..\..\Views\InitialConfig\FileStore.cshtml"
                               Write(Url.Action(MVC.InitialConfig.FileStoreBranch()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var fileSystemInitialBranches = null;\r\n        var fileSystemBranchSe" +
"lected = null;\r\n        var $treeFilesystem = $(\'#treeFilesystem\');\r\n\r\n        v" +
"ar nodeDataLoaded = function (node) {\r\n            var addedNodes = [];\r\n       " +
"     var previousUpdateMode = node.tree.enableUpdate(false);\r\n            var de" +
"scriptor = node.data.fileSystemDescriptor;\r\n            // Sub Folders\r\n        " +
"    if (descriptor.SubDirectories) {\r\n                var hasSubDirectories = fa" +
"lse;\r\n                for (var k in descriptor.SubDirectories) {\r\n              " +
"      hasSubDirectories = true;\r\n                    var d = descriptor.SubDirec" +
"tories[k];\r\n                    var n = node.addChild({ key: d.Path, title: d.Is" +
"New ? d.Name + \' [New]\' : d.Name, tooltip: d.Path, unselectable: !d.Selectable, " +
"addClass: \'directory\', isLazy: true, isFolder: true, fileSystemDescriptor: d });" +
"\r\n                    addedNodes.push(n);\r\n\r\n                    if (d.SubDirect" +
"ories) {\r\n                        nodeDataLoaded(n);\r\n                    }\r\n   " +
"             }\r\n                if (!hasSubDirectories) {\r\n                    /" +
"/ Leaf\r\n                    node.data.isLazy = false;\r\n                    if (!" +
"fileSystemInitialBranches)\r\n                        node.render();\r\n            " +
"    }\r\n            }\r\n            node.setLazyNodeStatus(DTNodeStatus_Ok);\r\n    " +
"        node.tree.enableUpdate(previousUpdateMode);\r\n            return addedNod" +
"es;\r\n        }\r\n        var loadNodeData = function (node) {\r\n            var de" +
"scriptor = node.data.fileSystemDescriptor;\r\n\r\n            if (!descriptor.SubDir" +
"ectories) {\r\n                $.ajax({\r\n                    url: fileSystemBranch" +
"Url,\r\n                    dataType: \'json\',\r\n                    data: { Path: d" +
"escriptor.Path },\r\n                    success: function (data) {\r\n             " +
"           node.data.fileSystemDescriptor = data;\r\n                        retur" +
"n nodeDataLoaded(node);\r\n                    },\r\n                    error: func" +
"tion () {\r\n                        alert(\'Unable to access this path: \' + descri" +
"ptor.Path);\r\n                        node.remove();\r\n                    }\r\n    " +
"            })\r\n            } else {\r\n                return nodeDataLoaded(node" +
");\r\n            }\r\n        }\r\n        var lazyLoadNode = function (node) {\r\n    " +
"        if (node.data.fileSystemDescriptor) {\r\n                node.setLazyNodeS" +
"tatus(DTNodeStatus_Loading);\r\n                loadNodeData(node);\r\n            }" +
" else {\r\n                node.setLazyNodeStatus(DTNodeStatus_Ok);\r\n            }" +
"\r\n        }\r\n        var activeNodeUpdated = function () {\r\n            var acti" +
"veNode = $(\"#treeFilesystem\").dynatree(\"getActiveNode\");\r\n\r\n            if (acti" +
"veNode !== null) {\r\n                fileSystemBranchSelected = activeNode.data.f" +
"ileSystemDescriptor;\r\n            } else {\r\n                fileSystemBranchSele" +
"cted = null\r\n            }\r\n\r\n            if (fileSystemBranchSelected !== null)" +
" {\r\n                $(\'#locationPath\').text(fileSystemBranchSelected.Path);\r\n   " +
"             $(\'#createDirectory\').attr(\'disabled\', false);\r\n                if " +
"(fileSystemBranchSelected.Selectable) {\r\n                    $(\'#submitForm\').at" +
"tr(\'disabled\', false);\r\n                    $(\'#locationPathInvalid\').hide();\r\n " +
"               } else {\r\n                    $(\'#submitForm\').attr(\'disabled\', t" +
"rue);\r\n                    $(\'#locationPathInvalid\').show();\r\n                }\r" +
"\n            } else {\r\n                $(\'#createDirectory\').attr(\'disabled\', tr" +
"ue);\r\n                $(\'#submitForm\').attr(\'disabled\', true);\r\n                " +
"$(\'#locationPath\').text(\'<None>\');\r\n                $(\'#locationPathInvalid\').sh" +
"ow();\r\n            }\r\n        }\r\n        var scrollToNode = function (node) {\r\n " +
"           var $li = $(node.li);\r\n            var $treeRoot = $($treeFilesystem." +
"dynatree(\'getRoot\').ul);\r\n            var ih = $li.height();\r\n            var th" +
" = $treeRoot.height();\r\n            var ts = $treeRoot.scrollTop();\r\n           " +
" var is = $li.position().top;\r\n            if ((ih + is) > th) {\r\n              " +
"  if (ih > th) {\r\n                    $treeRoot.animate({ \'scrollTop\': (is + ts)" +
" }, \'fast\');\r\n                } else {\r\n                    $treeRoot.animate({ " +
"\'scrollTop\': (ih + is + ts - th) }, \'fast\');\r\n                }\r\n            }\r\n" +
"        }\r\n        var nodeExpanded = function (flag, node) {\r\n            if (f" +
"lag)\r\n                window.setTimeout(function () { scrollToNode(node); }, 1);" +
"\r\n        }\r\n        var nodeDeactivated = function () {\r\n            activeNode" +
"Updated();\r\n        }\r\n        var nodeActivated = function (node) {\r\n          " +
"  activeNodeUpdated();\r\n            nodeExpanded(true, node);\r\n        }\r\n\r\n    " +
"    $(function () {\r\n            $(\'#dialogWait\').dialog({\r\n                auto" +
"Open: false,\r\n                draggable: false,\r\n                modal: true,\r\n " +
"               resizable: false,\r\n                width: 400,\r\n                h" +
"eight: 150,\r\n                closeOnEscape: false\r\n            }).closest(\'.ui-d" +
"ialog\').find(\'.ui-dialog-titlebar-close\').hide();\r\n\r\n            $(\'#dialogCreat" +
"eDirectory\').dialog({\r\n                autoOpen: false,\r\n                draggab" +
"le: false,\r\n                modal: true,\r\n                resizable: false,\r\n   " +
"             width: 400,\r\n                height: 180,\r\n                buttons:" +
" {\r\n                    \'Cancel\': function () {\r\n                        $(\'#dia" +
"logCreateDirectory\').dialog(\'close\');\r\n                    },\r\n                 " +
"   \'Create Directory\': function () {\r\n                        var activeNode = $" +
"(\"#treeFilesystem\").dynatree(\"getActiveNode\");\r\n                        if (acti" +
"veNode) {\r\n                            var name = $(\'#createDirectoryName\').val(" +
");\r\n                            d = {\r\n                                Name: nam" +
"e,\r\n                                Path: fileSystemBranchSelected.Path.charAt(f" +
"ileSystemBranchSelected.Path.length - 1) === \'\\\\\' ? fileSystemBranchSelected.Pat" +
"h + name : fileSystemBranchSelected.Path + \'\\\\\' + name,\r\n                       " +
"         IsNew: true,\r\n                                Selectable: true,\r\n      " +
"                          SubDirectories: {}\r\n                            }\r\n   " +
"                         activeNode.addChild({ title: d.Name + \' [New]\', tooltip" +
": d.Path, unselectable: !d.Selectable, addClass: \'newDirectory\', isLazy: false, " +
"isFolder: true, fileSystemDescriptor: d }).activate();\r\n                        " +
"}\r\n                        $(\'#dialogCreateDirectory\').dialog(\'close\');\r\n       " +
"             }\r\n                }\r\n            })\r\n\r\n            $(\'#createDirec" +
"tory\').click(function () {\r\n                if (fileSystemBranchSelected) {\r\n   " +
"                 $(\'#dialogCreateDirectory\').dialog(\'open\');\r\n                  " +
"  $(\'#createDirectoryName\').val(\'\').focus();\r\n                    $(\'#createDire" +
"ctoryParent\').text(fileSystemBranchSelected.Path);\r\n                }\r\n         " +
"       return false;\r\n            });\r\n\r\n            $(\'#submitForm\').closest(\'f" +
"orm\').submit(function () {\r\n                if (fileSystemBranchSelected && file" +
"SystemBranchSelected.Selectable) {\r\n                    if ($(this).valid()) {\r\n" +
"                        $(\'#dialogWait\').dialog(\'open\');\r\n                      " +
"  $(\'#FileStoreLocation\').val(fileSystemBranchSelected.Path);\r\n                 " +
"   }\r\n                    return true;\r\n                } else {\r\n              " +
"      alert(\'Invalid FileStore Location\');\r\n                    return false;\r\n " +
"               }\r\n            });\r\n\r\n            $treeFilesystem.dynatree({ onLa" +
"zyRead: lazyLoadNode, onActivate: nodeActivated, onDeactivate: nodeDeactivated, " +
"onExpand: nodeExpanded });\r\n            var rootNode = $treeFilesystem.dynatree(" +
"\'getRoot\');\r\n\r\n            var previousUpdateMode = rootNode.tree.enableUpdate(f" +
"alse);\r\n            rootNode.data.fileSystemDescriptor = fileSystemInitialBranch" +
"es[0];\r\n            loadNodeData(rootNode);\r\n            rootNode.tree.enableUpd" +
"ate(previousUpdateMode);\r\n\r\n            var initialValue = $(\'#FileStoreLocation" +
"\').val();\r\n            if (initialValue) {\r\n                var initialNode = ro" +
"otNode.tree.getNodeByKey(initialValue);\r\n                if (initialNode)\r\n     " +
"               initialNode.activate();\r\n            }\r\n\r\n            fileSystemI" +
"nitialBranches = null;\r\n        });\r\n\r\n\r\n        fileSystemInitialBranches = [");

            
            #line 247 "..\..\Views\InitialConfig\FileStore.cshtml"
                                 Write(new HtmlString(Json.Encode(Model.DirectoryModel)));

            
            #line default
            #line hidden
WriteLiteral("];\r\n    })();\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
