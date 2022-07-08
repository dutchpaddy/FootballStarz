#pragma checksum "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2611b53c162df1a6ab1ed60b1638794f1a57e5c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_CreateStadium), @"mvc.1.0.view", @"/Views/Stadium/CreateStadium.cshtml")]
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
#line 1 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\_ViewImports.cshtml"
using FootballStarz.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2611b53c162df1a6ab1ed60b1638794f1a57e5c3", @"/Views/Stadium/CreateStadium.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stadium_CreateStadium : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Stadium>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
  
    ViewData["Title"] = "CreateStadium";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create New Stadium</h2>\r\n\r\n");
#nullable restore
#line 8 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
Write(Html.ActionLink("Show All Stadiums", "AllStadiums", "Stadium"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
 using (Html.BeginForm("StadiumCreated", "Stadium", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.LabelFor(n => n.StadiumName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.TextBoxFor(n => n.StadiumName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.StadiumName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.LabelFor(n => n.BuildDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.TextBoxFor(n => n.BuildDate, "{0:yyyy-MM-dd}", new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.LabelFor(n => n.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.TextBoxFor(n => n.Location, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.LabelFor(n => n.StadiumImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 31 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.TextBoxFor(n => n.StadiumImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.StadiumImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.LabelFor(n => n.ClubId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.DropDownListFor(n => n.ClubId, new SelectList(ViewBag.Clubs, "ClubId", "ClubName"), "Select the home club", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.ClubId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-success\">Create Stadium</button>\r\n");
#nullable restore
#line 44 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\CreateStadium.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Stadium> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591