#pragma checksum "c:\Preparacion\NetCorePlatzi\Views\Asignatura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53669cee5692bf863b4bd8e4021d23fe3209ffc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_Index), @"mvc.1.0.view", @"/Views/Asignatura/Index.cshtml")]
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
#line 1 "c:\Preparacion\NetCorePlatzi\Views\_ViewImports.cshtml"
using NetCorePlatzi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Preparacion\NetCorePlatzi\Views\_ViewImports.cshtml"
using NetCorePlatzi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53669cee5692bf863b4bd8e4021d23fe3209ffc2", @"/Views/Asignatura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a819a30f0ae0ba09962528f97c174d9741a76d8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "c:\Preparacion\NetCorePlatzi\Views\Asignatura\Index.cshtml"
  
    ViewData["Title"] = "Información de Asignatura";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "c:\Preparacion\NetCorePlatzi\Views\Asignatura\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 8 "c:\Preparacion\NetCorePlatzi\Views\Asignatura\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h2>\r\n\r\n\r\n<p><i>");
#nullable restore
#line 11 "c:\Preparacion\NetCorePlatzi\Views\Asignatura\Index.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591
