#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31beb18a5953dda07e1cb6ef96c5139f1bee13e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31beb18a5953dda07e1cb6ef96c5139f1bee13e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c5eb67b54ba6a7a561635af8bcc78a54833518", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- MAIN START -->\r\n\r\n<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    \r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 15 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
             foreach (var slider in Model.Sliders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e55607", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 295, "~/img/", 295, 6, true);
#nullable restore
#line 17 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 301, slider.Image, 301, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 18 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 25 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.HomeIntro.Head));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h1>you mean it</h1>\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                            ");
#nullable restore
#line 28 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.HomeIntro.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e58554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 890, "~/img/", 890, 6, true);
#nullable restore
#line 32 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 896, Model.HomeIntro.Signature, 896, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1396, "\"", 1403, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1634, "\"", 1641, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 52 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                 foreach (var category in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1825, "\"", 1832, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 54 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                       Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 54 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 55 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2133, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 61 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2300, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 63 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                               Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 63 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 64 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2524, "\"", 2531, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 75 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Product", new { take = 8 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e515653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3151, "~/img/", 3151, 6, true);
#nullable restore
#line 88 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3157, Model.Valentines.Image, 3157, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        ");
#nullable restore
#line 96 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Valentines.Head));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"py-3\">\r\n                            ");
#nullable restore
#line 98 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.Valentines.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 101 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                             foreach (var option in Model.ValentineOption)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"mt-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e518944", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4032, "~/img/", 4032, 6, true);
#nullable restore
#line 104 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4038, option.Image, 4038, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 104 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                                                   Write(option.Option);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 106 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 122 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.FlowerExpert.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 124 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.FlowerExpert.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 130 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                 foreach (var expert in Model.Experts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e523039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5127, "~/img/", 5127, 6, true);
#nullable restore
#line 135 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5133, expert.Image, 5133, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 138 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                               Write(expert.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 139 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                    Write(expert.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 143 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->
");
            WriteLiteral("\n    <section id=\"blog\">\r\n        <div class=\"container\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"offset-lg-3 col-lg-6\">\r\n                    <div class=\"section-title\">\r\n                        <h1>");
#nullable restore
#line 178 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.Blogs.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 180 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                       Write(Model.Blogs.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 186 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                 foreach (var blog in Model.BlogFlowers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e528545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7327, "~/img/", 7327, 6, true);
#nullable restore
#line 191 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7333, blog.Image, 7333, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 193 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                     Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 197 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                               Write(blog.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 198 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                    Write(blog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 202 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
");
#nullable restore
#line 215 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                         foreach (var comment in Model.Comments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e532779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8573, "~/img/", 8573, 6, true);
#nullable restore
#line 220 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8579, comment.Image, 8579, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>\r\n                                            ");
#nullable restore
#line 224 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                       Write(comment.Say);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
#nullable restore
#line 228 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                       Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 229 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                                                            Write(comment.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 233 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- SAY END -->\r\n    <!-- INSTAGRAM START -->\r\n\r\n    <section id=\"instagram\">\r\n        <div class=\"owl-carousel instagram\">\r\n");
#nullable restore
#line 245 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
             foreach (var instagram in Model.Instagrams)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31beb18a5953dda07e1cb6ef96c5139f1bee13e536771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9615, "~/img/", 9615, 6, true);
#nullable restore
#line 247 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9621, instagram.Image, 9621, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 248 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
