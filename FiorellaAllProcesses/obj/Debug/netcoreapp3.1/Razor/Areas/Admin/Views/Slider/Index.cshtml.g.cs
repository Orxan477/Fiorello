#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5836ee8bb00fd469f312b91cbb737b131ff80188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Slider_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Slider/Index.cshtml")]
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
#line 1 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.ViewModels.Sliders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5836ee8bb00fd469f312b91cbb737b131ff80188", @"/Areas/Admin/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8696a403b5f9a65c94a15f20b4c9c2f2c9b99994", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int sliderNum = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-lg-6 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Slider</h4>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>№</th>
                                        <th>Image</th>
                                        <th>Settings</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 24 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                                     foreach (var slider in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 27 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                                           Write(sliderNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5836ee8bb00fd469f312b91cbb737b131ff801888719", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1194, "~/img/", 1194, 6, true);
#nullable restore
#line 29 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
AddHtmlAttributeValue("", 1200, slider.Image, 1200, 13, false);

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
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <label class=\"btn btn-primary \" asp-action=\"Detail\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1426, "\"", 1451, 1);
#nullable restore
#line 32 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1441, slider.Id, 1441, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <i class=""mdi mdi-eye""></i>
                                                </label>
                                            </td>
                                            <td>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5836ee8bb00fd469f312b91cbb737b131ff8018811267", async() => {
                WriteLiteral(@"
                                                    <label class=""btn btn-warning"">
                                                        <i class=""mdi mdi-table-edit""></i>
                                                    </label>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                                                                         WriteLiteral(slider.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5836ee8bb00fd469f312b91cbb737b131ff8018813948", async() => {
                WriteLiteral(@"
                                                    <button type=""submit"" class=""btn btn-danger"">
                                                        <i class=""mdi mdi-delete""></i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                                                                            WriteLiteral(slider.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 51 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                                        sliderNum++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                            <br />\r\n");
#nullable restore
#line 57 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                             if (sliderNum-1 != ViewBag.Say)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5836ee8bb00fd469f312b91cbb737b131ff8018817984", async() => {
                WriteLiteral("<label class=\"btn btn-success d-flex justify-content-center\">Create Photo</label>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- content-wrapper ends -->\r\n    <!-- partial:partials/_footer.html -->\r\n    ");
#nullable restore
#line 69 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\Slider\Index.cshtml"
Write(await Component.InvokeAsync("AdminFooter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- partial -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
