#pragma checksum "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e26cf7e2495b800c06dcaf0b67dc2946aaab862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
#line 1 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\_ViewImports.cshtml"
using CrmSample.UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\_ViewImports.cshtml"
using CrmSample.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\_ViewImports.cshtml"
using CrmSample.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e26cf7e2495b800c06dcaf0b67dc2946aaab862", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2d2e601a9f782c639f77307707a61359137401", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppRole>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CRMLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rol Listesi</h1>\r\n\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Rol Adı</th>\r\n        <th>Rol Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 417, "\"", 449, 2);
            WriteAttributeValue("", 424, "/Role/DeleteRole/", 424, 17, true);
#nullable restore
#line 22 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
WriteAttributeValue("", 441, item.Id, 441, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Views\Role\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Role/AddRole/\" class=\"btn btn-primary\">Yeni Rol Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
