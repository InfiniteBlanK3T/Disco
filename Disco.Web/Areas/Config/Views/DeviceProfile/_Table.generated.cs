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

namespace Disco.Web.Areas.Config.Views.DeviceProfile
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
    
    #line 2 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
    using Disco.Web.Areas.Config.Models.DeviceProfile;
    
    #line default
    #line hidden
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceProfile/_Table.cshtml")]
    public partial class _Table : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceProfile.IndexModel>
    {
        public _Table()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
  
    Authorization.Require(Claims.Config.DeviceProfile.Show);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
 if (DiscoApplication.MultiSiteMode)
{
    var deviceProfilesGrouped = Model.DeviceProfiles.OrderBy(i => i.AddressName).GroupBy(i => i.AddressName);
    foreach (var deviceProfilesGroup in deviceProfilesGrouped)
    {
        if (deviceProfilesGroup.Key != null)
        {
            
            #line default
            #line hidden
WriteLiteral(" <h2>");

            
            #line 12 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
         Write(deviceProfilesGroup.Key);

            
            #line default
            #line hidden
WriteLiteral("</h2> ");

            
            #line 12 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
                                            }
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
Write(Html.Partial(MVC.Config.DeviceProfile.Views._TableRender, deviceProfilesGroup.Cast<_IndexModelItem>(), new ViewDataDictionary()));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
                                                                                                                                             
    }
}
else
{ 
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
Write(Html.Partial(MVC.Config.DeviceProfile.Views._TableRender, Model.DeviceProfiles.Cast<_IndexModelItem>(), new ViewDataDictionary()));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Areas\Config\Views\DeviceProfile\_Table.cshtml"
                                                                                                                                      
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
