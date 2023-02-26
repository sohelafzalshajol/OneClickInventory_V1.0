#pragma checksum "C:\FullProject\OneClickInventory\OneClickInventory\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bec42ab8852f465b240cd1932c99d0758809f4"
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
#line 1 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using OneClickInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using OneClickInventory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using OneClickInventory.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using OneClickInventory.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\FullProject\OneClickInventory\OneClickInventory\Views\_ViewImports.cshtml"
using OneClickInventory.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8bec42ab8852f465b240cd1932c99d0758809f4", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cca2dd2f6d06493da8e671d3c3679649e59604", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <!-- Default box -->
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title text-primary""><i class=""fa fa-tag""></i> ");
#nullable restore
#line 13 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Product\Index.cshtml"
                                                                        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip""
                            title=""Collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                        <i class=""fa fa-times""></i>
                    </button>
                </div>
            </div>
            <div class=""box-body"">
                <div id=""Grid""></div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
              
            </div>
            <!-- /.box-footer-->
        </div>
        <!-- /.box -->
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {

            var dataManager = ej.DataManager({
                url: ""/api/Product"",
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            var dataManagerUnitOfMeasure = ej.DataManager({
                url: ""/api/UnitOfMeasure"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerBranch = ej.DataManager({
                url: ""/api/Branch"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerCurrency = ej.DataManager({
                url: ""/api/Currency"",
                adaptor: new ej.WebApiAdaptor()
            });

            dataManager.ready.done(function (e) { 
                $(""#Grid"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        insertUrl");
                WriteLiteral(@": ""/api/Product/Insert"",
                        updateUrl: ""/api/Product/Update"",
                        removeUrl: ""/api/Product/Remove"",
                    }),
                    toolbarSettings: {
                        showToolbar: true,
                        toolbarItems: [""add"", ""edit"", ""delete"", ""update"", ""cancel"", ""search"", ""printGrid""]
                    },
                    editSettings: {
                        allowEditing: true,
                        allowAdding: true,
                        allowDeleting: true,
                        showDeleteConfirmDialog: true,
                        editMode: ""dialog""
                    },
                    isResponsive: true,
                    enableResponsiveRow: true,
                    allowSorting: true,
                    allowSearching: true,
                    allowFiltering: true,
                    filterSettings: {
                        filterType: ""excel"",
                        maxFilterChoices: ");
                WriteLiteral(@"100,
                        enableCaseSensitivity: false
                    },
                    allowPaging: true,
                    pageSettings: { pageSize: 10, printMode: ej.Grid.PrintMode.CurrentPage },
                    columns: [
                        { field: ""ProductId"", headerText: 'Product Id', isPrimaryKey: true, isIdentity: true, visible: false },
                        { field: ""ProductName"", headerText: 'Product Name', validationRules: { required: true } },
                        { field: ""UnitOfMeasureId"", headerText: 'UOM', foreignKeyField: ""UnitOfMeasureId"", foreignKeyValue: ""UnitOfMeasureName"", dataSource: dataManagerUnitOfMeasure, validationRules: { required: true } },
                        { field: ""Barcode"", headerText: 'Barcode', },
                        { field: ""Description"", headerText: 'Description', },
                        { field: ""ProductQuantity"", headerText: 'ProductQuantity', },
                        { field: ""ProductImageUrl"", headerText: 'Pro");
                WriteLiteral(@"ductImageUrl', visible: false },
                        { field: ""DefaultBuyingPrice"", headerText: 'Buying Price', editType: ""numericedit"", format: ""{0:n2}"" },
                        { field: ""DefaultSellingPrice"", headerText: 'Selling Price', editType: ""numericedit"", format: ""{0:n2}"" },
                        { field: ""BranchId"", headerText: 'Branch', foreignKeyField: ""BranchId"", foreignKeyValue: ""BranchName"", dataSource: dataManagerBranch },
                        { field: ""CurrencyId"", headerText: 'Currency', foreignKeyField: ""CurrencyId"", foreignKeyValue: ""CurrencyCode"", dataSource: dataManagerCurrency },
                    ],
                    actionComplete: ""complete"",
                });
            });

            
        });

        function complete(args) {
            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Record"" });
            }
            if (args.requestType == 'beginedit' || args.requestType");
                WriteLiteral(@" == 'add') {
                $('#GridBranchId').ejDropDownList({ change: 'branchDdlChange' });
            }
        }

        function branchDdlChange(e) {
            $.ajax({
                url: '/api/Currency/GetByBranchId/' + e.selectedValue,
                type: 'GET',
                success: function (data) {
                    $(""#GridCurrencyId"").ejDropDownList({
                        dataSource: [data],
                        fields: { id: 'CurrencyId', text: 'CurrencyCode', value: 'CurrencyId' },
                        value: data.CurrencyId
                    });
                }
            })
        }


    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
