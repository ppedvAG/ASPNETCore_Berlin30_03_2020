#pragma checksum "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d4bc277ba0bf7687fa6f43a12391ed795fdc86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Welcome_SetHiddenFieldValue), @"mvc.1.0.view", @"/Views/Welcome/SetHiddenFieldValue.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Welcome/SetHiddenFieldValue.cshtml", typeof(AspNetCore.Views_Welcome_SetHiddenFieldValue))]
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
#line 1 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\_ViewImports.cshtml"
using WorkingWithStateManagement;

#line default
#line hidden
#line 2 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\_ViewImports.cshtml"
using WorkingWithStateManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d4bc277ba0bf7687fa6f43a12391ed795fdc86", @"/Views/Welcome/SetHiddenFieldValue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c928200fe3f81b55be7564ba3161195dad6320d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Welcome_SetHiddenFieldValue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetHiddenFieldValue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
  
    ViewData["Title"] = "SetHiddenFieldValue";

#line default
#line hidden
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 790, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d4bc277ba0bf7687fa6f43a12391ed795fdc864513", async() => {
                BeginContext(111, 126, true);
                WriteLiteral("\r\n    <h1>SetHiddenFieldValue</h1>\r\n\r\n    <div>\r\n        <h4>User</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            ");
                EndContext();
                BeginContext(238, 33, false);
#line 14 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(271, 53, true);
                WriteLiteral("\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(325, 40, false);
#line 16 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(365, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(439, 36, false);
#line 19 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(475, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(548, 39, false);
#line 22 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(587, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(661, 35, false);
#line 25 "C:\GitHub_Projects\aspnetcore-mvc-series\StateManagement\Views\Welcome\SetHiddenFieldValue.cshtml"
           Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(696, 116, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Submit\" />|\r\n        ");
                EndContext();
                BeginContext(812, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d4bc277ba0bf7687fa6f43a12391ed795fdc867407", async() => {
                    BeginContext(833, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
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
                EndContext();
                BeginContext(841, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(862, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591