#pragma checksum "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Delivery\MailThanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca9db8a980d619b9b0de58514eea535331a5149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_MailThanks), @"mvc.1.0.view", @"/Views/Delivery/MailThanks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca9db8a980d619b9b0de58514eea535331a5149", @"/Views/Delivery/MailThanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df00d92246222b7fb366b3b0963bf25ebdb993f", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_MailThanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShop.Models.MailDelivery>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container text-center\">\r\n    <h3>Спасибо ");
#nullable restore
#line 4 "C:\tosts\dotnet\tostpj\OnlineShop\OnlineShop\Views\Delivery\MailThanks.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\r\n    <p>Ваш заказ будет ожидать вас на почте</p>    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Models.MailDelivery> Html { get; private set; }
    }
}
#pragma warning restore 1591
