#pragma checksum "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7178ec260fd08388aab59b2b2bad3b1fd84cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Persona.Pages_Persona_list), @"mvc.1.0.razor-page", @"/Pages/Persona/list.cshtml")]
namespace FrontEnd.Pages.Persona
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
#line 1 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7178ec260fd08388aab59b2b2bad3b1fd84cb7", @"/Pages/Persona/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Hola, esto va bien</h1>\r\n\r\n\r\n<table>\r\n  <tr>\r\n    <th>ID</th>\r\n    <th>NOMBRE</th>\r\n    <th>CORREO</th>\r\n    <th>DOCUMENTO ID</th>\r\n  </tr>\r\n");
#nullable restore
#line 15 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
   foreach(var persona in Model.Personas){ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 17 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
       Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
       Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
       Write(persona.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
       Write(persona.DocumentoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 22 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\list.cshtml"
   
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listModel>)PageContext?.ViewData;
        public MyApp.Namespace.listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
