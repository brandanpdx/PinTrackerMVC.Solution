#pragma checksum "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74864f2e0f6035e16125c160dd1d6efb0c86469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Index), @"mvc.1.0.view", @"/Views/Machines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machines/Index.cshtml", typeof(AspNetCore.Views_Machines_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74864f2e0f6035e16125c160dd1d6efb0c86469", @"/Views/Machines/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a10a861793fa7151995fc7921347e53aeee5474", @"/Views/_ViewImports.cshtml")]
    public class Views_Machines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 22, true);
            WriteLiteral("<h1>All Machines</h1>\n");
            EndContext();
#line 5 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
 foreach(Machine machine in Model)
{

#line default
#line hidden
            BeginContext(101, 40, true);
            WriteLiteral("<ol>\n    <ul>\n        <li>Machine Name: ");
            EndContext();
            BeginContext(142, 12, false);
#line 9 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
                     Write(machine.name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 32, true);
            WriteLiteral("</li>\n        <li>Manufacturer: ");
            EndContext();
            BeginContext(187, 20, false);
#line 10 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
                     Write(machine.manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(207, 24, true);
            WriteLiteral("</li>\n        <li>Year: ");
            EndContext();
            BeginContext(232, 12, false);
#line 11 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
             Write(machine.year);

#line default
#line hidden
            EndContext();
            BeginContext(244, 27, true);
            WriteLiteral("</li>\n        <li>Website: ");
            EndContext();
            BeginContext(272, 17, false);
#line 12 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"
                Write(machine.ipdb_link);

#line default
#line hidden
            EndContext();
            BeginContext(289, 32, true);
            WriteLiteral("</li>\n    </ul>\n    <br>\n\n</ol>\n");
            EndContext();
#line 17 "/Users/drakewilcox/Desktop/PinTrackerMVC.Solution/PinTrackerMVC/Views/Machines/Index.cshtml"

}

#line default
#line hidden
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
