#pragma checksum "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ce1cc1bd7f8ce0aaa16341f65408de13074cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_EditStadium), @"mvc.1.0.view", @"/Views/Stadium/EditStadium.cshtml")]
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
#line 1 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
using FootballStarz.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
using FootballStarz.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ce1cc1bd7f8ce0aaa16341f65408de13074cea", @"/Views/Stadium/EditStadium.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stadium_EditStadium : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Stadium>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
  
    ViewData["Title"] = "EditStadium";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Stadium</h2>\r\n\r\n");
#nullable restore
#line 10 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
 using (Html.BeginForm("StadiumEdited", "Stadium", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
Write(Html.HiddenFor(n => n.StadiumId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.LabelFor(n => n.StadiumName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.TextBoxFor(n => n.StadiumName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.StadiumName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.LabelFor(n => n.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.TextBoxFor(e => e.Location, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.LabelFor(n => n.BuildDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.TextBoxFor(b => b.BuildDate, "{0:yyyy-MM-dd}", new { @class = "form-control", @type = "date", @value = Model.BuildDate.ToString("dd-MM-yyyy") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.BuildDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.LabelFor(n => n.StadiumImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.TextBoxFor(n => n.StadiumImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.StadiumImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div style=\"padding:10px;\">\r\n");
#nullable restore
#line 39 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
         if (! Model.StadiumImage.Equals("0"))
        {
             var Url = fbsrv.GetCachedImageUrl(Model.StadiumImage);
             var t = Url;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1613, "\"", 1623, 1);
#nullable restore
#line 44 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
WriteAttributeValue("", 1619, Url, 1619, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"not displayed\" width=\"337\" height=\"150\"></img>\r\n");
#nullable restore
#line 45 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <h3>No Image Available</h3>\r\n");
#nullable restore
#line 50 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n     <div class=\"form-group\">\r\n        ");
#nullable restore
#line 53 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.LabelFor(n => n.ClubId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 54 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.DropDownListFor(n => n.ClubId, new SelectList(ViewBag.Clubs, "ClubId", "ClubName"), "Played by club ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 55 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
   Write(Html.ValidationMessageFor(n => n.ClubId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-default\">Save All Changes</button>\r\n");
#nullable restore
#line 61 "X:\Fileserver\Projects (FS)\ASP.NET_CORE\Projects\FootballStarz\I007\Views\Stadium\EditStadium.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Stadium> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
