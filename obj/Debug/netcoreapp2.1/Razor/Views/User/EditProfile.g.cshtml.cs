#pragma checksum "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927ea4c4f0d9c60dc152d56844db9968a6e518c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditProfile), @"mvc.1.0.view", @"/Views/User/EditProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/EditProfile.cshtml", typeof(AspNetCore.Views_User_EditProfile))]
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
#line 1 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
using EventPlaining.ViewModel.UserViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927ea4c4f0d9c60dc152d56844db9968a6e518c8", @"/Views/User/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0395b501d0c5e03f2a1f819b55562277bc73c799", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitEditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
  
    EditProfileViewModel edvm = Model;
    ViewBag.Title = "Редактирование профиля";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(166, 59, true);
            WriteLiteral("\r\n<h2 style=\"text-align: center;\">Редактирование профиля | ");
            EndContext();
            BeginContext(225, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5385563e2ff4e8fb25b04b473e9bb5a", async() => {
                BeginContext(287, 15, true);
                WriteLiteral("Назад к профилю");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
                                                                                   WriteLiteral(edvm.UserInSession.Id);

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
            BeginContext(306, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 9 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
 if (edvm.SuccessStatus)
{

#line default
#line hidden
            BeginContext(342, 63, true);
            WriteLiteral("    <div style=\"width: 40px;\" class=\"form-at-center\">\r\n        ");
            EndContext();
            BeginContext(405, 1467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a093436f630044a5a1e415270269f646", async() => {
                BeginContext(478, 178, true);
                WriteLiteral("\r\n            <button class=\"submit-event-button\" type=\"submit\">Сохранить</button>\r\n            <div>\r\n                <label>Имя</label>\r\n                <input name=\"FirstName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 656, "\"", 687, 1);
#line 16 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 664, edvm.Profile.FirstName, 664, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(688, 123, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Фамилия</label>\r\n                <input name=\"SecondName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 811, "\"", 843, 1);
#line 20 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 819, edvm.Profile.SecondName, 819, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(844, 116, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Возраст</label>\r\n                <input name=\"Age\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 960, "\"", 985, 1);
#line 24 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 968, edvm.Profile.Age, 968, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(986, 112, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Пол</label>\r\n                <input name=\"Sec\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1098, "\"", 1123, 1);
#line 28 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1106, edvm.Profile.Sec, 1106, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1124, 142, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Номер мобильного телефона</label>\r\n                <input name=\"PhoneNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1266, "\"", 1299, 1);
#line 32 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1274, edvm.Profile.PhoneNumber, 1274, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1300, 127, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Место работы</label>\r\n                <input name=\"WorkPlace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1427, "\"", 1458, 1);
#line 36 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1435, edvm.Profile.WorkPlace, 1435, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1459, 126, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Место учебы</label>\r\n                <input name=\"EducPlace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1585, "\"", 1616, 1);
#line 40 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1593, edvm.Profile.EducPlace, 1593, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1617, 117, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>О себе</label>\r\n                <input name=\"About\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1734, "\"", 1761, 1);
#line 44 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1742, edvm.Profile.About, 1742, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1762, 66, true);
                WriteLiteral("/>\r\n            </div>\r\n            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1828, "\"", 1852, 1);
#line 46 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1836, edvm.Profile.Id, 1836, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1853, 12, true);
                WriteLiteral("/>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 49 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1898, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(1908, 12, false);
#line 52 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
    Write(edvm.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1920, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 53 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
}

#line default
#line hidden
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
