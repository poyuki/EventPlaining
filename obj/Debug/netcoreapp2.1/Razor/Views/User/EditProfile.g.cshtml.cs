#pragma checksum "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244bb876b886c856bd1ea349e41375a1f26519d1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244bb876b886c856bd1ea349e41375a1f26519d1", @"/Views/User/EditProfile.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7236d9d4ab247d897d90afab510ae75", async() => {
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
            BeginContext(342, 61, true);
            WriteLiteral("    <div  class=\"form-at-center edit-profile-form\">\r\n        ");
            EndContext();
            BeginContext(403, 1574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d04a6813582a4682ba221a7ddb40de7b", async() => {
                BeginContext(476, 190, true);
                WriteLiteral("\r\n            <button class=\"submit-event-button\" type=\"submit\">Сохранить</button>\r\n            <div>\r\n                <label>Имя</label>\r\n                <input type=\"text\" name=\"FirstName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 666, "\"", 697, 1);
#line 16 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 674, edvm.Profile.FirstName, 674, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 135, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Фамилия</label>\r\n                <input type=\"text\" name=\"SecondName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 833, "\"", 865, 1);
#line 20 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 841, edvm.Profile.SecondName, 841, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(866, 130, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Возраст</label>\r\n                <input type=\"number\" name=\"Age\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1021, 1);
#line 24 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1004, edvm.Profile.Age, 1004, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1022, 124, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Пол</label>\r\n                <input type=\"text\" name=\"Sec\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1146, "\"", 1171, 1);
#line 28 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1154, edvm.Profile.Sec, 1154, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1172, 153, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Номер мобильного телефона</label>\r\n                <input type=\"tel\" name=\"PhoneNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1325, "\"", 1358, 1);
#line 32 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1333, edvm.Profile.PhoneNumber, 1333, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1359, 139, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Место работы</label>\r\n                <input type=\"text\" name=\"WorkPlace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1498, "\"", 1529, 1);
#line 36 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1506, edvm.Profile.WorkPlace, 1506, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1530, 138, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>Место учебы</label>\r\n                <input type=\"text\" name=\"EducPlace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1668, "\"", 1699, 1);
#line 40 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1676, edvm.Profile.EducPlace, 1676, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1700, 129, true);
                WriteLiteral("/>\r\n            </div>\r\n            <div>\r\n                <label>О себе</label>\r\n                <textarea rows=\"4\" name=\"About\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1829, "\"", 1856, 1);
#line 44 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1837, edvm.Profile.About, 1837, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1857, 76, true);
                WriteLiteral("></textarea>\r\n            </div>\r\n            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1933, "\"", 1957, 1);
#line 46 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
WriteAttributeValue("", 1941, edvm.Profile.Id, 1941, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1958, 12, true);
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
            BeginContext(1977, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 49 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2003, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(2013, 12, false);
#line 52 "D:\Poyu\CBTtest\Views\User\EditProfile.cshtml"
    Write(edvm.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 8, true);
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
