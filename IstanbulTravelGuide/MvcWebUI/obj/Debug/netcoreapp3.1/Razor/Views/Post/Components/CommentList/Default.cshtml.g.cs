#pragma checksum "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747a00469e15c59832844fe176cd2a8f38787507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Post/Components/CommentList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747a00469e15c59832844fe176cd2a8f38787507", @"/Views/Post/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90fbe64bce36a3ccac09ea850cf7cd992ce84ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
 foreach (var comment in Model.Comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"be-img-comment\">\r\n        <a href=\"blog-detail-2.html\">\r\n            <img src=\"https://png.pngtree.com/png-vector/20191021/ourlarge/pngtree-user-vector-icon-with-transparent-background-png-image_1836030.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 304, "\"", 310, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"be-ava-comment\">\r\n        </a>\r\n    </div>\r\n    <div class=\"be-comment-content\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        <span class=\"be-comment-name\">\r\n            <a href=\"blog-detail-2.html\">");
#nullable restore
#line 23 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
                                    Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </span>\r\n        <span class=\"be-comment-time\">\r\n            <i class=\"fa fa-clock-o\"></i>\r\n            ");
#nullable restore
#line 27 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - \r\n            ");
#nullable restore
#line 28 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
       Write(comment.Date.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <p class=\"be-comment-text\">\r\n            ");
#nullable restore
#line 31 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
       Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </p>\r\n   \r\n\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\hmkrs\source\repos\IstanbulTravelGuide\MvcWebUI\Views\Post\Components\CommentList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
