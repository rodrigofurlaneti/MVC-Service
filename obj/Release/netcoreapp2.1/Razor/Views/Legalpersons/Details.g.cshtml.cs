#pragma checksum "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ad1081adfa130bd2624a1f5d25ec50cbe9ad92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Legalpersons_Details), @"mvc.1.0.view", @"/Views/Legalpersons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Legalpersons/Details.cshtml", typeof(AspNetCore.Views_Legalpersons_Details))]
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
#line 1 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\_ViewImports.cshtml"
using MeuHelp;

#line default
#line hidden
#line 2 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\_ViewImports.cshtml"
using MeuHelp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ad1081adfa130bd2624a1f5d25ec50cbe9ad92", @"/Views/Legalpersons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a3caefff95eea7dae0cec472ca5fb1811632d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Legalpersons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeuHelp.Models.Legalperson>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
  
    ViewData["Title"] = "Detalhar pessoa jurídica";

#line default
#line hidden
            BeginContext(97, 148, true);
            WriteLiteral("<h2 class=\"display-4\">Detalhar pessoa jurídica</h2>\r\n<div>\r\n    <h4>Pessoa jurídica</h4>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 40, false);
#line 11 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 36, false);
#line 14 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(366, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(410, 39, false);
#line 17 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(493, 35, false);
#line 20 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(572, 46, false);
#line 23 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(662, 42, false);
#line 26 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(704, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(748, 42, false);
#line 29 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(790, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(834, 38, false);
#line 32 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(872, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(916, 47, false);
#line 35 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(963, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1007, 43, false);
#line 38 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1094, 42, false);
#line 41 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1180, 38, false);
#line 44 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1262, 42, false);
#line 47 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1348, 38, false);
#line 50 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1430, 42, false);
#line 53 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1516, 38, false);
#line 56 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1598, 40, false);
#line 59 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1682, 36, false);
#line 62 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1762, 41, false);
#line 65 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1847, 37, false);
#line 68 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Data de nascimento\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1989, 46, false);
#line 74 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2079, 38, false);
#line 77 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2161, 34, false);
#line 80 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2239, 39, false);
#line 83 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2322, 35, false);
#line 86 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2401, 43, false);
#line 89 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2488, 39, false);
#line 92 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2571, 41, false);
#line 95 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2656, 37, false);
#line 98 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Data de vencimento\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2798, 46, false);
#line 104 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataVencimento));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor do contrato\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2948, 45, false);
#line 110 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorContrato));

#line default
#line hidden
            EndContext();
            BeginContext(2993, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Inicio de vigencia\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3098, 46, false);
#line 116 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.InicioVigencia));

#line default
#line hidden
            EndContext();
            BeginContext(3144, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Fim da vigencia\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3246, 43, false);
#line 122 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.FimVigencia));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Tipo de serviço\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3391, 48, false);
#line 128 "C:\Users\Administrador\source\repos\MeuHelp\MeuHelp\Views\Legalpersons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Typeservice.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3439, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3486, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305b63780bb7418a96c3b818b51ddccb", async() => {
                BeginContext(3541, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3551, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeuHelp.Models.Legalperson> Html { get; private set; }
    }
}
#pragma warning restore 1591