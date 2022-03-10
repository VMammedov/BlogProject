#pragma checksum "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17af43338cdc305fe8c8be1d3f6255172fdac737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_WriterNotification), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/WriterNotification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17af43338cdc305fe8c8be1d3f6255172fdac737", @"/Views/Shared/Components/WriterNotification/WriterNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3495f2229832592de9644ea07e232a89ab496cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNotification_WriterNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<button class=""nav-button"" data-toggle=""modal"" data-target=""#NotificationModal"" style=""border:none"">
    <i class=""fas fa-bell""></i>
</button>

<!-- Modal -->
<div class=""modal fade"" id=""NotificationModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""NotificationModalTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""NotificationModalTitle""><i class=""fas fa-bell""></i> Notifications</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-left p-4"">
");
#nullable restore
#line 18 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center mb-3\">\r\n                        <div class=\"card-header card-notification\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                       Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body\" style=\"color: #01cd74;\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                                              Write(item.NotificationTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                                            Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer text-muted card-notification-date \">\r\n                            ");
#nullable restore
#line 29 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                       Write(item.NotificationDate.ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 33 "C:\Users\vusal\source\repos\BlogProject\BlogProject\Views\Shared\Components\WriterNotification\WriterNotification.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn nav-button\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
