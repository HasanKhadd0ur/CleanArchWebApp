#pragma checksum "C:\Users\HASAN\Desktop\cleanArchWebApp\cleanArchWebApp.WebPresentation\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b35d95a68ee2db74fac386fd49dfe00780400a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 2 "C:\Users\HASAN\Desktop\cleanArchWebApp\cleanArchWebApp.WebPresentation\Views\_ViewImports.cshtml"
using cleanArchWebApp.WebPresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HASAN\Desktop\cleanArchWebApp\cleanArchWebApp.WebPresentation\Views\_ViewImports.cshtml"
using cleanArchWebApp.ApplicationCore.Enities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HASAN\Desktop\cleanArchWebApp\cleanArchWebApp.WebPresentation\Views\_ViewImports.cshtml"
using cleanArchWebApp.WebPresentation.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b35d95a68ee2db74fac386fd49dfe00780400a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6fdc2db947cf408a6ba5532c832e6ffcc536ad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\HASAN\Desktop\cleanArchWebApp\cleanArchWebApp.WebPresentation\Views\Home\About.cshtml"
  
    ViewData["title"] = "about";
    ViewData["userName"] = "Hasan";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- About Section -->
<section class=""page-section bg-primary text-white mb-0 "" id=""about"">
    <div class=""container"">

        <!-- About Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-white pt-5"">About</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- About Section Content -->
        <div class=""row"">
            <div class=""col-lg-4 ml-auto"">
                <p class=""lead"">Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source files including HTML, CSS, and JavaScript as well as optional SASS stylesheets for easy customization.</p>
            </div>
            <div class=""col-lg-4 mr-auto"">
                <");
            WriteLiteral(@"p class=""lead"">You can create your own custom avatar for the masthead, change the icon in the dividers, and add your email address to the contact form to make it fully functional!</p>
            </div>
        </div>

        <!-- About Section Button -->
        <div class=""text-center mt-4"">
            <a class=""btn btn-xl btn-outline-light"" href=""https://startbootstrap.com/themes/freelancer/"">
                <i class=""fas fa-download mr-2""></i>
                Free Download!
            </a>
        </div>

    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591