#pragma checksum "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_CartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620e235d6883661590795d192f159c37a6f49916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CartPartial), @"mvc.1.0.view", @"/Views/Shared/_CartPartial.cshtml")]
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
#line 1 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Autoshop1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Autoshop1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Autoshop1.Models.MainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Autoshop1.Models.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Autoshop1.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_CartPartial.cshtml"
using Autoshop1.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620e235d6883661590795d192f159c37a6f49916", @"/Views/Shared/_CartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd6e1ff3893fff77185bddb07e1a2399fb40ee0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelCollection>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a href=\"#\" class=\"cart-link\">\r\n    <div class=\"iconCart\">\r\n        <i class=\"fas fa-shopping-cart\"></i>\r\n        <span class=\"cart-total\">(\r\n");
#nullable restore
#line 12 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_CartPartial.cshtml"
         if (@Model != null) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_CartPartial.cshtml"
    Write(Model.GetModel<int>());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_CartPartial.cshtml"
                                
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        )</span>\r\n    </div>\r\n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelCollection> Html { get; private set; }
    }
}
#pragma warning restore 1591
