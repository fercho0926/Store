#pragma checksum "C:\WorkSpaces\git\Store\Store\Pages\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bae6a58a27453b5ca589d6765a5e14b53974e3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Store.Pages.Products.Pages_Products_List), @"mvc.1.0.razor-page", @"/Pages/Products/List.cshtml")]
namespace Store.Pages.Products
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
#line 1 "C:\WorkSpaces\git\Store\Store\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkSpaces\git\Store\Store\Pages\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkSpaces\git\Store\Store\Pages\_ViewImports.cshtml"
using Store.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bae6a58a27453b5ca589d6765a5e14b53974e3a", @"/Pages/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8432e97badac86fc87236da3f399b80c35b9a9eb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\WorkSpaces\git\Store\Store\Pages\Products\List.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store.Pages.Products.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Store.Pages.Products.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Store.Pages.Products.ListModel>)PageContext?.ViewData;
        public Store.Pages.Products.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
