<<<<<<< HEAD
#pragma checksum "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f38f300a44100383a5655538431fa7ad177a2c"
=======
#pragma checksum "C:\Users\10\Desktop\Nova pasta (2)\instadev\Views\login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f38f300a44100383a5655538431fa7ad177a2c"
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\10\Desktop\Nova pasta (2)\instadev\Views\_ViewImports.cshtml"
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
using instadev;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\10\Desktop\Nova pasta (2)\instadev\Views\_ViewImports.cshtml"
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
using instadev.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f38f300a44100383a5655538431fa7ad177a2c", @"/Views/Login/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f38f300a44100383a5655538431fa7ad177a2c", @"/Views/login/Index.cshtml")]
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4413358b500d6defee802470497f333991e188", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <main>\r\n        <div class=\"retangulo1\">\r\n            <div class=\"login\">\r\n\r\n                <div class=\"instadev\">\r\n                    <img src=\"img/Instadev.png\" alt=\"slogan\">\r\n                </div>\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28f38f300a44100383a5655538431fa7ad177a2c4208", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28f38f300a44100383a5655538431fa7ad177a2c4082", async() => {
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
                WriteLiteral(@"
                    <div class=""blocos"">
                        <input type=""text"" name=""Email"" placeholder=""Email ou Nome de Usuario"">
                        <input type=""text"" name=""Senha"" placeholder=""Senha"">
                    </div>
                    
                    <div class=""entrar"">
");
                WriteLiteral("                        <button type=\"submit\">Entrar</button>\r\n                    </div>  \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
<<<<<<< HEAD
#line 8 "C:\Users\User\Documents\Desenvolvimento web senai\Sprint 4 - Backend 2 - POO\instadev\Views\Login\Index.cshtml"
=======
#line 8 "C:\Users\10\Desktop\Nova pasta (2)\instadev\Views\login\Index.cshtml"
>>>>>>> 9c143fbb4b580d08631678b9fd292867746282ca
AddHtmlAttributeValue("", 252, Url.Action("Logar"), 252, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <div class=""OU""></div>
                    <a href=""#"">OU</a>
                </div>

                <div class=""esqueceuasenha"">
                    <a href=""#"">Esqueceu a Senha ?</a>
                </div>
            </div>
        </div> 
            <div class=""retangulo2""></div>    
                <div class=""Semconta"">
                    <a href=""#"">Não tem uma conta?Cadastre-se</a>
                </div>
            </div>
        
            <div class=""aplicativos"">
                <p>Obtenha o aplicativo.</p>
             </div>        
                
                    <div class=""app"">
                        <img src=""img/app_store 1.png"" alt=""App_store"">
                    </div>

                    <div class=""play"">
                        <img src=""img/google_play 1.png"" alt=""google_play"">
                    </div>
           


    </main>");
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
