#pragma checksum "D:\AptechSem3\WAD\WAD\Lab08\Views\Customer\_pvMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce31b70ce43778d0c5965b2fbce0a4fcd842d08e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer__pvMenu), @"mvc.1.0.view", @"/Views/Customer/_pvMenu.cshtml")]
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
#line 1 "D:\AptechSem3\WAD\WAD\Lab08\Views\_ViewImports.cshtml"
using Lab08;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab08\Views\_ViewImports.cshtml"
using Lab08.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce31b70ce43778d0c5965b2fbce0a4fcd842d08e", @"/Views/Customer/_pvMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1996067f91649d8da298d416152565e28b11d73", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer__pvMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"background-color:aqua\" class=\"bg-secondary\">\r\n    <h3>\r\n        ");
#nullable restore
#line 3 "D:\AptechSem3\WAD\WAD\Lab08\Views\Customer\_pvMenu.cshtml"
   Write(Html.ActionLink("Customer List", "Index", "Customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ||\r\n        ");
#nullable restore
#line 4 "D:\AptechSem3\WAD\WAD\Lab08\Views\Customer\_pvMenu.cshtml"
   Write(Html.ActionLink("Create new", "Create", "Customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n</div>");
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
