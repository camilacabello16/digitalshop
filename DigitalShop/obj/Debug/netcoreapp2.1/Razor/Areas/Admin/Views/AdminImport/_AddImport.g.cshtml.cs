#pragma checksum "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34393c3223eeef5c0c21e50bd09e2052383edfce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminImport__AddImport), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminImport/_AddImport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminImport/_AddImport.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminImport__AddImport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34393c3223eeef5c0c21e50bd09e2052383edfce", @"/Areas/Admin/Views/AdminImport/_AddImport.cshtml")]
    public class Areas_Admin_Views_AdminImport__AddImport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigitalShop.Models.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FormValidation/addImportValidation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(75, 6520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1409ded411d24e849a3c543cd8555f2d", async() => {
                BeginContext(81, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(87, 6499, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b680570015824aa984576fd7b83177a1", async() => {
                    BeginContext(93, 471, true);
                    WriteLiteral(@"
        <form id=""formAddImport"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            Import
                        </div>
                        <!-- /.panel-heading -->
                        <div class=""panel-body"">
                            <div class=""form-group"">
                                ");
                    EndContext();
                    BeginContext(565, 67, false);
#line 16 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                           Write(Html.Label("Code", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(632, 284, true);
                    WriteLiteral(@"
                                <input type=""text"" id=""code"" name=""Code"" class=""form-control col-md-10"">
                            </div>
                            <div class=""form-group"" style=""margin-bottom:30px ;float: left; width: 100%;"">
                                ");
                    EndContext();
                    BeginContext(917, 69, false);
#line 20 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                           Write(Html.Label("Detail", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(986, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(1021, 66, false);
#line 21 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                           Write(Html.TextArea("Detail", new { @class = "form-control col-md-10" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1087, 158, true);
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\" style=\"float: left; width: 100%;\">\r\n                                ");
                    EndContext();
                    BeginContext(1246, 75, false);
#line 24 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                           Write(Html.Label("List Product", null, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1321, 719, true);
                    WriteLiteral(@"
                            </div>
                            <div class=""dataTable_wrapper"">
                                <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                                    <thead>
                                        <tr>
                                            <th>
                                                Name
                                            </th>

                                            <th>
                                                Quantity
                                            </th>
                                        </tr>
                                    </thead>
");
                    EndContext();
#line 39 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                                     if (Model.Count() != 0)
                                    {

#line default
#line hidden
                    BeginContext(2141, 49, true);
                    WriteLiteral("                                        <tbody>\r\n");
                    EndContext();
#line 42 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                                             foreach (var item in Model)
                                            {


#line default
#line hidden
                    BeginContext(2313, 187, true);
                    WriteLiteral("                                                <tr class=\"odd gradeX\">\r\n                                                    <td>\r\n                                                        ");
                    EndContext();
                    BeginContext(2501, 39, false);
#line 47 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                    EndContext();
                    BeginContext(2540, 214, true);
                    WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        <input type=\"number\" data-productId=\"");
                    EndContext();
                    BeginContext(2755, 7, false);
#line 51 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                                                                                        Write(item.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(2762, 154, true);
                    WriteLiteral("\" class=\"form-control quantityImport\">\r\n                                                    </td>\r\n                                                </tr>\r\n");
                    EndContext();
#line 54 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"

                                            }

#line default
#line hidden
                    BeginContext(2965, 50, true);
                    WriteLiteral("                                        </tbody>\r\n");
                    EndContext();
#line 57 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                                    }

#line default
#line hidden
                    BeginContext(3054, 778, true);
                    WriteLiteral(@"                                </table>
                                <div style=""text-align:center; margin-left:110px"" >
                                    <button type=""button"" style=""width:200px"" disabled class=""btn btn-primary"" id=""btnSaveImport"">Import</button>
                                </div>
                            </div>
                            <!-- /.table-responsive -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
                </div>
            </div>
        </form>
        <script>
    function GetData() {
        $.ajax({
            async: true,
            method: ""GET"",
            dataType: ""html"",
            url: '");
                    EndContext();
                    BeginContext(3833, 42, false);
#line 77 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
             Write(Url.Action("GetListImport", "AdminImport"));

#line default
#line hidden
                    EndContext();
                    BeginContext(3875, 978, true);
                    WriteLiteral(@"',
                data: {},
                success: function (response) {
                    $(""#contentAdmin"").html("""");
                    $(""#contentAdmin"").html(response);
                },
                error: function () {
                    alert('test data index error');
                }
            });
    };

    var listImportDetail = [];
    var j = 0;

    $(document).ready(function () {
        $(""#btnSaveImport"").click(function () {
            $("".quantityImport"").each(function (i, importDetail) {
                if ($(this).val() != 0 && $(this).val() != null) {
                    listImportDetail[j] = {
                        ProductId: $(this).attr(""data-productId""),
                        Quantity: $(this).val()
                    }
                    j = j + 1;

                }
            });

            $.ajax({
                async: true,
                method: ""post"",
                url: '");
                    EndContext();
                    BeginContext(4854, 35, false);
#line 108 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminImport\_AddImport.cshtml"
                 Write(Url.Action("Update", "AdminImport"));

#line default
#line hidden
                    EndContext();
                    BeginContext(4889, 777, true);
                    WriteLiteral(@"',
                data: {
                    importViewModel: {
                        Code: $(""#code"").val(),
                        Detail: $(""#Detail"").val()
                    },
                    listImportDetail: listImportDetail
                },
                success: function (response) {
                    if (response != """") {
                        alert(response);
                    }
                    else {
                        GetData();
                        alert(""Successfully !"");
                    }
                },
                error: function () {
                    alert(""Fail!"");
                }

            });
        });
    });
        </script>
        <!--Validation form-->
        ");
                    EndContext();
                    BeginContext(5666, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e59809ef6c4d59bfd345e8bcc74a7f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5717, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(5727, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793c5c9f600a4e5d894bb22d0ffd7816", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5793, 786, true);
                    WriteLiteral(@"
        <script type=""text/javascript"">
            $(document).ready(function () {
                console.log($(""#formAddImport"").valid());
                $(""#formAddImport"").keyup(function () {
                    if ($(""#formAddImport"").valid()) {
                        $('#btnSaveImport').prop('disabled', false);
                    }
                    else {
                        $('#btnSaveImport').prop('disabled', true);
                    }
                });

            });

        </script>
        <!--End Validation form-->
        <script>
            $(document).ready(function () {
                $('#dataTables-example').DataTable({
                    responsive: true
                });
            });
        </script>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6586, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6595, 9, true);
            WriteLiteral("\r\n</html>");
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
