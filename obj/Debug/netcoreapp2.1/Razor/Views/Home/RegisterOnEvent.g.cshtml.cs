#pragma checksum "D:\Poyu\Тест\EventPlaining\Views\Home\RegisterOnEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a22c8ea6fe4de1533f17e1ae63e923357428ccec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterOnEvent), @"mvc.1.0.view", @"/Views/Home/RegisterOnEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegisterOnEvent.cshtml", typeof(AspNetCore.Views_Home_RegisterOnEvent))]
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
#line 1 "D:\Poyu\Тест\EventPlaining\Views\_ViewImports.cshtml"
using EventPlaining;

#line default
#line hidden
#line 2 "D:\Poyu\Тест\EventPlaining\Views\_ViewImports.cshtml"
using EventPlaining.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a22c8ea6fe4de1533f17e1ae63e923357428ccec", @"/Views/Home/RegisterOnEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0395b501d0c5e03f2a1f819b55562277bc73c799", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterOnEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendSubmitEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Poyu\Тест\EventPlaining\Views\Home\RegisterOnEvent.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(62, 35, true);
            WriteLiteral("\r\n<h2>Регичстрация на мероприятие: ");
            EndContext();
            BeginContext(98, 21, false);
#line 6 "D:\Poyu\Тест\EventPlaining\Views\Home\RegisterOnEvent.cshtml"
                            Write(Model.Event.EventName);

#line default
#line hidden
            EndContext();
            BeginContext(119, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(126, 941, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b12ec69c0d64664890ab505b33663c7", async() => {
                BeginContext(175, 858, true);
                WriteLiteral(@"
    <button type=""submit"">Submit</button>
    <div>
        <label for=""first-name"">Имя</label>
        <input required type=""text"" id=""first-name"" name=""FirstName"">
    </div>
    <div>
        <label for=""second-name"">Фамилия</label>
        <input required type=""text"" id=""second-name"" name=""SecondName"">
    </div>
    <div>
        <label for=""age"">Возраст</label>
        <input required type=""number"" id=""age"" name=""Age"">
    </div>
    <div>
        <label for=""email"">Адрес электронно почты</label>
        <input required type=""email"" id=""email"" name=""Email"">
    </div>
    <div>
        <label for=""email"">О себе</label>
        <textarea  id=""about"" name=""AboutInfo""></textarea>
    </div>
    <input type=""hidden"" id=""eventParams"" name=""Submited"" value=""false"">
    <input type=""hidden"" id=""eventDateTime"" name=""EventId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1033, "\"", 1056, 1);
#line 30 "D:\Poyu\Тест\EventPlaining\Views\Home\RegisterOnEvent.cshtml"
WriteAttributeValue("", 1041, Model.Event.Id, 1041, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1057, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1067, 2, true);
            WriteLiteral("\r\n");
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
