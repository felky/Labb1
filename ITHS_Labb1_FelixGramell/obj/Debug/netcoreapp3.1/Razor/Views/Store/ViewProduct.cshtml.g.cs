#pragma checksum "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785149da1505f1801eb569910446c6aa8c48ba54"
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
#nullable restore
#line 3 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785149da1505f1801eb569910446c6aa8c48ba54", @"/Views/Store/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c528d4b643c9a667d7e371f000d7225d29cc97c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITHS_Labb1_FelixGramell.ViewModels.ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
  
    ViewData["Title"] = "ViewProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 12 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                     Write(Model.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"lead\">");
#nullable restore
#line 13 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
               Write(Model.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr class=\"my-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 396, "\"", 424, 1);
#nullable restore
#line 15 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
WriteAttributeValue("", 402, Model.product.Img_Url, 402, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <ul>\r\n        <li><p><b>Switches: </b> ");
#nullable restore
#line 17 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                            Write(Model.productInformation.Switches);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n        <li><p><b>Layout: </b>");
#nullable restore
#line 18 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                         Write(Model.productInformation.Layout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n        <li><p><b>Language: </b>");
#nullable restore
#line 19 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                           Write(Model.productInformation.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n        <li><p><b>Size: </b> ");
#nullable restore
#line 20 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                        Write(Model.productInformation.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p></li>\r\n    </ul>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "785149da1505f1801eb569910446c6aa8c48ba548037", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
                                                                                WriteLiteral(Model.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "785149da1505f1801eb569910446c6aa8c48ba5410812", async() => {
                WriteLiteral("You must be logged in before adding to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\GAMERPC\source\repos\ITHS_Labb1_FelixGramell\ITHS_Labb1_FelixGramell\Views\Store\ViewProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
