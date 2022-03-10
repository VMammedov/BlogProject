#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a1c626a7a1d4b25914d7ee8df61bce2c5046db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Inbox), @"mvc.1.0.view", @"/Views/Message/Inbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a1c626a7a1d4b25914d7ee8df61bce2c5046db", @"/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessagesPopUpViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/_WriterPanelLayout.cshtml";
    DateTime current = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""p-5"">
    <div class=""bg-light p-4"" style=""border-radius:12px"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""mail-card"" style=""border-radius:12px"">
                    <div class=""card-body bg-custom text-white mailbox-widget pb-0"" style=""border-start-start-radius:12px; border-start-end-radius:12px;"">
                        <h2 class=""text-white pb-3"">Your Mailbox</h2>
                        <ul class=""nav nav-tabs mail-custom-tab border-bottom-0 mt-4"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button active"" id=""inbox-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-email""></i></span>
                                    <span class=""d-none d-md-block""> INBOX</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
             ");
            WriteLiteral(@"                   <a class=""nav-link custom-mail-nav-button"" id=""sent-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-export""></i></span>
                                    <span class=""d-none d-md-block"">SENT</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button"" id=""spam-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-panel""></i></span>
                                    <span class=""d-none d-md-block"">SPAM</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link custom-mail-nav-button"" id=""delete-tab"">
                                    <span class=""d-block d-md-none""><i class=""ti-trash""></i></span>
                                    <span class=");
            WriteLiteral(@"""d-none d-md-block"">DELETED</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade active show"" id=""inbox"" aria-labelledby=""inbox-tab"" role=""tabpanel"">
                            <div>
                                <div class=""row p-4 no-gutters align-items-center"">
                                    <div class=""col-sm-12 col-md-6"">
                                        <h3 class=""font-light mb-0""><i class=""ti-email mr-2""></i>1 Unread emails</h3>
                                    </div>
                                    <div class=""col-sm-12 col-md-6"">
                                        <div class=""text-right"">
                                            <a href=""#"">
                                                <span class=""btn btn-circle btn-success text-white"">
                      ");
            WriteLiteral(@"                              <i class=""fa fa-plus""></i>
                                                </span>
                                                <span class=""ml-2 font-normal text-dark"">Compose</span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <!-- Mail list-->
                                <div class=""table-responsive"">
                                    <table class=""table email-table no-wrap table-hover v-middle mb-0 font-14"">
                                        <tbody>
                                            <!-- row -->
");
#nullable restore
#line 66 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                             foreach (WriterMessagesPopUpViewModel item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <tr>
                                                    <!-- label -->
                                                    <td class=""pl-3"">
                                                        <div class=""custom-control custom-checkbox"">
                                                            <input type=""checkbox"" class=""custom-control-input"" id=""cst1"" />
                                                            <label class=""custom-control-label"" for=""cst1"">&nbsp;</label>
                                                        </div>
                                                    </td>
                                                    <!-- star -->
                                                    <td><i class=""fa fa-star text-warning""></i></td>
                                                    <td>
                                                        <span class=""mb-0 text-muted"">");
#nullable restore
#line 79 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                                                 Write(item.Sender.WriterNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </td>
                                                    <!-- Message -->
                                                    <td>
                                                        <a class=""link""");
            BeginWriteAttribute("href", " href=\"", 5411, "\"", 5457, 2);
            WriteAttributeValue("", 5418, "/Message/MessageDetails/", 5418, 24, true);
#nullable restore
#line 83 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 5442, item.MessageID, 5442, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <span class=\"badge badge-pill text-white font-medium badge-danger mr-2\">");
#nullable restore
#line 84 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                                                                                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 85 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                             if (item.MessageContent.Length > 60)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"text-dark\">");
#nullable restore
#line 87 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                                                   Write(item.MessageContent.Substring(0,60));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"text-dark\">...</span>\r\n");
#nullable restore
#line 88 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-dark\">");
#nullable restore
#line 90 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                                                Write(item.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 90 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </a>
                                                    </td>
                                                    <!-- Time -->
                                                    <td class=""text-muted"">
");
#nullable restore
#line 95 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                          
                                                            string msgdate = (int)current.Subtract(item.MessageDate).TotalDays != 0 ?
                                                            ((int)current.Subtract(item.MessageDate).TotalDays + " day " + ((int)current.Subtract(item.MessageDate).TotalHours % 24) + " hours ago...").ToString() :
                                                            ((int)current.Subtract(item.MessageDate).TotalHours % 24) != 0 ? (((int)current.Subtract(item.MessageDate).TotalHours % 24) + " hours ago...").ToString() :
                                                            (((int)current.Subtract(item.MessageDate).Minutes) + " minutes ago...").ToString();
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
#nullable restore
#line 101 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                                   Write(msgdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 104 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\Inbox.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <!-- row -->
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessagesPopUpViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
