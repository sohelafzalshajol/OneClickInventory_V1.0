#pragma checksum "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shipment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a360a592131650381a9febd8e2d96c138f736b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shipment_Index), @"mvc.1.0.view", @"/Views/Shipment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a360a592131650381a9febd8e2d96c138f736b", @"/Views/Shipment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cca2dd2f6d06493da8e671d3c3679649e59604", @"/Views/_ViewImports.cshtml")]
    public class Views_Shipment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shipment\Index.cshtml"
  
    ViewData["Title"] = "Shipment";

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
                <h3 class=""box-title text-primary""><i class=""fa fa-truck""></i> ");
#nullable restore
#line 13 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shipment\Index.cshtml"
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
                url: ""/api/Shipment"",
                adaptor: new ej.WebApiAdaptor(),
                offline: true
            });

            var dataManagerWarehouse = ej.DataManager({
                url: ""/api/Warehouse"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerSalesOrder = ej.DataManager({
                url: ""/api/SalesOrder"",
                adaptor: new ej.WebApiAdaptor()
            });

            var dataManagerShipmentType = ej.DataManager({
                url: ""/api/ShipmentType"",
                adaptor: new ej.WebApiAdaptor()
            });

            dataManager.ready.done(function (e) { 
                $(""#Grid"").ejGrid({
                    dataSource: ej.DataManager({
                        json: e.result,
                        adaptor: new ej.remoteSaveAdaptor(),
                        ");
                WriteLiteral(@"insertUrl: ""/api/Shipment/Insert"",
                        updateUrl: ""/api/Shipment/Update"",
                        removeUrl: ""/api/Shipment/Remove"",
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
                        maxFil");
                WriteLiteral(@"terChoices: 100,
                        enableCaseSensitivity: false
                    },
                    allowPaging: true,
                    pageSettings: { pageSize: 10, printMode: ej.Grid.PrintMode.CurrentPage },
                    columns: [
                        { field: ""ShipmentId"", headerText: 'Shipment', isPrimaryKey: true, isIdentity: true, visible: false },
                        { field: ""ShipmentName"", headerText: 'Shipment / DO#', allowEditing: false },
                        { field: ""IsFullShipment"", headerText: 'Full Shipment', allowEditing: false, type: ""boolean"", editType: ""booleanedit"", defaultValue: true },
                        { field: ""SalesOrderId"", headerText: 'SO#', foreignKeyField: ""SalesOrderId"", foreignKeyValue: ""SalesOrderName"", dataSource: dataManagerSalesOrder, validationRules: { required: true } },
                        { field: ""ShipmentDate"", headerText: 'Shipment Date', editType: ""datepicker"", format: ""{0:MM/dd/yyyy}"", validationRules: { requir");
                WriteLiteral(@"ed: true } },
                        { field: ""ShipmentTypeId"", headerText: 'Shipment Type', foreignKeyField: ""ShipmentTypeId"", foreignKeyValue: ""ShipmentTypeName"", dataSource: dataManagerShipmentType },
                        { field: ""WarehouseId"", headerText: 'Warehouse', foreignKeyField: ""WarehouseId"", foreignKeyValue: ""WarehouseName"", dataSource: dataManagerWarehouse, validationRules: { required: true } },
                    ],
                    actionComplete: ""complete"",
                });
            });

            
        });

        function complete(args) {
            if (args.requestType == 'beginedit') {
                $(""#"" + this._id + ""_dialogEdit"").ejDialog({ title: ""Edit Record"" });
            }

            if (args.requestType == 'beginedit' || args.requestType == 'add') {
                var selected = $('#GridSalesOrderId').data('ejDropDownList');
                var selectedValue = parseInt(selected.option('value'));
                var selectedText = sel");
                WriteLiteral(@"ected.option('text');
                $.ajax({
                    type: 'GET',
                    url: '/api/SalesOrder/GetNotShippedYet',
                    success: function (data) {
                        if (args.requestType == 'beginedit') {
                            data.push({ 'SalesOrderId': selectedValue, 'SalesOrderName': selectedText });
                        }

                        $(""#GridSalesOrderId"").ejDropDownList({
                            dataSource: data,
                            fields: { id: 'SalesOrderId', text: 'SalesOrderName', value: 'SalesOrderId' },
                            value: selectedValue
                        });
                    }
                });

            }

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
