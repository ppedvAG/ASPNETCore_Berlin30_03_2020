#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\PartialViewSamples\PartialViewWithViewDataDirectory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fea0444292b9c6732ce55efa389a71e219582ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialViewSamples_PartialViewWithViewDataDirectory), @"mvc.1.0.view", @"/Views/PartialViewSamples/PartialViewWithViewDataDirectory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fea0444292b9c6732ce55efa389a71e219582ca", @"/Views/PartialViewSamples/PartialViewWithViewDataDirectory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a0962e4b70bba6118845b54d580015c7130d2e", @"/Views/_ViewImports.cshtml")]
    public class Views_PartialViewSamples_PartialViewWithViewDataDirectory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCore_MVC.ViewModels.BlogCommentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\PartialViewSamples\PartialViewWithViewDataDirectory.cshtml"
  
    ViewData["Title"] = "PartialViewWithViewDataDirectory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PartialViewWithViewDataDirectory</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\PartialViewSamples\PartialViewWithViewDataDirectory.cshtml"
Write(await Html.PartialAsync("_ShowComments", Model.TestProperty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p>PartialViews als \"Liste\" oder als Template für die jeweilige Ausgabe</p>\r\n");
#nullable restore
#line 13 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_MVC\Views\PartialViewSamples\PartialViewWithViewDataDirectory.cshtml"
  
    var index = 0;

    //Eine Partielle View bekommt hier eine Kopie vom ViewData-Wörterbuch.
    foreach (var blog in Model.Blogs)
    {
        await Html.PartialAsync("_ArticleSection",
                                blog,
                                new ViewDataDictionary(ViewData)
                                {
                                    { "index", index }
                                        });

        index++;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_MVC.ViewModels.BlogCommentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
