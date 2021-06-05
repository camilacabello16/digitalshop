#pragma checksum "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30cc726f0a4f6241a131b53b7d9e3beaa6625970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategory__ListCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategory/_ListCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminCategory/_ListCategory.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminCategory__ListCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30cc726f0a4f6241a131b53b7d9e3beaa6625970", @"/Areas/Admin/Views/AdminCategory/_ListCategory.cshtml")]
    public class Areas_Admin_Views_AdminCategory__ListCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigitalShop.Models.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1054, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                List Category
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""dataTable_wrapper"">
                    <button type=""button"" class=""btn btn-info "" style=""margin-bottom: 10px"" onclick=""EditAction();"">Add Category</button>
                    <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Activate
                                </th>
                                <th>
                                    Action
                                </th>
                            </tr>
    ");
            WriteLiteral("                    </thead>\r\n");
            EndContext();
#line 26 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                         if (Model.Count() != 0)
                        {

#line default
#line hidden
            BeginContext(1182, 37, true);
            WriteLiteral("                            <tbody>\r\n");
            EndContext();
#line 29 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
            BeginContext(1318, 139, true);
            WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1458, 39, false);
#line 34 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 87, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
            EndContext();
#line 37 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                                         if (item.Status == true)
                                        {

#line default
#line hidden
            BeginContext(1694, 85, true);
            WriteLiteral("                                            <p style=\"color:darkgreen\">Activate</p>\r\n");
            EndContext();
#line 40 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(1911, 81, true);
            WriteLiteral("                                            <p style=\"color:red\">Deactivate</p>\r\n");
            EndContext();
#line 44 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2035, 166, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2201, "\"", 2231, 3);
            WriteAttributeValue("", 2211, "EditAction(", 2211, 11, true);
#line 47 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
WriteAttributeValue("", 2222, item.Id, 2222, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2230, ")", 2230, 1, true);
            EndWriteAttribute();
            BeginContext(2232, 109, true);
            WriteLiteral(" id=\"btnEdit\">Edit</button>\r\n                                        <button type=\"button\" class=\"btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2341, "\"", 2369, 3);
            WriteAttributeValue("", 2351, "Deactive(", 2351, 9, true);
#line 48 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
WriteAttributeValue("", 2360, item.Id, 2360, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2368, ")", 2368, 1, true);
            EndWriteAttribute();
            BeginContext(2370, 102, true);
            WriteLiteral(">Deactive</button>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 51 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"

                                }

#line default
#line hidden
            BeginContext(2509, 38, true);
            WriteLiteral("                            </tbody>\r\n");
            EndContext();
#line 54 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
                        }

#line default
#line hidden
            BeginContext(2574, 148, true);
            WriteLiteral("                    </table>\r\n                    <!--Modal Update-->\r\n                    <div class=\"modal fade\" id=\"updateModal\" role=\"dialog\">\r\n");
            EndContext();
            BeginContext(2771, 443, true);
            WriteLiteral(@"                    </div>
                    <!--End Modal Update-->

                </div>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
</div>

<script type=""text/javascript"">
    function GetData() {
        $.ajax({
            async: true,
            method: ""GET"",
            dataType: ""html"",
            url: '");
            EndContext();
            BeginContext(3215, 46, false);
#line 77 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
             Write(Url.Action("GetListCategory", "AdminCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 492, true);
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

    function Deactive(id) {
        $.ajax({
            async: true,
            method: ""Get"",
            dataType: ""html"",
            url: '");
            EndContext();
            BeginContext(3754, 39, false);
#line 94 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
             Write(Url.Action("Deactive", "AdminCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(3793, 310, true);
            WriteLiteral(@"',
            data: {id : id},
            success: function () {
                alert('Deactive successfullly !');
                GetData();
            }
        })

    };

    function EditAction(id) {
        $.ajax({
            async: true,
            method: ""Get"",
            url: '");
            EndContext();
            BeginContext(4104, 41, false);
#line 108 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
             Write(Url.Action("EditAction", "AdminCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(4145, 359, true);
            WriteLiteral(@"',
            data: { id: id },
            success: function (response) {
                $(""#updateModal"").html(response);
                $(""#updateModal"").modal(""show"");
            }
        })
    }
    var actionName;
    function submitUpdate() {

        $.ajax({
            async: true,
            method: ""Post"",
            url: '");
            EndContext();
            BeginContext(4505, 37, false);
#line 122 "D:\DOAN\DigitalShop\DigitalShop\Areas\Admin\Views\AdminCategory\_ListCategory.cshtml"
             Write(Url.Action("Update", "AdminCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(4542, 1029, true);
            WriteLiteral(@"',
            data: {
                categoryViewModel: object = {
                    Id: $(""#Id"").val(),
                    Name: $(""#Name"").val(),
                    Status: $(""#Status"").val(),
                    IsUpdate: $(""#IsUpdate"").val()
                }
            },
            success: function (response) {
                if (response!="""") {
                    alert(response);
                }
                else {
                    alert(""Successfully !"");
                    GetData();
                }
               
            },
            error: function () {
                if (object.IsUpdate == true) {
                    alert(""Update fail !"");
                }
                else {
                    alert(""Create fail !"");
                }
            }

        })

    }

</script>

<script>
    $(document).ready(function () {
        $('#dataTables-example').DataTable({
            responsive: true
        });
    });
</scri");
            WriteLiteral("pt>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DigitalShop.Models.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591