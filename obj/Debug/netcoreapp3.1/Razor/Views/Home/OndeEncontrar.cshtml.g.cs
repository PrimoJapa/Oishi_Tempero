#pragma checksum "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Home\OndeEncontrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0b2ab35f8f0f8d6b8ec89b088dcc43d24f3b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OndeEncontrar), @"mvc.1.0.view", @"/Views/Home/OndeEncontrar.cshtml")]
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
#line 1 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Home\OndeEncontrar.cshtml"
using PI_SITE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0b2ab35f8f0f8d6b8ec89b088dcc43d24f3b16", @"/Views/Home/OndeEncontrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80125178a949781c73804ebe10e3e0862f3294a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OndeEncontrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner-onde.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hiroshi\Desktop\Tec.Informatica\Modulo B\PROJETO INTREGADOR ( PI )\PI_ETAPAS\ETAPA_06\Teste Caixa Branca\PI_SITE\Views\Home\OndeEncontrar.cshtml"
  
    ViewData["Title"] = "OndeEncontrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"banner-topo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bd0b2ab35f8f0f8d6b8ec89b088dcc43d24f3b164348", async() => {
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
            WriteLiteral(@"</div>

<p class=""titulo2 vermelho"">Quer saber onde tem produto Oishi perto de você? </p>
<div class=""container"">
    <div class=""text-description text-lg-center text-center"">
        <strong><b>Confira no mapa a localização de nossa loja, terminais de 
            distribuição e escritórios.&nbsp;Use o filtro para selecionar o que gostaria 
            de ver no mapa e clique na localização indicada para saber como chegar até lá.</b>
        </strong>
    </div><br>
    
    <div class=""mapaa"">
    <div class=""mapa""><iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.328661911507!2d-47.33128268488844!3d-22.75318113812855!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c8998174c896b9%3A0x739b7f99b3323574!2sSenac%20Americana!5e0!3m2!1spt-BR!2sbr!4v1639139300075!5m2!1spt-BR!2sbr"" width=""800"" height=""600"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1019, "\"", 1037, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe></div>\r\n    </div>\r\n</div>");
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
