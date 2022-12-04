// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Disco.Web.Areas.Services.Controllers
{
    public partial class ClientController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ClientController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ClientController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Unauthenticated()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Unauthenticated);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Authenticated()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Authenticated);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ClientError()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ClientError);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ClientController Actions { get { return MVC.Services.Client; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Services";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Client";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Client";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Bootstrapper = "Bootstrapper";
            public readonly string PreparationClient = "PreparationClient";
            public readonly string Unauthenticated = "Unauthenticated";
            public readonly string Authenticated = "Authenticated";
            public readonly string ClientError = "ClientError";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Bootstrapper = "Bootstrapper";
            public const string PreparationClient = "PreparationClient";
            public const string Unauthenticated = "Unauthenticated";
            public const string Authenticated = "Authenticated";
            public const string ClientError = "ClientError";
        }


        static readonly ActionParamsClass_Unauthenticated s_params_Unauthenticated = new ActionParamsClass_Unauthenticated();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Unauthenticated UnauthenticatedParams { get { return s_params_Unauthenticated; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Unauthenticated
        {
            public readonly string feature = "feature";
        }
        static readonly ActionParamsClass_Authenticated s_params_Authenticated = new ActionParamsClass_Authenticated();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Authenticated AuthenticatedParams { get { return s_params_Authenticated; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Authenticated
        {
            public readonly string feature = "feature";
        }
        static readonly ActionParamsClass_ClientError s_params_ClientError = new ActionParamsClass_ClientError();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ClientError ClientErrorParams { get { return s_params_ClientError; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ClientError
        {
            public readonly string SessionId = "SessionId";
            public readonly string DeviceIdentifier = "DeviceIdentifier";
            public readonly string JsonException = "JsonException";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ClientController : Disco.Web.Areas.Services.Controllers.ClientController
    {
        public T4MVC_ClientController() : base(Dummy.Instance) { }

        [NonAction]
        partial void BootstrapperOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Bootstrapper()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Bootstrapper);
            BootstrapperOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PreparationClientOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PreparationClient()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PreparationClient);
            PreparationClientOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UnauthenticatedOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string feature);

        [NonAction]
        public override System.Web.Mvc.ActionResult Unauthenticated(string feature)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Unauthenticated);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "feature", feature);
            UnauthenticatedOverride(callInfo, feature);
            return callInfo;
        }

        [NonAction]
        partial void AuthenticatedOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string feature);

        [NonAction]
        public override System.Web.Mvc.ActionResult Authenticated(string feature)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Authenticated);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "feature", feature);
            AuthenticatedOverride(callInfo, feature);
            return callInfo;
        }

        [NonAction]
        partial void ClientErrorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string SessionId, string DeviceIdentifier, string JsonException);

        [NonAction]
        public override System.Web.Mvc.ActionResult ClientError(string SessionId, string DeviceIdentifier, string JsonException)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ClientError);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SessionId", SessionId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "DeviceIdentifier", DeviceIdentifier);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "JsonException", JsonException);
            ClientErrorOverride(callInfo, SessionId, DeviceIdentifier, JsonException);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
