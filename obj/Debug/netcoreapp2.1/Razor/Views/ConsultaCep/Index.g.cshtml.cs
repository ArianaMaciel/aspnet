#pragma checksum "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70152eb7202d9b958a39ad1248e48701057148e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConsultaCep_Index), @"mvc.1.0.view", @"/Views/ConsultaCep/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ConsultaCep/Index.cshtml", typeof(AspNetCore.Views_ConsultaCep_Index))]
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
#line 1 "C:\Users\Aluno\Downloads\WebService\WebService\Views\_ViewImports.cshtml"
using WebService;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Downloads\WebService\WebService\Views\_ViewImports.cshtml"
using WebService.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70152eb7202d9b958a39ad1248e48701057148e", @"/Views/ConsultaCep/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c0d9b2fe33cc0bd0bc644a89b87d6017668ad", @"/Views/_ViewImports.cshtml")]
    public class Views_ConsultaCep_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebService.Models.ConsultaCep>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultaCep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 62, true);
            WriteLiteral("\n<h2>Consultar e cadastrar CEP - Aline e Ariana</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(151, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbfd875b06294c28b16d80b579510e1f", async() => {
                BeginContext(179, 9, true);
                WriteLiteral("Consultar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(192, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(279, 39, false);
#line 16 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(318, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(371, 46, false);
#line 19 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(417, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(470, 47, false);
#line 22 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(517, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(570, 42, false);
#line 25 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(612, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(665, 46, false);
#line 28 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(711, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(764, 38, false);
#line 31 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(802, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 37 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(913, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(960, 38, false);
#line 40 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(998, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1051, 45, false);
#line 43 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1149, 46, false);
#line 46 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1248, 41, false);
#line 49 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1342, 45, false);
#line 52 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1440, 37, false);
#line 55 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uf));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 45, true);
            WriteLiteral("\n            </td>            \n        </tr>\n");
            EndContext();
#line 58 "C:\Users\Aluno\Downloads\WebService\WebService\Views\ConsultaCep\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1524, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebService.Models.ConsultaCep>> Html { get; private set; }
    }
}
#pragma warning restore 1591
