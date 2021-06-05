#pragma checksum "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ab38278ed21a128bff6af26f0d7780b53cd305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrder__OrderDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrder/_OrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminOrder/_OrderDetail.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminOrder__OrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ab38278ed21a128bff6af26f0d7780b53cd305", @"/Areas/Admin/Views/AdminOrder/_OrderDetail.cshtml")]
    public class Areas_Admin_Views_AdminOrder__OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigitalShop.Models.OrderDetailViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(59, 23, false);
#line 2 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(82, 251, true);
            WriteLiteral("\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n                <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(334, 17, false);
#line 7 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                                   Write(ViewBag.OrderCode);

#line default
#line hidden
            EndContext();
            BeginContext(351, 108, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(460, 72, false);
#line 11 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label("Ship Name", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(532, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(555, 78, false);
#line 12 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label(ViewBag.ShipName, null, new { @class = "control-label col-md-10" }));

#line default
#line hidden
            EndContext();
            BeginContext(633, 69, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(703, 74, false);
#line 15 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label("Ship Mobile", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(777, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(800, 80, false);
#line 16 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label(ViewBag.ShipMobile, null, new { @class = "control-label col-md-10" }));

#line default
#line hidden
            EndContext();
            BeginContext(880, 69, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(950, 75, false);
#line 19 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label("Ship Address", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1048, 81, false);
#line 20 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
               Write(Html.Label(ViewBag.ShipAddress, null, new { @class = "control-label col-md-10" }));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 587, true);
            WriteLiteral(@"
                </div>

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
#line 37 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                     if (Model.Count() != 0)
                    {

#line default
#line hidden
            BeginContext(1785, 33, true);
            WriteLiteral("                        <tbody>\r\n");
            EndContext();
#line 40 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
            BeginContext(1909, 139, true);
            WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2049, 46, false);
#line 45 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2223, 43, false);
#line 48 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2266, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2394, 41, false);
#line 51 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Prices));

#line default
#line hidden
            EndContext();
            BeginContext(2435, 85, true);
            WriteLiteral("$\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 54 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"

                            }

#line default
#line hidden
            BeginContext(2553, 34, true);
            WriteLiteral("                        </tbody>\r\n");
            EndContext();
#line 57 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                    }

#line default
#line hidden
            BeginContext(2610, 102, true);
            WriteLiteral("                </table>\r\n                <p style=\"text-align:right ;padding-right:159px\"><b>Total : ");
            EndContext();
            BeginContext(2713, 18, false);
#line 59 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminOrder\_OrderDetail.cshtml"
                                                                       Write(ViewBag.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2731, 62, true);
            WriteLiteral(" $</b></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DigitalShop.Models.OrderDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591