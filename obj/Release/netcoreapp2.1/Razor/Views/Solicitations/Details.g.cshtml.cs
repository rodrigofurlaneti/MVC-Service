#pragma checksum "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7beee94046ffd39ea42acd14512dcbe52e705943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solicitations_Details), @"mvc.1.0.view", @"/Views/Solicitations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Solicitations/Details.cshtml", typeof(AspNetCore.Views_Solicitations_Details))]
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
#line 1 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\_ViewImports.cshtml"
using MeuHelp;

#line default
#line hidden
#line 2 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\_ViewImports.cshtml"
using MeuHelp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7beee94046ffd39ea42acd14512dcbe52e705943", @"/Views/Solicitations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a3caefff95eea7dae0cec472ca5fb1811632d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Solicitations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeuHelp.Models.ViewModels.SolicitationFormViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(103, 122, true);
            WriteLiteral("<h2>Detalhes</h2>\r\n<div>\r\n    <h4>Solicitação</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(226, 53, false);
#line 11 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 49, false);
#line 14 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(372, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(416, 60, false);
#line 17 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitation.Dateofbirth));

#line default
#line hidden
            EndContext();
            BeginContext(476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(520, 56, false);
#line 20 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitation.Dateofbirth));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 52, false);
#line 23 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitation.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(716, 48, false);
#line 26 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitation.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(764, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(808, 56, false);
#line 29 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitation.Andress));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(908, 52, false);
#line 32 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitation.Andress));

#line default
#line hidden
            EndContext();
            BeginContext(960, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1004, 62, false);
#line 35 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitation.TypeserviceId));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1110, 58, false);
#line 38 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitation.TypeserviceId));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1215, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f9736a9c4e4d26b8fe0174963305f1", async() => {
                BeginContext(1274, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Administrador\Desktop\MeuVale\MeuHelp\MeuHelp\Views\Solicitations\Details.cshtml"
                           WriteLiteral(Model.Solicitation.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1284, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1292, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa2eb58fb76c4acd98a422dc8d44051c", async() => {
                BeginContext(1314, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1324, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeuHelp.Models.ViewModels.SolicitationFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
