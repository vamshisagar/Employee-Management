#pragma checksum "/Users/vamshimolla/Projects/EmployeeManagement/EmployeeManagement/Views/Home/EmployeeNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f32b761aa1b99047f97ecfc40ae315483ccd00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeNotFound), @"mvc.1.0.view", @"/Views/Home/EmployeeNotFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EmployeeNotFound.cshtml", typeof(AspNetCore.Views_Home_EmployeeNotFound))]
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
#line 1 "/Users/vamshimolla/Projects/EmployeeManagement/EmployeeManagement/Views/_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f32b761aa1b99047f97ecfc40ae315483ccd00c", @"/Views/Home/EmployeeNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"655b71d13637b4ca29cba256454501c70d843336", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/vamshimolla/Projects/EmployeeManagement/EmployeeManagement/Views/Home/EmployeeNotFound.cshtml"
  
    ViewBag.Titile = "Page not found";

#line default
#line hidden
            BeginContext(56, 124, true);
            WriteLiteral("\n<div class=\"alert alert-danger mt-1 mb-1\">\n    <h4>404 Not Found Error</h4>\n    <hr />\n    <h5>\n        Employee with ID = ");
            EndContext();
            BeginContext(181, 5, false);
#line 11 "/Users/vamshimolla/Projects/EmployeeManagement/EmployeeManagement/Views/Home/EmployeeNotFound.cshtml"
                      Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(186, 33, true);
            WriteLiteral(" cannot be found\n    </h5>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
