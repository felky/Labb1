#pragma checksum "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3752b719ecc244db24a96df2799584c131c51db8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_ViewProduct), @"mvc.1.0.view", @"/Views/Store/ViewProduct.cshtml")]
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
#line 1 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\_ViewImports.cshtml"
using ITHS_Labb1_FelixGramell;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\_ViewImports.cshtml"
using ITHS_Labb1_FelixGramell.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3752b719ecc244db24a96df2799584c131c51db8", @"/Views/Store/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c528d4b643c9a667d7e371f000d7225d29cc97c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITHS_Labb1_FelixGramell.ViewModels.ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
  
    ViewData["Title"] = "ViewProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewProduct</h1>\r\n\r\n<p> ");
#nullable restore
#line 9 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
Write(Model.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITHS_Labb1_FelixGramell.ViewModels.ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591