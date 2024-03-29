#pragma checksum "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b2511cf2d80414387163305d6013ffbea3e084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Club_EditClub), @"mvc.1.0.view", @"/Views/Club/EditClub.cshtml")]
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
#line 1 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
using FootballStarz.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
using FootballStarz.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b2511cf2d80414387163305d6013ffbea3e084", @"/Views/Club/EditClub.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Club_EditClub : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
  
    ViewData["Title"] = "EditClub";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Club</h2>\r\n\r\n");
#nullable restore
#line 10 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
 using (Html.BeginForm("ClubEdited", "Club", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
Write(Html.HiddenFor(n => n.ClubId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.LabelFor(n => n.ClubName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.TextBoxFor(n => n.ClubName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.ValidationMessageFor(n => n.ClubName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.LabelFor(n => n.Founded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.TextBoxFor(a => a.Founded, "{0:yyyy-MM-dd}", new { @class = "form-control", @type = "date", @value = Model.Founded.ToString("yyyy-MM-dd") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.LabelFor(n => n.ClubLogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.TextBoxFor(a => a.ClubLogo, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("      <div style=\"padding:10px;\">\r\n");
#nullable restore
#line 31 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
         if (! Model.ClubLogo.Equals(""))
        {
            var Url = await fbsrv.GetCachedImageUrl(Model.ClubLogo);
            var t = Url;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1135, "\"", 1145, 1);
#nullable restore
#line 36 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
WriteAttributeValue("", 1141, Url, 1141, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"not displayed\" width=\"225\" height=\"225\"></img>\r\n");
#nullable restore
#line 37 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <h3>No Image Available</h3>\r\n");
#nullable restore
#line 41 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 44 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.LabelFor(n => n.StadiumId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.DropDownListFor(n => n.StadiumId, new SelectList(ViewBag.Stadiums, "StadiumId", "StadiumName"), "Select a home stadium", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 46 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"
   Write(Html.ValidationMessageFor(n => n.StadiumId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-default\">Save Changes</button>\r\n");
#nullable restore
#line 50 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Club\EditClub.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FBSContainerService fbsrv { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
