#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\ViewBag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e2556f92d52eb440be2dd07ecd5738cb56f8eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewBag_Index), @"mvc.1.0.view", @"/Views/ViewBag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ViewBag/Index.cshtml", typeof(AspNetCore.Views_ViewBag_Index))]
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
#line 1 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\_ViewImports.cshtml"
using WorkingWithStateManagement;

#line default
#line hidden
#line 2 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\_ViewImports.cshtml"
using WorkingWithStateManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e2556f92d52eb440be2dd07ecd5738cb56f8eb", @"/Views/ViewBag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c928200fe3f81b55be7564ba3161195dad6320d0", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewBag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\ViewBag\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var userId = ViewBag.UserId;
    var name = ViewBag.Name;
    var age = ViewBag.Age;

#line default
#line hidden
            BeginContext(135, 32, true);
            WriteLiteral("\r\n<h1>ViewBag</h1>\r\n\r\nUser Id : ");
            EndContext();
            BeginContext(168, 6, false);
#line 11 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\ViewBag\Index.cshtml"
     Write(userId);

#line default
#line hidden
            EndContext();
            BeginContext(174, 15, true);
            WriteLiteral("<br />\r\nName : ");
            EndContext();
            BeginContext(190, 4, false);
#line 12 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\ViewBag\Index.cshtml"
  Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(194, 14, true);
            WriteLiteral("<br />\r\nAge : ");
            EndContext();
            BeginContext(209, 3, false);
#line 13 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\StateManagement\Views\ViewBag\Index.cshtml"
 Write(age);

#line default
#line hidden
            EndContext();
            BeginContext(212, 12, true);
            WriteLiteral("<br />\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
