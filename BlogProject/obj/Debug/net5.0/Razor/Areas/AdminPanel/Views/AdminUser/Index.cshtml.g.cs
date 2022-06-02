#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcc07c178d5ca43540bb77eae1159b507d79b3e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_AdminUser_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/AdminUser/Index.cshtml")]
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
#line 1 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc07c178d5ca43540bb77eae1159b507d79b3e3", @"/Areas/AdminPanel/Views/AdminUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21bcee3e787f81b8a91016d44a0c4cffd45864c", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_AdminUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<UserAdminListViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pt-3"">
    <div class=""table-bg"">
        <div class=""card-header-custom"">
            <h3>Users</h3>
            <a href=""/AdminPanel/"" class=""btn custom-admin-button ml-auto mr-3""><i class=""fas fa-file-excel""></i> Export in Excel</a>
        </div>
        <div class=""card-body mt-2"">
            <div class=""table-responsive"">
                <table class=""table-custom"" style=""width: 100%;"">
                    <thead class=""thead-custom"">
                        <tr>
                            <td>#</td>
                            <td>Nick Name</td>
                            <td>Email address</td>
                            <td>Status</td>
                            <td>Operations</td>
                        </tr>
                    </thead>
                    <tbody class=""tbody-custom"">
");
#nullable restore
#line 27 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                         foreach(UserAdminListViewModel item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"my-table-data\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bcc07c178d5ca43540bb77eae1159b507d79b3e35860", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1202, "~/WriterImageFiles/", 1202, 19, true);
#nullable restore
#line 30 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
AddHtmlAttributeValue("", 1221, item.UserImage, 1221, 15, false);

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
            WriteLiteral("</td>\r\n                                <td class=\"my-table-data\">");
#nullable restore
#line 31 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                                                     Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><i class=\'bx bx-envelope\'></i> ");
#nullable restore
#line 32 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                                                              Write(item.UserMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("id", " id=\"", 1449, "\"", 1477, 2);
            WriteAttributeValue("", 1454, "table-data-", 1454, 11, true);
#nullable restore
#line 33 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 1465, item.UserID, 1465, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                                     if (item.UserStatus)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status green\"></span><span> Active</span>\r\n");
#nullable restore
#line 37 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"status red\"></span>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1911, "\"", 1947, 3);
            WriteAttributeValue("", 1921, "activateUser(", 1921, 13, true);
#nullable restore
#line 41 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 1934, item.UserID, 1934, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1946, ")", 1946, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Activate</a>\r\n");
#nullable restore
#line 42 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td class=\"d-flex justify-content-between\">\r\n                                    <button class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2214, "\"", 2249, 3);
            WriteAttributeValue("", 2224, "UserDetails(", 2224, 12, true);
#nullable restore
#line 45 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 2236, item.UserID, 2236, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2248, ")", 2248, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></button>\r\n                                    <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2347, "\"", 2397, 2);
            WriteAttributeValue("", 2354, "/AdminPanel/AdminUser/UserEdit/", 2354, 31, true);
#nullable restore
#line 46 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 2385, item.UserID, 2385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2489, "\"", 2520, 3);
            WriteAttributeValue("", 2499, "delUser(", 2499, 8, true);
#nullable restore
#line 47 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 2507, item.UserID, 2507, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2519, ")", 2519, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">\r\n                                        <i class=\"fas fa-trash\"></i>\r\n                                    </button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Areas\AdminPanel\Views\AdminUser\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", "AdminUser", new { page }), new PagedListRenderOptions
{
    PageClasses = new string[] { "page-link bg-dark text-light border-dark" },
    LiElementClasses = new string[] { "page-item" },
    DisplayLinkToLastPage = PagedListDisplayMode.Always,
    DisplayLinkToFirstPage = PagedListDisplayMode.Always,
    ContainerDivClasses = new string[] { "p-1 pt-3" },
    ActiveLiElementClass = "active-page"
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function delUser(user_id) {
            const swalWithBootstrapButtons = Swal.mixin({
                customClass: {
                    confirmButton: 'btn btn-success',
                    cancelButton: 'btn btn-danger mr-3'
                },
                buttonsStyling: false
            })

            swalWithBootstrapButtons.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this User!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Yes, delete it!',
                cancelButtonText: 'No, cancel!',
                reverseButtons: true
            }).then((result) => {
                if (result.isConfirmed) {
                    let timerInterval
                    Swal.fire({
                        title: 'Deleting...!',
                        html: 'I will delete in <b></b> milliseconds.',
                        timer: 1000,
             ");
                WriteLiteral(@"           timerProgressBar: true,
                        didOpen: () => {
                            $.ajax({
                                type: 'POST',
                                url: '/AdminPanel/AdminUser/DeleteUser/',
                                data: { id: user_id }
                            });
                            Swal.showLoading()
                            const b = Swal.getHtmlContainer().querySelector('b')
                            timerInterval = setInterval(() => {
                                b.textContent = Swal.getTimerLeft()
                            }, 100)
                        },
                        willClose: () => {
                            clearInterval(timerInterval)
                        }
                    }).then((result) => {
                        Swal.fire({
                            icon: 'success',
                            title: 'Deleted!',
                            text: 'This User has been deleted succ");
                WriteLiteral(@"essfully!'
                        });
                        document.getElementById(""table-data-"" + user_id).innerHTML = `<span class=""status red""></span>
                                            <a onclick=""activateUser(${user_id})"" class=""btn btn-outline-success"">Activate</a>`;
                    });
                } else if (
                    result.dismiss === Swal.DismissReason.cancel
                ) {
                    swalWithBootstrapButtons.fire(
                        'Cancelled',
                        'User is safe :)',
                        'error'
                    )
                }
            })
        }

        function activateUser(user_id) {
            let timerInterval
            Swal.fire({
                title: 'Activating...!',
                html: 'I will activate in <b></b> milliseconds.',
                timer: 1000,
                timerProgressBar: true,
                didOpen: () => {
                    $.ajax({
            ");
                WriteLiteral(@"            type: 'POST',
                        url: '/AdminPanel/AdminUser/ActivateUser/',
                        data: { id: user_id }
                    });
                    Swal.showLoading()
                    const b = Swal.getHtmlContainer().querySelector('b')
                    timerInterval = setInterval(() => {
                        b.textContent = Swal.getTimerLeft()
                    }, 100)
                },
                willClose: () => {
                    clearInterval(timerInterval)
                }
            }).then((result) => {
                Swal.fire({
                    icon: 'success',
                    title: 'Activated!',
                    text: 'User has been activated successfully!'
                });
                document.getElementById(""table-data-"" + user_id).innerHTML = `<span class=""status green""></span><span> Active</span>`;
            });
        }

        function UserDetails(user_id) {
            $(function () {
  ");
                WriteLiteral(@"              $.ajax({
                    contentType: 'application/json',
                    dataType: 'json',
                    type: 'GET',
                    url: '/AdminPanel/AdminUser/UserDetails/',
                    data: { id: user_id },
                    success: function (myvalue) {
                        let data = jQuery.parseJSON(myvalue);
                        Swal.fire({
                            title: `<div class=""text-center""><img class=""detail-img"" src=""/WriterImageFiles/${data.UserImage}"" /></div><hr /><span>Details of </span><strong class=""text-info"">${data.UserName}</strong>`,
                            html:
                                `<h4><b>${data.UserFirstName} ${data.UserLastName}</b></h4>
                                    <h5><i class='bx bx-envelope'></i> <span class=""text-info"">${data.UserMail}</span></h5>
                                    <h4> From : ${data.Country} </h4>
                                    <br />
                          ");
                WriteLiteral(@"          <h4 class=""text-dark""><b>The Number of Blogs : ${data.BlogsCount}</b></h4>`,
                            showCloseButton: true,
                            showCancelButton: true,
                            focusConfirm: false,
                            confirmButtonText:
                                '<a class=""text-white nav-link p-0"" href=""#""><i class=""fas fa-edit""></i> Edit User</a>',
                            confirmButtonAriaLabel: 'Edit',
                            cancelButtonText:
                                '<span><i class=""fas fa-arrow-circle-left"" ></i> Okay</span>',
                            cancelButtonAriaLabel: 'Okay'
                        });
                    }
                })
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<UserAdminListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591