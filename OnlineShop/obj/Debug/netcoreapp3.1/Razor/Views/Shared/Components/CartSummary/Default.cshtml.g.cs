#pragma checksum "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969c919ed69f651c605518364aecb07cfbd7d06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
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
#line 1 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969c919ed69f651c605518364aecb07cfbd7d06c", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df00d92246222b7fb366b3b0963bf25ebdb993f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Shared\Components\CartSummary\Default.cshtml"
     if (Model.Lines.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <small class=\"navbar-text\">\r\n            <b>Ваша Корзина:</b>\r\n            ");
#nullable restore
#line 8 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Shared\Components\CartSummary\Default.cshtml"
       Write(Model.Lines.Sum(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" шт.\r\n            <br />\r\n            ");
#nullable restore
#line 10 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Shared\Components\CartSummary\Default.cshtml"
       Write(Model.ComputeTotalValue().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </small>\r\n");
#nullable restore
#line 12 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
