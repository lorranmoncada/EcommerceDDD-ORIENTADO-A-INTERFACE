#pragma checksum "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ba8b95f78c030b87587aac70998b95e7b70921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompraUsuario_FinalizarCompra), @"mvc.1.0.view", @"/Views/CompraUsuario/FinalizarCompra.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ba8b95f78c030b87587aac70998b95e7b70921", @"/Views/CompraUsuario/FinalizarCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3c5b64e7389c60428634605ecb068f86f4a080", @"/Views/_ViewImports.cshtml")]
    public class Views_CompraUsuario_FinalizarCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.CompraUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CompraUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmaCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
  
    ViewData["Title"] = "FinalizarCompra";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Dados da Compra</h4>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19ba8b95f78c030b87587aac70998b95e7b709214773", async() => {
                WriteLiteral("Confirmar a Compra");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.EnderecoCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.EnderecoCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            CEP\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.CEP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeProdutos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.QuantidadeProdutos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
       Write(Html.DisplayFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>

    </dl>

    <h4>Produtos comprados</h4>


    <table class=""table"">
        <thead>
            <tr>

                <th>
                    Nome
                </th>
                <th>Imagem</th>
                <th>
                    Descrição
                </th>
                <th>
                    Observação
                </th>
                <th>
                    Valor
                </th>

                <th>
                    Quantidade
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 72 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
             foreach (var item in Model.ListaProdutos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 81 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                          
                            if (!string.IsNullOrWhiteSpace(item.Url))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img width=\"80\" height=\"80\"");
            BeginWriteAttribute("src", " src=", 2163, "", 2177, 1);
#nullable restore
#line 84 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
WriteAttributeValue("", 2168, item.Url, 2168, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 85 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 100 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QtdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 104 "C:\Repositorio\EcommerceDDD\EcommerceDDD\WebEComerce\Views\CompraUsuario\FinalizarCompra.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.CompraUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
