#pragma checksum "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf6d398ae4801afd3662ffffa5dc5774389081d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venue_ManageVenue), @"mvc.1.0.view", @"/Views/Venue/ManageVenue.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf6d398ae4801afd3662ffffa5dc5774389081d", @"/Views/Venue/ManageVenue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf5fd31073c175dd6368f5604674d20ed979e68", @"/Views/_ViewImports.cshtml")]
    public class Views_Venue_ManageVenue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventPlanner.Models.Venue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddVenue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
  
    ViewData["Title"] = "ManageVenue";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ManageVenue</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf6d398ae4801afd3662ffffa5dc5774389081d3736", async() => {
                WriteLiteral("Add New Venue");
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
#line 17 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Venue_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Venue_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Venue_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Venue_capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Venue_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.venue_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.Venue_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.Venue_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.Venue_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.Venue_capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.Venue_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.DisplayFor(modelItem => item.venue_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "D:\Islington assignment\FYP code\EventPlanner\Views\Venue\ManageVenue.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventPlanner.Models.Venue>> Html { get; private set; }
    }
}
#pragma warning restore 1591