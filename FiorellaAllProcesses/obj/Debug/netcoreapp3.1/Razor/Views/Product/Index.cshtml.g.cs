#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf86348fd5f315779efdcbfb50cb99e9971788f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf86348fd5f315779efdcbfb50cb99e9971788f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c5eb67b54ba6a7a561635af8bcc78a54833518", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row plus\">\r\n        ");
#nullable restore
#line 7 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Product\Index.cshtml"
   Write(await Component.InvokeAsync("Product", new { take = 8 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <input type=\"hidden\" id=\"proCount\"");
            BeginWriteAttribute("value", " value=\"", 213, "\"", 238, 1);
#nullable restore
#line 9 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Product\Index.cshtml"
WriteAttributeValue("", 221, ViewBag.proCount, 221, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"d-flex justify-content-center my-5\">\r\n        <button type=\"submit\" class=\"btn btn-primary\" id=\"more\">More</button>\r\n    </div>\r\n</div>\r\n\r\n");
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
