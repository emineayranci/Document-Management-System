#pragma checksum "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752c48a352f33f4e47292c4b4316c17eda6df15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeletedDocument_Index), @"mvc.1.0.view", @"/Views/DeletedDocument/Index.cshtml")]
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
#line 1 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
using DocumentManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752c48a352f33f4e47292c4b4316c17eda6df15d", @"/Views/DeletedDocument/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258b6c940c140556587e454c1e7060f07a933c04", @"/Views/_ViewImports.cshtml")]
    public class Views_DeletedDocument_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DeletedDocument>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"alert alert-success\" role=\"alert\">");
#nullable restore
#line 9 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
                                         Write(TempData["Alert"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br />\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>Deleted Document ID</th>\r\n        <th>Deleted Document Name</th>\r\n        <th>Deleted Document Type </th>\r\n        <th>Delete</th>\r\n\r\n\r\n    </tr>\r\n");
#nullable restore
#line 20 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
     foreach (var d in Model)

    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 24 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
           Write(d.deleted_document_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
           Write(d.deleted_document_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 26 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
           Write(d.deleted_document_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 722, 2);
            WriteAttributeValue("", 673, "/DeletedDocument/RemoveDoc/", 673, 27, true);
#nullable restore
#line 27 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
WriteAttributeValue("", 700, d.deleted_document_id, 700, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\WebUygulamaları\DocumentManagementSystem\DocumentManagementSystem\Views\DeletedDocument\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DeletedDocument>> Html { get; private set; }
    }
}
#pragma warning restore 1591