#pragma checksum "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2497ee48eda6f4ee29a97b7abd0c50ed0213c642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_perfil), @"mvc.1.0.view", @"/Views/Perfil/perfil.cshtml")]
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
#line 1 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\_ViewImports.cshtml"
using instadev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\_ViewImports.cshtml"
using instadev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2497ee48eda6f4ee29a97b7abd0c50ed0213c642", @"/Views/Perfil/perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4413358b500d6defee802470497f333991e188", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylePerfil.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pesquisa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Post img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2497ee48eda6f4ee29a97b7abd0c50ed0213c6425110", async() => {
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
            WriteLiteral("\r\n        <header class=\"header\">\r\n            <div class=\"menu\">\r\n                <ul>\r\n                    <a href=\"#\"><img src=\"img/Instadev.png\" alt=\"Logo\"></a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2497ee48eda6f4ee29a97b7abd0c50ed0213c6426426", async() => {
                WriteLiteral("\r\n                        <input type=\"search\" placeholder=\"             Pesquisar\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""botoes"">
                        <a href=""#""><img src=""img/Vector.png"" alt=""Home""></a>
                        <a href=""#""><img src=""img/plane 1.png"" alt=""Plane""></a>
                        <a href=""#""><img src=""img/compass 1.png"" alt=""Compass""></a>
                        <a href=""#""><img src=""img/Vector (1).png"" alt=""Heart""></a>
                        <a href=""#""><img src=""img/thank-you 1.png"" alt=""Perfil""></a>
                    </div>
                </ul>
            </div>
        </header>
        <!-- Fim do Header -->
        <nav class=""perfil"">
            <section class=""bloco-perfil"">
                <ul>
                    <img class=""imagem-perfil"" src=""img/thank-you 3PerfilGrande.png"" alt=""Imagem do Perfil"">   
                    <div class=""info"">
                        <div class=""topper"">
                            <h2>yes_baby</h2>
                            <a href=""#"">Editar Perfil</a>
                        </div>
          ");
            WriteLiteral(@"              <div class=""quantia"">
                            <p>0 publicações</p>
                            <p>128 seguindo</p>
                            <p>214 seguidores</p>
                        </div>
                        <div class=""hbotao"">
                            <h4>Marcos Jeeves</h4>
                            <a href=""#"">Sair</a>
                        </div>
                    </div>
                </ul> 
            </section>
        </nav>
        <!-- Fim do Perfil exibido -->
        <div class=""pubs"">
            <div class=""publicacao"">
                <img src=""img/image 1caixa.png"" alt=""Caixa Pub"">
                <h3>PUBLICAÇÕES</h3>
            </div>
        </div>
        <section class=""posts"">
            <section class=""area"">
");
#nullable restore
#line 54 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml"
                 foreach (var Publicacao in ViewBag.ListaPubs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"post-card\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2497ee48eda6f4ee29a97b7abd0c50ed0213c64210152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2412, "~/img/", 2412, 6, true);
#nullable restore
#line 57 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml"
AddHtmlAttributeValue("", 2418, Publicacao.Imagem, 2418, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""coment-part"">
                        <div class=""perfil-coment"">
                            <img src=""img/thank-you 4perfilMedio.png"" alt=""Perfil"">
                            <div class=""nom"">
                                <h3>Marcos Jeeves</h3>
                                <p>Rio de Janeiro, Brazil</p> 
                            </div>7
                        </div>
                        <div class=""icons-coment"">
                            <a href=""#""><img src=""img/Vector (1).png"" alt=""Heart""></a>
                            <a href=""#""><img src=""img/Vectorchat.png"" alt=""Chat""></a>
                        </div>
                        <div class=""curtida"">
                            <p> ");
#nullable restore
#line 71 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml"
                           Write(Publicacao.NumeroLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" curtidas</p>
                        </div>
                        <div class=""coments"">
                            <div class=""chat1"">
                                <h3>fausto_silva</h3>
                                <p>Esse cara é fera bixo!!!</p>
                                <a href=""#""><img src=""img/Vectorsmall heart.png"" alt=""Heart""></a>
                            </div>
                            <div class=""chat2"">
                                <h3>yes_baby</h3>
                                <p>thank you</p>
                                <a href=""#""><img src=""img/Vectorsmall heart.png"" alt=""Heart""></a>
                            </div>
                            <div class=""chat3"">
                                <h3>adriano_stark</h3>
                                <p>Quando eu adormecer, vou sonhar com você. <br> É sempre você. </p>
                                <a href=""#""><img src=""img/Vectorsmall heart.png"" alt=""Heart""></a>
                            </div>");
            WriteLiteral(@"
                            <div class=""chat4"">
                                <h3>yes_baby</h3>
                                <p>Yes baby!!</p>
                                <a href=""#""><img src=""img/Vectorsmall heart.png"" alt=""Heart""></a>
                            </div>
                            <div class=""mais-coments"">
                                <a href=""#"">Ver todos os 585 comentários</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""espaco""></div>
");
#nullable restore
#line 101 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Perfil\perfil.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </section>\r\n        </section>");
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
