#pragma checksum "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbc7d409f320c9825e3ba77339ecaf2f782477a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SendSubmitEmail), @"mvc.1.0.view", @"/Views/User/SendSubmitEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/SendSubmitEmail.cshtml", typeof(AspNetCore.Views_User_SendSubmitEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccbc7d409f320c9825e3ba77339ecaf2f782477a", @"/Views/User/SendSubmitEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0395b501d0c5e03f2a1f819b55562277bc73c799", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SendSubmitEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
  
    ViewBag.Title = "Отправка сообщения";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 52, true);
            WriteLiteral("\r\n<h2 class=\"form-heading\">Регистрация</h2>\r\n<div>\r\n");
            EndContext();
#line 9 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
     if (Model.SuccessStatus)
    {

#line default
#line hidden
            BeginContext(167, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(179, 13, false);
#line 11 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
      Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(192, 3, true);
            WriteLiteral(" <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 195, "\"", 221, 2);
            WriteAttributeValue("", 202, "http://", 202, 7, true);
#line 11 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
WriteAttributeValue("", 209, Model.Email, 209, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(222, 37, true);
            WriteLiteral(" target=\"_blank\">Ваша почта</a></p>\r\n");
            EndContext();
#line 12 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(283, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(295, 13, false);
#line 15 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
      Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(308, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "D:\Poyu\CBTtest\Views\User\SendSubmitEmail.cshtml"
    }

#line default
#line hidden
            BeginContext(321, 8, true);
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
