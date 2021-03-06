#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29262e8abe2c090c186dad7b134dac1a3377dde6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InboxMessageDetails), @"mvc.1.0.view", @"/Views/Message/InboxMessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29262e8abe2c090c186dad7b134dac1a3377dde6", @"/Views/Message/InboxMessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_InboxMessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageBoxViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MessageBoxPanelPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("msg-pp-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
  
    ViewData["Title"] = "InboxMessageDetails";
    Layout = "~/Views/Shared/_WriterPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .msg-pp-img {
        width: 60px;
        height: 60px;
        border-radius: 50%;
    }
</style>

<script src=""https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js""></script>

<div class=""p-5"">
    <div class=""bg-light p-4"" style=""border-radius:12px"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""mail-card"" style=""border-radius:12px"">
                    <div class=""card-body bg-custom text-white mailbox-widget pb-0"" style=""border-start-start-radius:12px; border-start-end-radius:12px;"">
                        <h2 class=""text-white pb-3"">Message - ");
#nullable restore
#line 24 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                         Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Details</h2>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29262e8abe2c090c186dad7b134dac1a3377dde65884", async() => {
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
            WriteLiteral(@"
                    </div>
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade active show"" id=""inbox"" aria-labelledby=""inbox-tab"" role=""tabpanel"">
                            <div>
                                <!-- Mail Details-->
                                <div class=""container pt-5 pb-5"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <div class=""d-flex justify-content-center align-items-center"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29262e8abe2c090c186dad7b134dac1a3377dde67663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1552, "~/WriterImageFiles/", 1552, 19, true);
#nullable restore
#line 35 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
AddHtmlAttributeValue("", 1571, Model.User.SenderImage, 1571, 23, false);

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
            WriteLiteral("\r\n                                                <div class=\"ml-4\">\r\n                                                    <h4>");
#nullable restore
#line 37 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                   Write(Model.User.SenderNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                    <p>");
#nullable restore
#line 38 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                  Write(Model.User.SenderMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-sm-8"">
                                            <div class=""d-flex justify-content-between align-items-center"">
                                                <div>
                                                    <h4 class=""font-light mb-2"" style=""font-size:1.4rem;"">Subject: ");
#nullable restore
#line 45 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                                                                              Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                    <h5 class=\"font-light\">To : ");
#nullable restore
#line 46 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                                           Write(Model.User.ReceiverMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                </div>\r\n                                                <div>\r\n                                                    <h6><i class=\"fas fa-history\"></i> ");
#nullable restore
#line 49 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                                                                  Write(Model.MessageDate.ToString("dddd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""p-3"">
                                        <p class=""text-dark font-light"" id=""msgContent"" style=""font-size:1.1rem;"">
                                            ");
#nullable restore
#line 57 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Message\InboxMessageDetails.cshtml"
                                       Write(Html.Raw(Model.MessageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <hr />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageBoxViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
