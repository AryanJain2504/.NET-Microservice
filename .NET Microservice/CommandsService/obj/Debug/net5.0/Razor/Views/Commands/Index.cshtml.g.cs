#pragma checksum "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f738c5a8097fc3438d429b8e0547839057b9b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commands_Index), @"mvc.1.0.view", @"/Views/Commands/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f738c5a8097fc3438d429b8e0547839057b9b8c", @"/Views/Commands/Index.cshtml")]
    public class Views_Commands_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommandsService.Models.Command>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HowTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CommandLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HowTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommandLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Platform.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 986, "\"", 1009, 1);
#nullable restore
#line 40 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
WriteAttributeValue("", 1001, item.Id, 1001, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1062, "\"", 1085, 1);
#nullable restore
#line 41 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
WriteAttributeValue("", 1077, item.Id, 1077, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1140, "\"", 1163, 1);
#nullable restore
#line 42 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
WriteAttributeValue("", 1155, item.Id, 1155, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\ASP.NET Projects\.NET Microservice\CommandsService\Views\Commands\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommandsService.Models.Command>> Html { get; private set; }
    }
}
#pragma warning restore 1591
