#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6884af0d385d78419c9947cd7d93f5466c54d175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeBlogs_HomeBlogs), @"mvc.1.0.view", @"/Views/Shared/Components/HomeBlogs/HomeBlogs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6884af0d385d78419c9947cd7d93f5466c54d175", @"/Views/Shared/Components/HomeBlogs/HomeBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HomeBlogs_HomeBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogListViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n    <div class=\"blog-grid-top\">\r\n        <div class=\"b-grid-top\">\r\n            <div class=\"blog_info_left_grid\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 235, "\"", 276, 2);
            WriteAttributeValue("", 242, "/Blog/BlogReadAll/", 242, 18, true);
#nullable restore
#line 7 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 260, Model[0].BlogID, 260, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 304, "\"", 338, 1);
#nullable restore
#line 8 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 310, Model[0].BlogThumbnailImage, 310, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""blog-img"">
                </a>
            </div>
            <div class=""blog-info-middle"">
                <ul>
                    <li>
                        <a href=""#"">
                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 15 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                           Write(Model[0].BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"mx-2\">\r\n                        <a href=\"#\">\r\n                            <i class=\"far fa-thumbs-up\"></i> ");
#nullable restore
#line 20 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                        Write(Model[0].BlogRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Likes\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"far fa-comment\"></i> ");
#nullable restore
#line 25 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                      Write(Model[0].CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments\r\n                        </a>\r\n                    </li>\r\n\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <h3>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1226, "\"", 1267, 2);
            WriteAttributeValue("", 1233, "/Blog/BlogReadAll/", 1233, 18, true);
#nullable restore
#line 34 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 1251, Model[0].BlogID, 1251, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Amet consectetur adipisicing </a>\r\n        </h3>\r\n        <p>\r\n");
#nullable restore
#line 37 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
             if (Model[0].BlogContent.Length > 150)
            { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
         Write(Model[0].BlogContent.Substring(0, 150));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>...</span> ");
#nullable restore
#line 38 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                                       }
            else
            { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
         Write(Model[0].BlogContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1540, "\"", 1581, 2);
            WriteAttributeValue("", 1547, "/Blog/BlogReadAll/", 1547, 18, true);
#nullable restore
#line 42 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 1565, Model[0].BlogID, 1565, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n    </div>\r\n\r\n    <div class=\"blog-girds-sec\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 47 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
             for (int i = 1; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 blog-grid-top\">\r\n                    <div class=\"b-grid-top\">\r\n                        <div class=\"blog_info_left_grid\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 2001, 2);
            WriteAttributeValue("", 1967, "/Blog/BlogReadAll/", 1967, 18, true);
#nullable restore
#line 52 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 1985, Model[i].BlogID, 1985, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2041, "\"", 2075, 1);
#nullable restore
#line 53 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 2047, Model[i].BlogThumbnailImage, 2047, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                            </a>\r\n                        </div>\r\n                        <h3>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2223, "\"", 2264, 2);
            WriteAttributeValue("", 2230, "/Blog/BlogReadAll/", 2230, 18, true);
#nullable restore
#line 57 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
WriteAttributeValue("", 2248, Model[i].BlogID, 2248, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Amet consectetur </a>\r\n                        </h3>\r\n                        <p>\r\n");
#nullable restore
#line 60 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                             if (Model[i].BlogContent.Length > 50)
                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                        Write(Model[i].BlogContent.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>...</span> ");
#nullable restore
#line 61 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                                                     }
                            else
                            { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                         Write(Model[i].BlogContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n                    </div>\r\n                    <ul class=\"blog-icons\">\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 69 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                        Write(Model[i].BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"mx-2\">\r\n                            <a href=\"#\">\r\n                                <i class=\"far fa-comment\"></i> ");
#nullable restore
#line 74 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                          Write(Model[i].CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                <i class=\"far fa-thumbs-up\"></i> ");
#nullable restore
#line 79 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
                                                            Write(Model[i].BlogRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 84 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\HomeBlogs\HomeBlogs.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591