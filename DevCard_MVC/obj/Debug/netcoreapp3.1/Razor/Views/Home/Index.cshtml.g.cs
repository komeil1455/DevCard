#pragma checksum "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d02c7ae35bfe262d40ba4d600822a219601ce4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d02c7ae35bfe262d40ba4d600822a219601ce4a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""about-me-section p-3 p-lg-5 theme-bg-light"">
    <div class=""container"">
        <div class=""profile-teaser media flex-column flex-lg-row"">
            <img class=""profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0"" src=""assets/images/me.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 306, "\"", 312, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h2 class=""name font-weight-bold mb-1"">کمیل اسدی</h2>
                <div class=""tagline mb-3"">برنامه نویس ارشد</div>
                <div class=""bio mb-4"">
                    لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از
                    طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و
                    جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</a>.
                </div>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mr-2 mb-3"" href=""http://www.atriya.com"">
                        <i class=""fas fa-arrow-alt-circle-right ml-2""></i><span class=""d-none d-md-inline"">
                            برو
                            به
                        </span> آتریا
                    </a>
                    <a class=""btn btn-secondary mb-3"" href=""#"">
                        <i class=""fas fa-file-al");
            WriteLiteral("t ml-2\"></i>\r\n                        <span class=\"d-none d-md-inline\">مشاهده </span> نمونه کارها\r\n                    </a>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 43 "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync(name:"Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <hr>\r\n</div>\r\n\r\n");
#nullable restore
#line 51 "G:\MyMVCProjects\DevCard\DevCard_MVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync(name: "LatestArticles"));

#line default
#line hidden
#nullable disable
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
