#pragma checksum "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2081b8c80f20437f3e135fcb482b22ef4cc94c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Create), @"mvc.1.0.view", @"/Views/Payment/Create.cshtml")]
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
#nullable restore
#line 1 "D:\AptechSem3\WAD\WAD\Lab05\Views\_ViewImports.cshtml"
using Lab05;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab05\Views\_ViewImports.cshtml"
using Lab05.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2081b8c80f20437f3e135fcb482b22ef4cc94c52", @"/Views/Payment/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f940bc27eb8b459e0a40fec356455d5beaba3f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab05.Models.Payment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Tạo thanh toán</h2>\r\n<p>\r\n    <h3>");
#nullable restore
#line 8 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</p>\r\n<br />\r\n");
#nullable restore
#line 11 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div>\r\n            ");
#nullable restore
#line 15 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.LabelFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.EditorFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 20 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.LabelFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.EditorFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 25 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.LabelFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.EditorFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 30 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.LabelFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.EditorFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.LabelFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.EditorFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br/>\r\n        <div>\r\n            <input type=\"submit\" value=\"Create\" class=\"btn-primary\"/>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 44 "D:\AptechSem3\WAD\WAD\Lab05\Views\Payment\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab05.Models.Payment> Html { get; private set; }
    }
}
#pragma warning restore 1591
