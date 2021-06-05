#pragma checksum "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25cacf8975412ea964677c6f054096dbec2f62fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminReport__ListTopSeller), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminReport/_ListTopSeller.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminReport/_ListTopSeller.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminReport__ListTopSeller))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25cacf8975412ea964677c6f054096dbec2f62fb", @"/Areas/Admin/Views/AdminReport/_ListTopSeller.cshtml")]
    public class Areas_Admin_Views_AdminReport__ListTopSeller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigitalShop.Models.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 325, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                Top Seller
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""dataTable_wrapper"">
                    ");
            EndContext();
            BeginContext(376, 72, false);
#line 11 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
               Write(Html.Label("StartDate", null, new { @class = "control-label col-md-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(448, 193, true);
            WriteLiteral("\r\n                    <div class=\"col-md-3\">\r\n                        <input type=\"date\" class=\"subcontent__input form-control\" id=\"startDate\">\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(642, 70, false);
#line 15 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
               Write(Html.Label("EndDate", null, new { @class = "control-label col-md-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(712, 338, true);
            WriteLiteral(@"
                    <div class=""col-md-3"">
                        <input type=""date"" class=""subcontent__input form-control"" id=""endDate"">
                    </div>
                    <button type=""submit"" onclick=""submitTopSeller()"" class=""btn btn-primary col-md-1"" id=""btnShowTopSeller"" style=""margin-bottom:50px"">Show</button>
");
            EndContext();
#line 20 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                     if (ViewBag.StartDate != null || ViewBag.EndDate != null)
                    {

#line default
#line hidden
            BeginContext(1153, 109, true);
            WriteLiteral("                        <label class=\"control-label col-md-12\" style=\"margin-bottom:50px; text-align:center\">");
            EndContext();
            BeginContext(1263, 17, false);
#line 22 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                                                                                        Write(ViewBag.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 8, true);
            WriteLiteral("   --   ");
            EndContext();
            BeginContext(1289, 15, false);
#line 22 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                                                                                                                  Write(ViewBag.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 23 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                    }

#line default
#line hidden
            BeginContext(1337, 801, true);
            WriteLiteral(@"                    <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>

                                <th>
                                    Image
                                </th>
                                <th>
                                    Price
                                </th>
                                <th>View</th>
                                <th>Quantity</th>
                                <th>Activate</th>
                                <th>Sold</th>
                            </tr>
                        </thead>
");
            EndContext();
#line 43 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                         if (Model.Count() != 0)
                        {

#line default
#line hidden
            BeginContext(2215, 37, true);
            WriteLiteral("                            <tbody>\r\n");
            EndContext();
#line 46 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
            BeginContext(2351, 151, true);
            WriteLiteral("                                    <tr class=\"odd gradeX\">\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2503, 39, false);
#line 51 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 143, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2685, "\"", 2708, 1);
#line 54 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
WriteAttributeValue("", 2691, item.AvatarImage, 2691, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2709, 119, true);
            WriteLiteral(" width=\"35\" height=\"70\" />\r\n                                        </td>\r\n                                        <td>");
            EndContext();
            BeginContext(2829, 43, false);
#line 56 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PriceOut));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2924, 44, false);
#line 57 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ViewCount));

#line default
#line hidden
            EndContext();
            BeginContext(2968, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3020, 43, false);
#line 58 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 60 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                             if (item.Status == true)
                                            {

#line default
#line hidden
            BeginContext(3234, 89, true);
            WriteLiteral("                                                <p style=\"color:darkgreen\">Activate</p>\r\n");
            EndContext();
#line 63 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3467, 85, true);
            WriteLiteral("                                                <p style=\"color:red\">Deactivate</p>\r\n");
            EndContext();
#line 67 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3599, 137, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3737, 39, false);
#line 70 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Sold));

#line default
#line hidden
            EndContext();
            BeginContext(3776, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 73 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"

                                }

#line default
#line hidden
            BeginContext(3905, 38, true);
            WriteLiteral("                            </tbody>\r\n");
            EndContext();
#line 76 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                        }

#line default
#line hidden
            BeginContext(3970, 538, true);
            WriteLiteral(@"                    </table>
                </div>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
</div>

<script>
        //$(document).ready(function () {
        //    $('#dataTables-example').DataTable({
        //        responsive: true
        //    });

        //});

    function submitTopSeller() {
            $.ajax({
                async: true,
                method: ""Post"",
                url: '");
            EndContext();
            BeginContext(4509, 41, false);
#line 99 "H:\Anh Lâm\MaiVanTuyen_1551059_DATN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminReport\_ListTopSeller.cshtml"
                 Write(Url.Action("GetTopSeller", "AdminReport"));

#line default
#line hidden
            EndContext();
            BeginContext(4550, 371, true);
            WriteLiteral(@"',
                data: {
                    startDate : $(""#startDate"").val(),
                    endDate : $(""#endDate"").val()
                },
                success: function (response) {
                    $(""#contentAdmin"").html("""");
                    $(""#contentAdmin"").html(response);
                }
            });
        };
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DigitalShop.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
