#pragma checksum "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d1cd686e1770fa319effcbe1147e3a631ff7ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(portalManutencao.WebApp.Pages.Pages_VerAgendamento), @"mvc.1.0.razor-page", @"/Pages/VerAgendamento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/VerAgendamento.cshtml", typeof(portalManutencao.WebApp.Pages.Pages_VerAgendamento), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d1cd686e1770fa319effcbe1147e3a631ff7ba7", @"/Pages/VerAgendamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb8fe852a6269a1156fb67691095a7eac486a07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VerAgendamento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CadAgendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 11, true);
            WriteLiteral("    <label>");
            EndContext();
            BeginContext(81, 20, false);
#line 4 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
      Write(Model.WelcomeMessage);

#line default
#line hidden
            EndContext();
            BeginContext(101, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(114, 34, true);
            WriteLiteral("\r\n<h2>Agendamentos</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(148, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d1cd686e1770fa319effcbe1147e3a631ff7ba74223", async() => {
                BeginContext(177, 10, true);
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
            BeginContext(191, 91, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(283, 65, false);
#line 15 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayNameFor(model => model.agendamentoLista[0].ClienteId));

#line default
#line hidden
            EndContext();
            BeginContext(348, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(404, 64, false);
#line 18 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayNameFor(model => model.agendamentoLista[0].DtInicio));

#line default
#line hidden
            EndContext();
            BeginContext(468, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(524, 63, false);
#line 21 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayNameFor(model => model.agendamentoLista[0].DtFinal));

#line default
#line hidden
            EndContext();
            BeginContext(587, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
         foreach (var item in Model.agendamentoLista)
        {

#line default
#line hidden
            BeginContext(716, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(765, 44, false);
#line 30 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClienteId));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 43, false);
#line 33 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayFor(modelItem => item.DtInicio));

#line default
#line hidden
            EndContext();
            BeginContext(908, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(964, 42, false);
#line 36 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.DisplayFor(modelItem => item.DtFinal));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1061, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d1cd686e1770fa319effcbe1147e3a631ff7ba78637", async() => {
                BeginContext(1106, 7, true);
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
#line 39 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
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
            BeginContext(1117, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1138, 79, false);
#line 40 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "VerSegmento", new { Id = @item.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\sergf\Desktop\teste2\portalManutencao.WebApp\Pages\VerAgendamento.cshtml"
        }

#line default
#line hidden
            BeginContext(1264, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<portalManutencao.WebApp.Pages.VerAgendamentoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<portalManutencao.WebApp.Pages.VerAgendamentoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<portalManutencao.WebApp.Pages.VerAgendamentoModel>)PageContext?.ViewData;
        public portalManutencao.WebApp.Pages.VerAgendamentoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
