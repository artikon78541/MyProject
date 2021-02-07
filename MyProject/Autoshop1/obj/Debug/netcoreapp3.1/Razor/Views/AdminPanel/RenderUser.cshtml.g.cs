#pragma checksum "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\RenderUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2555ddebfef4ef298a37786d7737d95c8460c491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_RenderUser), @"mvc.1.0.view", @"/Views/AdminPanel/RenderUser.cshtml")]
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
#line 1 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\RenderUser.cshtml"
using Autoshop1.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2555ddebfef4ef298a37786d7737d95c8460c491", @"/Views/AdminPanel/RenderUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd6e1ff3893fff77185bddb07e1a2399fb40ee0f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_RenderUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelCollection>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<script>
    $().ready(function () {
        $(""#searchInput"").autocomplete({

            source: function (request, response) {
                $.ajax({
                    url: ""/AdminPanel/GetUsers/"",
                    data: { ""searchUser"": request.term },
                    type: ""POST"",
                    success: function (data) {
                        response($.map(data, function (item) {
                            return item;
                        }))
                    }

                });
            }
        });
    });



    $().ready(function (e) {

        $(""#SelectClient"").click(function (e) {

            e.preventDefault();


            $.ajax({
                url: ""/AdminPanel/SelectUser/"",
                data: { searchUser: $(""#searchInput"").val() },
                cache: false,
                success: function (returnhtml) {
                    var obj = JSON.parse(returnhtml);
                    $(""#NumId"").html(obj[0].Email);");
            WriteLiteral(@"
                    $(""#EmailId"").html(obj[0].Email);
                    $(""#PhoneId"").html(obj[0].PhoneNumber);
                    $(""#NameId"").html(obj[0].UserFIO);
                    $(""#cart-total"").html(""("" + obj[1].CartItems + "")"");
                    $(""#searchInput"").val("""");

                },
                dataType: ""json""
            });

        });

    });


</script>


<div class=""client-block"" id=""RenderUser"">

    <div class=""client-block-info"">

        <h5 style=""margin-bottom:2%;"">Информация о клиенте</h5>
        <table class=""client-table-info"" id=""cl"">

            <tr><td>Номер:</td><td class=""td-client""><label id=""NumId"" name=""NumId""> - </label></td></tr>
            <tr><td>Email:</td><td class=""td-client""><label id=""EmailId""> - </label></td></tr>
            <tr><td>Телефон:</td><td class=""td-client""><label id=""PhoneId""> - </label></td></tr>
            <tr><td>ФИО: </td><td class=""td-client""><label id=""NameId""> - </label></td></tr>

        </");
            WriteLiteral("table>\r\n    </div>\r\n    <div class=\"searchLogin-form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2555ddebfef4ef298a37786d7737d95c8460c4916751", async() => {
                WriteLiteral("\r\n            <label for=\"search\" style=\"font-size: 14px;\">Выберите клиента:</label>\r\n            <input name=\"searchUser\" placeholder=\"Номер, имя, телефон клиента...\"\r\n                   class=\"admin-search-client\" type=\"text\" id=\"searchInput\"");
                BeginWriteAttribute("value", " value=\"", 2435, "\"", 2443, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input name=\"UserId\" type=\"hidden\" id=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 2505, "\"", 2513, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"btn\" type=\"submit\" id=\"SelectClient\">Выбрать</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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

    <div class=""cart-partial"">
        <a href=""#"" class=""cart-link"">
            <div class=""iconCart"">
                <i class=""fas fa-shopping-cart""></i>
                <span class=""cart-total"" id=""cart-total""> (0) </span>
            </div>
        </a>
    </div>
");
            WriteLiteral("\r\n\r\n</div>\r\n");
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
