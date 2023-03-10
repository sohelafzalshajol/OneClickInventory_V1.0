#pragma checksum "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1306c61349fd008448930c4d5bd7cfbcf2fd2ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
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
#nullable restore
#line 1 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\_ViewImports.cshtml"
using OneClickInventory.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1306c61349fd008448930c4d5bd7cfbcf2fd2ddf", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cca2dd2f6d06493da8e671d3c3679649e59604", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c924895f2f9df0ddd79e7f458bd899546fde7f", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 7 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#nullable restore
#line 19 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <code>");
#nullable restore
#line 21 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code>");
#nullable restore
#line 21 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br />\r\n");
#nullable restore
#line 22 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
