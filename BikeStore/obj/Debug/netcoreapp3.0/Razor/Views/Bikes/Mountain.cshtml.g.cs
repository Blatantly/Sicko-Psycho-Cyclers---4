#pragma checksum "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7bfb04cc9a6321006feb8fe7812850b537a552c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bikes_Mountain), @"mvc.1.0.view", @"/Views/Bikes/Mountain.cshtml")]
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
#line 1 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\_ViewImports.cshtml"
using BikeStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\_ViewImports.cshtml"
using BikeStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7bfb04cc9a6321006feb8fe7812850b537a552c", @"/Views/Bikes/Mountain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb73e158b4535bfeef149d60aeb8cac33bf025a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bikes_Mountain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BikeStore.Models.BikeListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml"
  
    ViewData["Title"] = "Mountain Bikes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1>Mountain Bike Model List</h1>\n\n");
#nullable restore
#line 8 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 11 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml"
   Write(Html.ActionLink(item.ProductModel, "Details", new { id = item.ProductModelID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <p>");
#nullable restore
#line 12 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 14 "C:\Users\jerem\source\repos\Sicko Psycho Cyclers - 4\BikeStore\Views\Bikes\Mountain.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BikeStore.Models.BikeListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
