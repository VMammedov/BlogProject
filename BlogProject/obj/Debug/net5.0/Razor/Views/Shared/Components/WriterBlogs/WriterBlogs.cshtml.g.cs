#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b94811ea084601f0a1984658cc8ea69687db95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterBlogs_WriterBlogs), @"mvc.1.0.view", @"/Views/Shared/Components/WriterBlogs/WriterBlogs.cshtml")]
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
#line 1 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b94811ea084601f0a1984658cc8ea69687db95", @"/Views/Shared/Components/WriterBlogs/WriterBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterBlogs_WriterBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
  
    ViewData["Title"] = "WriterBlogs";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .blog-small-img {
        width: 50px;
        height: 50px;
        border-radius: 50%;
        border: 1px solid #01cd74;
    }
    .read-m{
        color:#fff !important;
    }
    .read-m:hover {
        color: #000 !important;
    }
</style>

<div class=""p-3"">
    <div class=""table-bg mt-4"">
        <div class=""card-header-custom"">
            <h3>Recent Blogs</h3>
            <a href=""/Blog/BlogAdd"" class=""btn btn-primary read-m"">New Blog <span class=""fas fa-arrow-right""></span></a>
        </div>
        <div class=""card-body mt-2"">
            <div class=""table-responsive"">
                <table class=""table-custom"" style=""width: 100%;"">
                    <thead class=""thead-custom"">
                        <tr>
                            <td>Image</td>
                            <td>Title</td>
                            <td>Category</td>
                            <td>Date</td>
                            <td>Status</td>
                            ");
            WriteLiteral("<td>Operations</td>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody class=\"tbody-custom\">\r\n");
#nullable restore
#line 43 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                         foreach (Blog item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img class=\"blog-small-img\"");
            BeginWriteAttribute("src", " src=\"", 1423, "\"", 1444, 1);
#nullable restore
#line 46 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
WriteAttributeValue("", 1429, item.BlogImage, 1429, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td><a href=\"#\" style=\"color: #00b868\">");
#nullable restore
#line 47 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                                                                  Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                               Write(item.BlogCreateDate.ToString("ddd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 51 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                                     if (item.BlogStatus)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status green\"></span>\r\n                                        <span>Active</span>\r\n");
#nullable restore
#line 55 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status red\"></span>\r\n                                        <span>DeActive</span>\r\n");
#nullable restore
#line 60 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>
                                <td class=""d-flex justify-content-between"">
                                    <a class=""btn btn-secondary"" href=""#""><i class=""fas fa-eye""></i></a>
                                    <a class=""btn btn-warning""");
            BeginWriteAttribute("href", " href=\"", 2562, "\"", 2596, 2);
            WriteAttributeValue("", 2569, "/Blog/BlogEdit/", 2569, 15, true);
#nullable restore
#line 64 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
WriteAttributeValue("", 2584, item.BlogID, 2584, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2692, "\"", 2728, 2);
            WriteAttributeValue("", 2699, "/Blog/BlogDelete/", 2699, 17, true);
#nullable restore
#line 65 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
WriteAttributeValue("", 2716, item.BlogID, 2716, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterBlogs\WriterBlogs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591