#pragma checksum "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dec28a7d11a0bcf7aeb85c4c4afd5df0f81aeaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
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
#line 1 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dec28a7d11a0bcf7aeb85c4c4afd5df0f81aeaf", @"/Views/Post/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90fbe64bce36a3ccac09ea850cf7cd992ce84ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<br/>\r\n\r\n<div class=\"row mb-2\">\r\n    \r\n");
#nullable restore
#line 17 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-6"">
        <div class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
            <div class=""col p-4 d-flex flex-column position-static"">
                <strong class=""d-inline-block mb-2 text-primary"">");
#nullable restore
#line 22 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
                                                            Write(post.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <h3 class=\"mb-0\"> ");
#nullable restore
#line 23 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
                             Write(post.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"mb-1 text-muted\"> ");
#nullable restore
#line 24 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
                                         Write(post.Date.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n                <p class=\"card-text mb-auto\">");
#nullable restore
#line 25 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
                                        Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dec28a7d11a0bcf7aeb85c4c4afd5df0f81aeaf5811", async() => {
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-link\">Continue reading</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
                                                                   WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-auto d-none d-lg-block\">\r\n                <img class=\"bd-placeholder-img img-fluid\" width=\"200\" height=\"250\" preserveAspectRatio=\"xMidYMid slice\" focusable=\"false\"");
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1211, 1);
#nullable restore
#line 32 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
WriteAttributeValue("", 1197, post.PhotoUrl, 1197, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Search.cshtml"
    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
