#pragma checksum "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c43e39e19fd69b7b9cef52f85a134167647ce92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_tbPeople_Index), @"mvc.1.0.view", @"/Views/tbPeople/Index.cshtml")]
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
#line 1 "D:\AptechSem3\WAD\WAD\Homework2\Views\_ViewImports.cshtml"
using Homework2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Homework2\Views\_ViewImports.cshtml"
using Homework2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c43e39e19fd69b7b9cef52f85a134167647ce92", @"/Views/tbPeople/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f837328123930bb558077f148cd277c37b888573", @"/Views/_ViewImports.cshtml")]
    public class Views_tbPeople_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Homework2.Models.tbPeople>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Hello, ");
#nullable restore
#line 6 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
      Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>No.</th>\r\n        <th>Name</th>\r\n        <th>Balance ($)</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
            Write(ViewBag.count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
           Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<div>\r\n    ");
#nullable restore
#line 24 "D:\AptechSem3\WAD\WAD\Homework2\Views\tbPeople\Index.cshtml"
Write(Html.ActionLink("Back to list", "Menu", "tbPeople"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Homework2.Models.tbPeople>> Html { get; private set; }
    }
}
#pragma warning restore 1591