#pragma checksum "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb8155cf4868f4bcf769b6462b7557f2d791a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
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
#line 1 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\_ViewImports.cshtml"
using WebEComerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\_ViewImports.cshtml"
using WebEComerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb8155cf4868f4bcf769b6462b7557f2d791a6d", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3c5b64e7389c60428634605ecb068f86f4a080", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Entities.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>Usuários do Sistema</h4>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\Usuario\ListarUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Entities.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
