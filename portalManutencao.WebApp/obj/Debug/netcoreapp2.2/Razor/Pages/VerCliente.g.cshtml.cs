#pragma checksum "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698a7bf0923c80168f0c9ce7c61953042210be77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(portalManutencao.WebApp.Pages.Pages_VerCliente), @"mvc.1.0.razor-page", @"/Pages/VerCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/VerCliente.cshtml", typeof(portalManutencao.WebApp.Pages.Pages_VerCliente), null)]
namespace portalManutencao.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\_ViewImports.cshtml"
using portalManutencao.WebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698a7bf0923c80168f0c9ce7c61953042210be77", @"/Pages/VerCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb8fe852a6269a1156fb67691095a7eac486a07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VerCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CadCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 11, true);
            WriteLiteral("    <label>");
            EndContext();
            BeginContext(77, 20, false);
#line 4 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
      Write(Model.WelcomeMessage);

#line default
#line hidden
            EndContext();
            BeginContext(97, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(110, 32, true);
            WriteLiteral("\r\n\r\n<h2>Clientes</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "698a7bf0923c80168f0c9ce7c61953042210be774186", async() => {
                BeginContext(167, 10, true);
                WriteLiteral("Criar Novo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 91, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(273, 69, false);
#line 16 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.clienteLista[0].PessoaFisica.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 68, false);
#line 19 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.clienteLista[0].PessoaFisica.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 63, false);
#line 22 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.clienteLista[0].Cidade.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(585, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(641, 68, false);
#line 25 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.clienteLista[0].Cidade.Estado.UF));

#line default
#line hidden
            EndContext();
            BeginContext(709, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
         foreach (var item in Model.clienteLista)
        {

#line default
#line hidden
            BeginContext(859, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(920, 52, false);
#line 36 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.PessoaFisica.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(972, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1040, 51, false);
#line 39 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.PessoaFisica.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1159, 55, false);
#line 42 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco.Cidade.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1282, 60, false);
#line 45 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco.Cidade.Estado.UF));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1409, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "698a7bf0923c80168f0c9ce7c61953042210be779589", async() => {
                BeginContext(1454, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
                                           WriteLiteral(item.Id);

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
            BeginContext(1465, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1490, 78, false);
#line 49 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "VerCliente", new { Id = @item.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerCliente.cshtml"
        }

#line default
#line hidden
            BeginContext(1623, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<portalManutencao.WebApp.Pages.VerClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<portalManutencao.WebApp.Pages.VerClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<portalManutencao.WebApp.Pages.VerClienteModel>)PageContext?.ViewData;
        public portalManutencao.WebApp.Pages.VerClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
