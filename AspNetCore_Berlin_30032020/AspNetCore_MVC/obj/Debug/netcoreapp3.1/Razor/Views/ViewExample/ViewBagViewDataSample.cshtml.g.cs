#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\ViewExample\ViewBagViewDataSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89940f5474d3889f76e70394019b5d90a327d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewExample_ViewBagViewDataSample), @"mvc.1.0.view", @"/Views/ViewExample/ViewBagViewDataSample.cshtml")]
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
#line 1 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\_ViewImports.cshtml"
using AspNetCore_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\_ViewImports.cshtml"
using AspNetCore_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89940f5474d3889f76e70394019b5d90a327d57", @"/Views/ViewExample/ViewBagViewDataSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a0962e4b70bba6118845b54d580015c7130d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewExample_ViewBagViewDataSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\ViewExample\ViewBagViewDataSample.cshtml"
  
    ViewData["Title"] = "ViewBagViewDataSample";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewBagViewDataSample</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\ViewExample\ViewBagViewDataSample.cshtml"
Write(ViewData["abc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" //def\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\ViewExample\ViewBagViewDataSample.cshtml"
Write(ViewBag.HansJuergenOtto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" //wohnt in Stuttgart\r\n\r\n");
#nullable restore
#line 15 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\ViewExample\ViewBagViewDataSample.cshtml"
Write(ViewBag.ComplexType.Test);

#line default
#line hidden
#nullable disable
            WriteLiteral(" //Testausgabe\r\n\r\n");
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
