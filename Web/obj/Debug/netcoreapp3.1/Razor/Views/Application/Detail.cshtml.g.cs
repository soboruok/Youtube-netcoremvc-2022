#pragma checksum "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c94a3883002c56add7d17c2c759f400fc1d0821f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_Detail), @"mvc.1.0.view", @"/Views/Application/Detail.cshtml")]
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
#line 1 "C:\설명\netcore\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\설명\netcore\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\설명\netcore\Web\Web\Views\_ViewImports.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94a3883002c56add7d17c2c759f400fc1d0821f", @"/Views/Application/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bd1af9b050cd499e109c2d2364a393bd7593cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("<section class=\"mainAbout my-5\">\r\n    <div class=\"container\">\r\n        <table class=\"table\">\r\n            <tr><th>이름 : ");
#nullable restore
#line 4 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
                    Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n            <tr> <th>연락처 : ");
#nullable restore
#line 5 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
                      Write(Model.UserPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n            <tr><th>지원분야 : ");
#nullable restore
#line 6 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
                      Write(Model.UserCareer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n            <tr> <th>주소 : ");
#nullable restore
#line 7 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
                     Write(Model.Useraddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n            <tr><th>CV : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c94a3883002c56add7d17c2c759f400fc1d0821f4303", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 348, "~/upload/", 348, 9, true);
#nullable restore
#line 8 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
AddHtmlAttributeValue("", 357, Model.UserCV, 357, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th></tr>\r\n            <tr><th>지원날짜 : ");
#nullable restore
#line 9 "C:\설명\netcore\Web\Web\Views\Application\Detail.cshtml"
                      Write(Model.Regdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th></tr>\r\n        </table>\r\n    </div>\r\n</section>");
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