#pragma checksum "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\DeleteStadium.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867aab2609cdb15411565894afeba821ecbcaca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_DeleteStadium), @"mvc.1.0.view", @"/Views/Stadium/DeleteStadium.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867aab2609cdb15411565894afeba821ecbcaca8", @"/Views/Stadium/DeleteStadium.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stadium_DeleteStadium : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StadiumViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\DeleteStadium.cshtml"
   ViewData["Title"] = "Delete Stadium"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <h2 class=\"text-danger\">You are about to delete the Stadium: ");
#nullable restore
#line 6 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\DeleteStadium.cshtml"
                                                            Write(Model.StadiumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Are you sure?</h3>\r\n</div>\r\n");
#nullable restore
#line 9 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\DeleteStadium.cshtml"
Write(Html.ActionLink("Cancel", "AllStadiums", "Stadium", null, new { @class = "btn btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\DeleteStadium.cshtml"
Write(Html.ActionLink("Yes, sure!", "StadiumDeleted", "Stadium", new { @id = Model.StadiumId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StadiumViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
