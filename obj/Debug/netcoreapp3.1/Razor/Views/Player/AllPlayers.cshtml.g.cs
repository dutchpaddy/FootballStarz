#pragma checksum "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfa5cc26c56893823ec3949502c38484e3192e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_AllPlayers), @"mvc.1.0.view", @"/Views/Player/AllPlayers.cshtml")]
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
#nullable restore
#line 1 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfa5cc26c56893823ec3949502c38484e3192e7", @"/Views/Player/AllPlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Player_AllPlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlayerViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
  
    ViewData["Title"] = "AllPlayers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
Write(ViewData["PlayerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 11 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
Write(Html.ActionLink("Create Player", "CreatePlayer", "Player"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center alert-info\">\r\n        <h1>\r\n            There are no players available.\r\n        </h1>\r\n    </div>\r\n");
#nullable restore
#line 22 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n        <th>Player Name</th>\r\n        <th>Birth Date</th>\r\n        <th>Nationality</th>\r\n        <th>Club</th>\r\n");
#nullable restore
#line 31 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Edit</th>\r\n            <th>Delete</th>\r\n            <th>Details</th>\r\n");
#nullable restore
#line 36 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 39 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
             foreach (PlayerViewModel player in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 42 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                   Write(player.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                   Write(player.BirthDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                   Write(player.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                   Write(player.Club.ClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 48 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                       Write(Html.ActionLink("Edit", "EditPlayer", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                       Write(Html.ActionLink("Delete", "DeletePlayer", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                       Write(Html.ActionLink("Details", "PlayerDetails", "Player", new { @id = player.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 53 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 57 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\AllPlayers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlayerViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591