#pragma checksum "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "784b66f0fe0e043862b8110250dfd31b7b3d8c41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_A_Case_Against_The_NHS), @"mvc.1.0.view", @"/Views/Articles/A_Case_Against_The_NHS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articles/A_Case_Against_The_NHS.cshtml", typeof(AspNetCore.Views_Articles_A_Case_Against_The_NHS))]
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
#line 1 "C:\Users\Matt\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "C:\Users\Matt\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784b66f0fe0e043862b8110250dfd31b7b3d8c41", @"/Views/Articles/A_Case_Against_The_NHS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_A_Case_Against_The_NHS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.ViewModel.ModelsCombined>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Articles/_Comment.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(82, 943, true);
            WriteLiteral(@"
<div>
    <div class=""text-center"">
        <h1 class=""display-4"">A Case Against The NHS</h1>
    </div>

    <h5>James Steel</h5>
    <span>20/11/2016</span>
    <br />
    <br /> 
        My case against the NHS is as follows. One of the problems witht the NHS is that the employees do not have authentic motivation
        This is unfortunately a natural consequence of the goverment taking the reigns - If it was free-market, the staff would answer to actual
        profits which they could see acrew. There is a crude nature, when employees no longer work hard to ensure a business stays afloat, or for
        any bonuses, because there is no profit in the NHS, the employees need other incentives to work hard and actually do the job. These
        include regular inspections. And targets determined by bureaucrats who know nothing about the plight of working in a hospital.
    <hr />
</div>

<h4>Comments</h4>

");
            EndContext();
#line 27 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
 foreach (var Item in Model.IEnumerableComment)
{
    if (Item.ArticleTitle == "A Case Against The NHS")
    {

#line default
#line hidden
            BeginContext(1140, 63, true);
            WriteLiteral("        <div class=\"comment-list\">\r\n            <label><strong>");
            EndContext();
            BeginContext(1204, 9, false);
#line 32 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
                      Write(Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 34, true);
            WriteLiteral("</strong></label>\r\n            <p>");
            EndContext();
            BeginContext(1248, 9, false);
#line 33 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
          Write(Item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 42, true);
            WriteLiteral("</p>\r\n            <br />\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
    }
}

#line default
#line hidden
            BeginContext(1309, 12, true);
            WriteLiteral("\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(1321, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "784b66f0fe0e043862b8110250dfd31b7b3d8c416218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1394, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\Matt\source\repos\Blog\Blog\Views\Articles\A_Case_Against_The_NHS.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.ViewModel.ModelsCombined> Html { get; private set; }
    }
}
#pragma warning restore 1591
