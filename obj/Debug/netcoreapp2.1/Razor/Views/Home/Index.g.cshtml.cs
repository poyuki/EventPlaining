#pragma checksum "D:\CBTtest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93cf48a162dbeba8002870c486b39bed1b99095c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\CBTtest\Views\_ViewImports.cshtml"
using EventPlaining;

#line default
#line hidden
#line 2 "D:\CBTtest\Views\_ViewImports.cshtml"
using EventPlaining.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cf48a162dbeba8002870c486b39bed1b99095c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0395b501d0c5e03f2a1f819b55562277bc73c799", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Добавить мероприятие"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Пользователи подписавшиеся на мероприятие"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EventVisitors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Регистрация открыта"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FollowEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\CBTtest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(47, 56, true);
            WriteLiteral("<div class=\"heading\">\r\n    <h1>Расписание событий</h1>\r\n");
            EndContext();
#line 7 "D:\CBTtest\Views\Home\Index.cshtml"
     if(Model.UserInSession.Role=="Admin"){

#line default
#line hidden
            BeginContext(148, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(156, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f8995eebb433c8daef498dbc969e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "D:\CBTtest\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(265, 37, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"events-list\">\r\n");
            EndContext();
#line 13 "D:\CBTtest\Views\Home\Index.cshtml"
     foreach (Event ev in Model.Events)
    {

#line default
#line hidden
            BeginContext(350, 33, true);
            WriteLiteral("        <div>\r\n            <table");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 383, "\"", 394, 1);
#line 16 "D:\CBTtest\Views\Home\Index.cshtml"
WriteAttributeValue("", 388, ev.Id, 388, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(395, 149, true);
            WriteLiteral(">\r\n                <tbody>\r\n                <tr>\r\n                    <td colspan=\"2\" style=\"text-align: center; padding: 5px 0; font-size: 18px;\">\r\n");
            EndContext();
#line 20 "D:\CBTtest\Views\Home\Index.cshtml"
                     if (Model.UserInSession.Role=="Admin")
                    {

#line default
#line hidden
            BeginContext(628, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(652, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b96a842d264b3a876afd20a7fb107e", async() => {
                BeginContext(755, 12, false);
#line 22 "D:\CBTtest\Views\Home\Index.cshtml"
                                                                                                                         Write(ev.EventName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\CBTtest\Views\Home\Index.cshtml"
                                                                                                          WriteLiteral(ev.Id);

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
            BeginContext(771, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\CBTtest\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(845, 30, true);
            WriteLiteral("                        <span>");
            EndContext();
            BeginContext(876, 12, false);
#line 26 "D:\CBTtest\Views\Home\Index.cshtml"
                         Write(ev.EventName);

#line default
#line hidden
            EndContext();
            BeginContext(888, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 27 "D:\CBTtest\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(920, 185, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left-col\">Дата и время проведения</td>\r\n                    <td class=\"right-col\">");
            EndContext();
            BeginContext(1106, 30, false);
#line 32 "D:\CBTtest\Views\Home\Index.cshtml"
                                     Write(ev.EventDateTime.ToString("f"));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "D:\CBTtest\Views\Home\Index.cshtml"
                 if (ev.VisitorsCount != 0)
                {

#line default
#line hidden
            BeginContext(1230, 159, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"left-col\">Максимальное количество посетителей</td>\r\n                        <td class=\"right-col\">");
            EndContext();
            BeginContext(1390, 16, false);
#line 38 "D:\CBTtest\Views\Home\Index.cshtml"
                                         Write(ev.VisitorsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1406, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "D:\CBTtest\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1500, 206, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"left-col\">Максимальное количество посетителей</td>\r\n                        <td class=\"right-col\">Неограниченно</td>\r\n                    </tr>\r\n");
            EndContext();
#line 47 "D:\CBTtest\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1725, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 48 "D:\CBTtest\Views\Home\Index.cshtml"
                 if (ev.Params != null)
                {
                    string[] param = ev.Params.Split(';');
                    Dictionary<string, string> p = new Dictionary<string, string>();
                    foreach (string s in param)
                    {
                        if (s != "")
                        {
                            string[] r = s.Split(':');
                            p.Add(r[0], r[1]);
                        }
                    }

                    foreach (KeyValuePair<string, string> keyValue in p)
                    {

#line default
#line hidden
            BeginContext(2321, 79, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"left-col\">");
            EndContext();
            BeginContext(2401, 12, false);
#line 64 "D:\CBTtest\Views\Home\Index.cshtml"
                                            Write(keyValue.Key);

#line default
#line hidden
            EndContext();
            BeginContext(2413, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"right-col\">");
            EndContext();
            BeginContext(2471, 14, false);
#line 65 "D:\CBTtest\Views\Home\Index.cshtml"
                                             Write(keyValue.Value);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 67 "D:\CBTtest\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2565, 104, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\" style=\"text-align: center; padding: 5px 0;\">\r\n");
            EndContext();
#line 71 "D:\CBTtest\Views\Home\Index.cshtml"
                         if (ev.VisitorsCount==0)
                        {
                             if (Model.UserInSession.Role == "Default")
                             {

#line default
#line hidden
            BeginContext(2852, 33, true);
            WriteLiteral("                                 ");
            EndContext();
            BeginContext(2885, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6362060c77348baa949b02b725b1c92", async() => {
                BeginContext(2964, 33, true);
                WriteLiteral("Зарегистрироваться на мероприятие");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3001, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "D:\CBTtest\Views\Home\Index.cshtml"
                             }
                             else
                             {

#line default
#line hidden
            BeginContext(3102, 33, true);
            WriteLiteral("                                 ");
            EndContext();
            BeginContext(3135, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497e4ac6177247da957b77612c1107ed", async() => {
                BeginContext(3235, 33, true);
                WriteLiteral("Зарегистрироваться на мероприятие");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "D:\CBTtest\Views\Home\Index.cshtml"
                                                                                                                 WriteLiteral(ev.Id);

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
            BeginContext(3272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "D:\CBTtest\Views\Home\Index.cshtml"
                             }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3390, 140, true);
            WriteLiteral("                            <span title=\"Регистрация на мероприятие закрыта\" style=\"color: gray;\">Зарегистрироваться на мероприятие</span>\r\n");
            EndContext();
#line 85 "D:\CBTtest\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3557, 113, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tfoot>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 91 "D:\CBTtest\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3677, 8, true);
            WriteLiteral("</div>\r\n");
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
