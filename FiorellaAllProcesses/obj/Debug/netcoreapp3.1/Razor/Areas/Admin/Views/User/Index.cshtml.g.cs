#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e331148ca2935598ed7f676e069b96664e8bfea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#nullable restore
#line 5 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\_ViewImports.cshtml"
using FiorellaAllProcesses.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e331148ca2935598ed7f676e069b96664e8bfea9", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac542b7f9d18b7016f988488b1a8cb0998613a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "User";
    int userNum = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-lg-8 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">User</h4>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>№</th>
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>RoleName</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 25 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                     foreach (var user in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 28 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                           Write(userNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 29 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                           Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 30 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 31 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                           Write(user.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 33 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
                                        userNum++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- content-wrapper ends -->
    <!-- partial:partials/_footer.html -->
    ");
#nullable restore
#line 47 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\FiorellaAllProcesses\FiorellaAllProcesses\Areas\Admin\Views\User\Index.cshtml"
Write(await Component.InvokeAsync("AdminFooter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- partial -->\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
