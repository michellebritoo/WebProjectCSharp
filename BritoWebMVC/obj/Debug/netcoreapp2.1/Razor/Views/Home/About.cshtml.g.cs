#pragma checksum "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd4e904e34819f41c138e3adbdf096fcd7b108eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\_ViewImports.cshtml"
using BritoWebMVC;

#line default
#line hidden
#line 2 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\_ViewImports.cshtml"
using BritoWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4e904e34819f41c138e3adbdf096fcd7b108eb", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7a80f4d9da81752f2d8d9fdbd8dd7802fd3dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre esse projeto:";

#line default
#line hidden
            BeginContext(55, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(60, 17, false);
#line 4 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(77, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(89, 19, false);
#line 5 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 69, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n<p>");
            EndContext();
            BeginContext(178, 17, false);
#line 8 "C:\Users\Usuário\source\repos\BritoWebMVC\BritoWebMVC\Views\Home\About.cshtml"
Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(195, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
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