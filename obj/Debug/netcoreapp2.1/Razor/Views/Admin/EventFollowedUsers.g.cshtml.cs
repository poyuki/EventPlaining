#pragma checksum "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f817111b22c299c70178f297f970e2c473df16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EventFollowedUsers), @"mvc.1.0.view", @"/Views/Admin/EventFollowedUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EventFollowedUsers.cshtml", typeof(AspNetCore.Views_Admin_EventFollowedUsers))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Poyu\CBTtest\Views\_ViewImports.cshtml"
using EventPlaining;

#line default
#line hidden
#line 2 "D:\Poyu\CBTtest\Views\_ViewImports.cshtml"
using EventPlaining.Models;

#line default
#line hidden
#line 1 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
using EventPlaining.ViewModel.AdminViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f817111b22c299c70178f297f970e2c473df16", @"/Views/Admin/EventFollowedUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0395b501d0c5e03f2a1f819b55562277bc73c799", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EventFollowedUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
  
    EventFollowedUsersViewModel efuvm = Model;
    ViewBag.Title = efuvm.Event.EventName;
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(174, 31, true);
            WriteLiteral("\r\n<h2>\r\n    Список участников\r\n");
            EndContext();
#line 11 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
     if (efuvm.Event.VisitorsCount != 0)
    {

#line default
#line hidden
            BeginContext(254, 28, true);
            WriteLiteral("        <span>| Max: </span>");
            EndContext();
            BeginContext(283, 25, false);
#line 13 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                       Write(efuvm.Event.VisitorsCount);

#line default
#line hidden
            EndContext();
#line 13 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                                                      
    }

#line default
#line hidden
            BeginContext(317, 6, true);
            WriteLiteral("    | ");
            EndContext();
            BeginContext(323, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9101dc6365734af482e6bdf000d0b357", async() => {
                BeginContext(367, 12, true);
                WriteLiteral("К расписанию");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(383, 13, true);
            WriteLiteral("\r\n    |\r\n    ");
            EndContext();
            BeginContext(396, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8704c2fd9c0c46d284c0f56c48dd78e1", async() => {
                BeginContext(478, 19, true);
                WriteLiteral("Удалить мероприятие");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                                                         WriteLiteral(efuvm.Event.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(501, 85, true);
            WriteLiteral(" \r\n</h2>\r\n<h3>Пользователи подписавшиеся на мероприятие | <span id=\"followers-count\">");
            EndContext();
            BeginContext(587, 29, false);
#line 19 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                                                                      Write(efuvm.Event.EventsUsers.Count);

#line default
#line hidden
            EndContext();
            BeginContext(616, 42, true);
            WriteLiteral("</span></h3>\r\n<div class=\"visitor-list\">\r\n");
            EndContext();
#line 21 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
     if (efuvm.Event.EventsUsers.Count != 0)
    {
        foreach (EventsUsers eu in efuvm.Event.EventsUsers)
        {

#line default
#line hidden
            BeginContext(783, 126, true);
            WriteLiteral("            <div class=\"followed-event-user\">\r\n                <i title=\"Отменить подписку пользователя на данное мероприятие\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 909, "\"", 964, 5);
            WriteAttributeValue("", 919, "cancelFollowing(", 919, 16, true);
#line 26 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
WriteAttributeValue("", 935, eu.UserId, 935, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 945, ",", 945, 1, true);
#line 26 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
WriteAttributeValue("", 946, eu.EventId, 946, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 957, ",event)", 957, 7, true);
            EndWriteAttribute();
            BeginContext(965, 69, true);
            WriteLiteral(" class=\"fas fa-minus\"></i>\r\n                <div>Логин пользователя: ");
            EndContext();
            BeginContext(1035, 17, false);
#line 27 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                                    Write(eu.User.LogInName);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 47, true);
            WriteLiteral("</div>\r\n                <div>Элетронная почта: ");
            EndContext();
            BeginContext(1100, 13, false);
#line 28 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
                                  Write(eu.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 28, true);
            WriteLiteral("</div>\r\n                <div");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1141, "\"", 1192, 4);
            WriteAttributeValue("", 1151, "getUserProfile(", 1151, 15, true);
#line 29 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
WriteAttributeValue("", 1166, eu.User.ProfileId, 1166, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1184, ",", 1184, 1, true);
            WriteAttributeValue(" ", 1185, "event)", 1186, 7, true);
            EndWriteAttribute();
            BeginContext(1193, 92, true);
            WriteLiteral(" class=\"my-app-command-link profile-button\">Профиль пользователя</div>\r\n            </div>\r\n");
            EndContext();
#line 31 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1320, 86, true);
            WriteLiteral("        <p>К сожалению на данный момент нет участников подтвердивших регистрацию</p>\r\n");
            EndContext();
#line 36 "D:\Poyu\CBTtest\Views\Admin\EventFollowedUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(1413, 118, true);
            WriteLiteral("</div>\r\n<div class=\"profile-area\">\r\n    <h4>Профиль пользователя</h4>\r\n    <div id=\"profile-data\"></div>\r\n    \r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
