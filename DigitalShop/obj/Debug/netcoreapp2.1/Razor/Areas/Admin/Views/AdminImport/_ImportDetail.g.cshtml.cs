#pragma checksum "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59ce0a8c1e5a1f8e66c2d8f3f665933bb23bf300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminImport__ImportDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminImport/_ImportDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminImport/_ImportDetail.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminImport__ImportDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ce0a8c1e5a1f8e66c2d8f3f665933bb23bf300", @"/Areas/Admin/Views/AdminImport/_ImportDetail.cshtml")]
    public class Areas_Admin_Views_AdminImport__ImportDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigitalShop.Models.ImportDetailViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 23, false);
#line 2 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(79, 231, true);
            WriteLiteral("\r\n<div class=\"modal-dialog modal-lg\">\r\n    <div class=\"modal-content\">\r\n        <div class=\"modal-header\">\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n            <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(311, 18, false);
#line 7 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                               Write(ViewBag.ImportCode);

#line default
#line hidden
            EndContext();
            BeginContext(329, 560, true);
            WriteLiteral(@"</h4>
        </div>
        <div class=""modal-body"">
            <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                <thead>
                    <tr>
                        <th>
                            Product Name
                        </th>
                        <th>
                            Quantity
                        </th>
                        <th>
                            Prices
                        </th>
                    </tr>
                </thead>
");
            EndContext();
#line 24 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                 if (Model.Count() != 0)
                {

#line default
#line hidden
            BeginContext(950, 29, true);
            WriteLiteral("                    <tbody>\r\n");
            EndContext();
#line 27 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
            BeginContext(1062, 127, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1190, 46, false);
#line 32 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1352, 43, false);
#line 35 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1511, 41, false);
#line 38 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Prices));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 77, true);
            WriteLiteral("$\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 41 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                            
                        }

#line default
#line hidden
            BeginContext(1686, 30, true);
            WriteLiteral("                    </tbody>\r\n");
            EndContext();
#line 44 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                }

#line default
#line hidden
            BeginContext(1735, 94, true);
            WriteLiteral("            </table>\r\n            <p style=\"text-align:right ;padding-right:159px\"><b>Total : ");
            EndContext();
            BeginContext(1830, 18, false);
#line 46 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_ImportDetail.cshtml"
                                                                   Write(ViewBag.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1848, 48, true);
            WriteLiteral(" $</b></p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DigitalShop.Models.ImportDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
