#pragma checksum "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\Event\Destroy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea97f8a525663365381895288379db1d98578f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Destroy), @"mvc.1.0.view", @"/Views/Event/Destroy.cshtml")]
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
#line 1 "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\_ViewImports.cshtml"
using SportsBetting.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\_ViewImports.cshtml"
using SportsBetting.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\_ViewImports.cshtml"
using SportsBetting.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea97f8a525663365381895288379db1d98578f5", @"/Views/Event/Destroy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7893f627f33a94fa6016922a5bbded8860f670a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Destroy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\Event\Destroy.cshtml"
  
    ViewData["Title"] = "Destroy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Are you sure, you want to delete this Event?</h2>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 112, "\"", 146, 2);
            WriteAttributeValue("", 119, "/event/DeletingEvent/", 119, 21, true);
#nullable restore
#line 6 "C:\Users\adida\source\repos\SportsBetting\SportsBetting\Views\Event\Destroy.cshtml"
WriteAttributeValue("", 140, Model, 140, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Confirm Delete</a>\r\n<a href=\"/event/editmode\" class=\"btn btn-default\">Back</a>");
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
