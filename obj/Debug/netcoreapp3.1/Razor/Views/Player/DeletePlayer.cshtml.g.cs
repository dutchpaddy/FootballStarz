#pragma checksum "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\DeletePlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88668d67d9b489e7a7c2f218fcae328d131404dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_DeletePlayer), @"mvc.1.0.view", @"/Views/Player/DeletePlayer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88668d67d9b489e7a7c2f218fcae328d131404dc", @"/Views/Player/DeletePlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Player_DeletePlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\DeletePlayer.cshtml"
  
    ViewData["Title"] = "Delete Player";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>DeletePlayer</h2>\r\n\r\n<div class=\"text-left\">\r\n    <h2 class=\"text-danger\">You are about to delete the Player: ");
#nullable restore
#line 10 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\DeletePlayer.cshtml"
                                                           Write(Model.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Are you sure?</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 14 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\DeletePlayer.cshtml"
Write(Html.ActionLink("Cancel", "AllPlayers", "Player", null, new { @class = "btn btn-default"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Player\DeletePlayer.cshtml"
Write(Html.ActionLink("Yes, sure!", "PlayerDeleted", "Player", new { @id = Model.PlayerId }, new { @class="btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591