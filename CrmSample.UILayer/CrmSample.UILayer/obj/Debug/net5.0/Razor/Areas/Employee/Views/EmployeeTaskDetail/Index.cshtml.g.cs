#pragma checksum "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\EmployeeTaskDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa8fd7bdda1724b78805b0a9a0ea81233186d0a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_EmployeeTaskDetail_Index), @"mvc.1.0.view", @"/Areas/Employee/Views/EmployeeTaskDetail/Index.cshtml")]
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
#line 1 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\_ViewImports.cshtml"
using CrmSample.UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\_ViewImports.cshtml"
using CrmSample.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\_ViewImports.cshtml"
using CrmSample.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\_ViewImports.cshtml"
using CrmSample.UILayer.Areas.Employee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa8fd7bdda1724b78805b0a9a0ea81233186d0a8", @"/Areas/Employee/Views/EmployeeTaskDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c2dabcaf9e3dc144873db4886ccf59085366650", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Employee_Views_EmployeeTaskDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeTaskDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\EmployeeTaskDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Görev Detayları</h3>\r\n<table>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\EmployeeTaskDetail\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            ");
#nullable restore
#line 14 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\EmployeeTaskDetail\Index.cshtml"
       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n        </tr>\r\n");
#nullable restore
#line 17 "C:\Users\DELL\OneDrive\Masaüstü\EĞİTİM\CrmSample.UILayer\CrmSample.UILayer\Areas\Employee\Views\EmployeeTaskDetail\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeTaskDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
