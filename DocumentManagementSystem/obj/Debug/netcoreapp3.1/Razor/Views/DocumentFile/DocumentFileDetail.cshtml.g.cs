#pragma checksum "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "489fe9e5c691d654f2e7747179df4d4e4fd2453b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocumentFile_DocumentFileDetail), @"mvc.1.0.view", @"/Views/DocumentFile/DocumentFileDetail.cshtml")]
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
#line 1 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\_ViewImports.cshtml"
using DocumentManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
using DocumentManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489fe9e5c691d654f2e7747179df4d4e4fd2453b", @"/Views/DocumentFile/DocumentFileDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258b6c940c140556587e454c1e7060f07a933c04", @"/Views/_ViewImports.cshtml")]
    public class Views_DocumentFile_DocumentFileDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
  
    ViewData["Title"] = "DocumentFileDetail";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h3>");
#nullable restore
#line 9 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>Document ID</th>\r\n        <th>Document Name</th>\r\n        <th>Document Type</th>\r\n        <th>User ID</th>\r\n        <th>Document File Name</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
     foreach (var d in Model)

    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
           Write(d.document_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 24 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
           Write(d.document_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
           Write(d.document_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 26 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
           Write(d.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 27 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
           Write(d.DocumentFileID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DocumentFile\DocumentFileDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n");
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
