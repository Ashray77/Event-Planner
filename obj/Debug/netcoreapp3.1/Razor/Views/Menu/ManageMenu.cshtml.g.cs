#pragma checksum "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be41438332e95894022a71adadd9d1018ca951f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_ManageMenu), @"mvc.1.0.view", @"/Views/Menu/ManageMenu.cshtml")]
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
#line 1 "D:\Islington assignment\FYP code\EventPlanner\Views\_ViewImports.cshtml"
using EventPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Islington assignment\FYP code\EventPlanner\Views\_ViewImports.cshtml"
using EventPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be41438332e95894022a71adadd9d1018ca951f8", @"/Views/Menu/ManageMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf5fd31073c175dd6368f5604674d20ed979e68", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_ManageMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventPlanner.Models.Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
  
    ViewData["Title"] = "ManageMenu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ManageMenu</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be41438332e95894022a71adadd9d1018ca951f83716", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Menu_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Menu_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Item_starter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Item_maincourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Item_dessert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayNameFor(model => model.Menu_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Menu_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Menu_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Item_starter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Item_maincourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Item_dessert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.DisplayFor(modelItem => item.Menu_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Menu_id}, new {@Class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 60 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Menu_id}, new {@Class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Menu_id}, new {@Class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "D:\Islington assignment\FYP code\EventPlanner\Views\Menu\ManageMenu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventPlanner.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
