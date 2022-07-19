#pragma checksum "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f60ec45b831df5cd96ed51f02d34dbb300490b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stadium_AllStadiums), @"mvc.1.0.view", @"/Views/Stadium/AllStadiums.cshtml")]
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
#line 1 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f60ec45b831df5cd96ed51f02d34dbb300490b", @"/Views/Stadium/AllStadiums.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b8838afb612badaa7953bf5b4f2497815f61b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stadium_AllStadiums : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StadiumViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
  
    ViewData["Title"] = "Stadium";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
Write(ViewData["StadiumMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 10 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
Write(Html.ActionLink("Create Stadium", "CreateStadium", "Stadium"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-info text-center\">\r\n        <h1>There are no Stadiums available.</h1>\r\n    </div>\r\n");
#nullable restore
#line 16 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped\">\r\n    <thead>\r\n    <th>Stadium Name</th>\r\n    <th>Club</th>\r\n    <th>Location</th>\r\n    <th>Date Built</th>\r\n");
#nullable restore
#line 25 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <th>Edit</th>\r\n    <th>Delete</th>\r\n    <th>Details</th>");
#nullable restore
#line 29 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
         foreach (StadiumViewModel svm in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 36 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
   Write(svm.StadiumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 37 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
   Write(svm.ClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 38 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
   Write(svm.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 39 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
   Write(svm.BuildDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>");
#nullable restore
#line 42 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
Write(Html.ActionLink("Edit", "EditStadium", "Stadium", new { @id = svm.StadiumId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>");
#nullable restore
#line 43 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
Write(Html.ActionLink("Delete", "DeleteStadium", "Stadium", new { @id = svm.StadiumId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>");
#nullable restore
#line 44 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
Write(Html.ActionLink("Details", "StadiumDetails", "Stadium", new { @id = svm.StadiumId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
#nullable restore
#line 44 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>");
#nullable restore
#line 45 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 48 "Z:\Projects (Local)\ASP.NET_CORE_MVC\FootballStarz\I007\Views\Stadium\AllStadiums.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StadiumViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
