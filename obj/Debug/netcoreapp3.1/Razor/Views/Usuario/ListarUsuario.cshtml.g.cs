#pragma checksum "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b34c14ab1c38230d1ffccefad146b5897e0d80a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuario), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuario.cshtml")]
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
#line 1 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\_ViewImports.cshtml"
using PI_SITE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
using PI_SITE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b34c14ab1c38230d1ffccefad146b5897e0d80a", @"/Views/Usuario/ListarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80125178a949781c73804ebe10e3e0862f3294a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner-usuarios.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarCadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
  
    ViewData["Title"] = "ListaUsuario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"homet\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b34c14ab1c38230d1ffccefad146b5897e0d80a6191", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div><br>  \r\n\r\n");
#nullable restore
#line 10 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
 if (Model.Count() != 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container text-center\"><h3 class=\"display-4\">Lista de Usários</h3></div>\r\n");
            WriteLiteral("<div class=\"btn2\"><p  class=\"container text-center\"><a href=\"/Usuario/CadastroUsuario\" class=\"btn btn-outline-dark\" >Cadastrar Novo Usario</a></p></div>\r\n");
            WriteLiteral(@"<table class=""table table-dark"" style=""width: 100%"">
    <thead>
        <tr class=""container text-center"">
            <strong>
                <th scope=""col"">Cod</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Data de Nascimento</th>
                <th scope=""col"">Contato</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Login</th>
                <th scope=""col"">Senha</th>
                <th scope=""col"">Conta</th>
                <th scope=""col"">Ação</th>
            </strong>
        </tr>
    </thead>

    <tbody>
        
");
#nullable restore
#line 36 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
         foreach (Usuario item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr  class=\"container text-center\">\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Id.ToString("D2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Contato.ToString("## ##### ####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                   Write(item.Conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <p>\r\n                             <div class=\"d-grid gap-2 d-md-flex justify-content-md-center\"> \r\n                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b34c14ab1c38230d1ffccefad146b5897e0d80a11948", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                                                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b34c14ab1c38230d1ffccefad146b5897e0d80a14577", async() => {
                WriteLiteral("Deletar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
                                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                             </div>\r\n                        </p>\r\n                    </td>\r\n                        \r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

    
    <tfoot>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tfoot>
</table>
");
#nullable restore
#line 75 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"


}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b><h2 class=\"container text-center\">Não existem Usuarios Cadastardos!</h2></b>\r\n    <div class=\"btn2\"><p  class=\"container text-center\"><a href=\"/Usuario/CadastroUsuario\" class=\"btn btn-outline-dark\" >Cadastrar Usario</a></p></div>\r\n");
#nullable restore
#line 80 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Usuario\ListarUsuario.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591