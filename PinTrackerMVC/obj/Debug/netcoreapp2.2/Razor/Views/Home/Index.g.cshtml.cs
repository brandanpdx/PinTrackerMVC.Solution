#pragma checksum "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fb5feaf9799aeb35b050cdf007f8141d3d982aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/_ViewImports.cshtml"
using PinTrackerMVC;

#line default
#line hidden
#line 2 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/_ViewImports.cshtml"
using PinTrackerMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb5feaf9799aeb35b050cdf007f8141d3d982aa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a10a861793fa7151995fc7921347e53aeee5474", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 140, true);
            WriteLiteral("\r\n\r\n<div id=\"index-section\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome to the Portland Pinball Tracker!</h1>\r\n\r\n");
            EndContext();
#line 10 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Home/Index.cshtml"
         using (Html.BeginForm("Search", "Locations"))
        {

#line default
#line hidden
            BeginContext(252, 183, true);
            WriteLiteral("            <input type=\"text\" placeholder=\"Search..\" name=\"Search\" class=\"form-control\"/>\r\n\t\t\t\t\t\t<br>\r\n            <input type=\"submit\"  value=\"search\" class=\"btn btn-dark btn-lg\">\r\n");
            EndContext();
#line 15 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Home/Index.cshtml"
        }   

#line default
#line hidden
            BeginContext(449, 21, true);
            WriteLiteral("    </div> \r\n</div>\r\n");
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
