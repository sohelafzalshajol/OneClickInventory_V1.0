#pragma checksum "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5074aef6dd346bd8b24c7f74db1f5812edd9414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminlteMainHeader), @"mvc.1.0.view", @"/Views/Shared/_AdminlteMainHeader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5074aef6dd346bd8b24c7f74db1f5812edd9414", @"/Views/Shared/_AdminlteMainHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63cca2dd2f6d06493da8e671d3c3679649e59604", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminlteMainHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneClickInventory.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/LogoOneClickInventory.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("OneClickInventory Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
  
    UserProfile profile = Context.UserProfile.SingleOrDefault(x => x.ApplicationUserId.Equals(Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"main-header\">\r\n    <!-- Logo -->\r\n    <a href=\"/\" class=\"logo\">\r\n        <!-- mini logo for sidebar mini 50x50 pixels -->\r\n        <span class=\"logo-mini\"><b>OCI</b></span>\r\n        <!-- logo for regular state and mobile devices -->\r\n");
            WriteLiteral("        <span class=\"logo-lg\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5074aef6dd346bd8b24c7f74db1f5812edd94147561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>
    </a>
    <!-- Header Navbar: style can be found in header.less -->
    <nav class=""navbar navbar-static-top"">
        <!-- Sidebar toggle button-->
        <a href=""#"" class=""sidebar-toggle"" data-toggle=""push-menu"" role=""button"">
            <span class=""sr-only"">Toggle navigation</span>
        </a>
        <div class=""navbar-custom-menu"">
            <ul class=""nav navbar-nav"">

");
#nullable restore
#line 26 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- User Account: style can be found in dropdown.less -->\r\n                    <li class=\"dropdown user user-menu\">\r\n                        <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1388, "\"", 1417, 1);
#nullable restore
#line 31 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
WriteAttributeValue("", 1394, profile.ProfilePicture, 1394, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"user-image profilePicture\" alt=\"User Image\">\r\n                            <span class=\"hidden-xs\">");
#nullable restore
#line 32 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </a>\r\n                        <ul class=\"dropdown-menu\">\r\n                            <!-- User image -->\r\n                            <li class=\"user-header\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1766, "\"", 1795, 1);
#nullable restore
#line 37 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
WriteAttributeValue("", 1772, profile.ProfilePicture, 1772, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle profilePicture\" alt=\"User Image\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 39 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </li>

                            <!-- Menu Footer-->

                            <li class=""user-footer"">

                                <div class=""pull-left"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 2214, "\"", 2259, 1);
#nullable restore
#line 48 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"
WriteAttributeValue("", 2221, Url.Action("UserProfile", "UserRole"), 2221, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-flat\">Profile</a>\r\n                                </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5074aef6dd346bd8b24c7f74db1f5812edd941412300", async() => {
                WriteLiteral("\r\n                                    <div class=\"pull-right\">\r\n                                        <button type=\"submit\" class=\"btn btn-default btn-flat\">Sign out</button>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 59 "C:\FullProject\OneClickInventory\OneClickInventory\Views\Shared\_AdminlteMainHeader.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n</header>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OneClickInventory.Data.ApplicationDbContext Context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneClickInventory.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
