#pragma checksum "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e844ba1d7777088b2f0d91f9b6a3ead9d048af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e844ba1d7777088b2f0d91f9b6a3ead9d048af", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Login</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4 col-md-offset-4\">\r\n");
#nullable restore
#line 10 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
             using (Html.BeginForm("LoggedIn","Account", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 13 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.LabelFor(n => n.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(n => n.Email, new {@class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(n => n.Email, "", new {@class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 18 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.LabelFor(n => n.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(n => n.Password, new {@class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(n => n.Password, "", new {@class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-success\">Login</button>\r\n");
#nullable restore
#line 24 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Account\Login.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
