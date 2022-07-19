#pragma checksum "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8891b07c59c4de3a2b2eb2e57ae72f3fff56feca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_AllForeignPlayers), @"mvc.1.0.view", @"/Views/Player/AllForeignPlayers.cshtml")]
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
#nullable restore
#line 1 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8891b07c59c4de3a2b2eb2e57ae72f3fff56feca", @"/Views/Player/AllForeignPlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Player_AllForeignPlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Player>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
  
    ViewData["Title"] = "AllForeignPlayers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
Write(ViewData["PlayerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n");
#nullable restore
#line 12 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center alert-info\">\r\n        <h1>\r\n            There are no foreign players available.\r\n        </h1>\r\n    </div>\r\n");
#nullable restore
#line 19 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n    <th>Player Name</th>\r\n    <th>Birth Date</th>\r\n    <th>Nationality</th>\r\n");
#nullable restore
#line 27 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <th>Edit</th>\r\n        <th>Delete</th>\r\n        <th>Details</th>\r\n");
#nullable restore
#line 32 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
         foreach (Player player in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
               Write(player.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
               Write(player.BirthDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
               Write(player.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 43 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
                   Write(Html.ActionLink("Edit", "EditPlayer", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
                   Write(Html.ActionLink("Delete", "DeletePlayer", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
                   Write(Html.ActionLink("Details", "PlayerDetails", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 48 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 52 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Player\AllForeignPlayers.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Player>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
