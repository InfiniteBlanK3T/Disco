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

namespace Disco.Web.Views.Job.JobParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/NonWarranty.cshtml")]
    public partial class NonWarranty : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public NonWarranty()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"jobDetailTab-Components\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 3 "..\..\Views\Job\JobParts\NonWarranty.cshtml"
Write(Html.Partial(MVC.Job.Views.JobParts.Components));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" id=\"jobDetailTab-NonWarrantyFinance\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\Job\JobParts\NonWarranty.cshtml"
Write(Html.Partial(MVC.Job.Views.JobParts.NonWarrantyFinance));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" id=\"jobDetailTab-NonWarrantyRepairs\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Job\JobParts\NonWarranty.cshtml"
Write(Html.Partial(MVC.Job.Views.JobParts.Repairs));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" id=\"jobDetailTab-NonWarrantyInsurance\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Views\Job\JobParts\NonWarranty.cshtml"
Write(Html.Partial(MVC.Job.Views.JobParts.Insurance));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $('#jobDetailTabItems').append('<li><a href=""#jobDetailTab-Components"">Components</a></li><li><a href=""#jobDetailTab-NonWarrantyFinance"">Finance</a></li><li><a href=""#jobDetailTab-NonWarrantyRepairs"">Repairs</a></li><li><a href=""#jobDetailTab-NonWarrantyInsurance"">Insurance</a></li>');
</script>
");

        }
    }
}
#pragma warning restore 1591
