#pragma checksum "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f05fd6db7656d9499e91006c93787df4036843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Search), @"mvc.1.0.view", @"/Views/AdminPanel/Search.cshtml")]
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
#line 1 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
using Autoshop1.Models.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
using Autoshop1.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f05fd6db7656d9499e91006c93787df4036843", @"/Views/AdminPanel/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd6e1ff3893fff77185bddb07e1a2399fb40ee0f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelCollection>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pq"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

    //$(document).ready(function () {

    //    $(""form"").submit(function (e) {

    //        //var sendingData = {
    //        //    partId: $(""input[name='partId']"").val(),
    //        //    quant: $(""input[name='quant']"").val()
    //        //}

    //        e.preventDefault();
    //        $.ajax({

    //            url: ""/AdminPanel/ToCartTest/"",
    //            contentType: 'application/json',
    //            dataType: ""json"",
    //            method: ""POST"",
    //            data: JSON.stringify({ partId: $(""input[name='partId']"").val() }),
    //            //data: JSON.stringify(sendingData),
    //            //data: { sendingData },
    //            success: function (json) {
    //                alert(""Value Added"");

    //            }

    //        });

    //    });
    //});




    //$(document).ready(function () {

    //    $(""form"").submit(function (e) {
                  

            
    //        var part = $(""");
            WriteLiteral(@"input[name='partId']"").val();
    //        var qua = $(""input[name='quant']"").val();
    //        var valdata = { partId: part, quant = qua };


    //        e.preventDefault();
    //        $.ajax({

    //            url: ""/AdminPanel/ToCartTest/"",
    //            //contentType: 'application/json; charset=UTF-8',
    //            dataType: ""json"",
    //            method: ""POST"",
    //            data: JSON.stringify(valdata),
    //            success: function (data) {
    //                alert(""Value Added"");

    //            }

    //        });

    //    });
    //});

//$().ready(function () {

//    $(""form"").submit(function (e) {

//        var sendingData = {
//            partId: $('input[name=""partId""]').val(),
//            quant: $('input[name=""quant""]').val()
//        }

//        e.preventDefault();
//        $.ajax({

//            url: ""/AdminPanel/ToCartTest/"",
//            contentType: 'application/json',
//            dataType: ""json"",");
            WriteLiteral(@"
//            method: ""POST"",

//            success: function (data) {
//                alert(""Value Added"");

//            },
//            data: JSON.stringify(sendingData),
//            error: function (data) { alert(data.responseText); }

//        });


//    });

//});

    //$(function () {

    //    $(""form"").submit(function (e) {

    //        var p = $(""input[name='partId']"").val()
    //        var q = $(""input[name='quant']"").val()

    //        var sData = {
    //            partId: p,
    //            quant: q
    //        }

    //        e.preventDefault();
    //        $.ajax({

    //            url: ""/AdminPanel/ToCartTest/"",
    //            type: ""POST"",

    //            success: function (data) {
    //                alert(""Товар добавлен в корзину"");


    //            },
    //            data: { sendingData: sData },
    //            error: function (data) { alert(data.responseText); }

    //        });


    //    });
");
            WriteLiteral(@"
    //});

    $(function () {

        $(""form"").submit(function (e) {


            var id = $(this).attr(""id"")
            var stt = '#' + id

            var p = $(stt).find(""input[name='partId']"").val()
            var q = $(stt).find(""input[name='quant']"").val()


            var sData = {
                partId: p,
                quant: q,
                str: stt
            }

            e.preventDefault();
            $.ajax({

                url: ""/AdminPanel/ToCartTest/"",
                type: ""POST"",

                success: function (data) {
                    alert(""Товар добавлен в корзину"");

                    var stringCartTotal = $(""#cart-total"").text()
                    var cartTotal = parseInt(stringCartTotal.substring(1, stringCartTotal.length - 1));
                    var result = cartTotal + 1;
                    $(""#cart-total"").html(""("" + result + "")"");

                },
                data: { sendingData: sData },
                e");
            WriteLiteral(@"rror: function (data) { alert(data.responseText); }

            });


        });

    });

    //$(function () {

    //    $(""#1"").submit(function (e) {


    //        alert(""Работает"");

    //        $.ajax({
    //            url: ""/AdminPanel/SelectUser/"",
    //            data: { searchUser: $(""#searchInput"").val() },
    //            cache: false,
    //            success: function (returnhtml) {
    //                var obj = JSON.parse(returnhtml);
    //                $(""#NumId"").html(obj[0].Email);
    //                $(""#EmailId"").html(obj[0].Email);
    //                $(""#PhoneId"").html(obj[0].PhoneNumber);
    //                $(""#NameId"").html(obj[0].UserFIO);
    //                $(""#cart-total"").html(""("" + obj[1].CartItems + "")"");
    //                $(""#searchInput"").val("""");

    //            },
    //            dataType: ""json""
    //        });
    //    });

    //});

    //function clickHandler() {
    //    alert(""Работает"");
  ");
            WriteLiteral("  //}\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 219 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
   if (!(Model is null))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"search-list\" id=\"search-list\">\r\n");
#nullable restore
#line 222 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
               if (!(Model.GetModel<List<SearchPart>>().Count() > 0))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>По вашему запросу ничего не найдено</h4>\r\n");
#nullable restore
#line 225 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""search-table"">
                        <thead>
                            <tr>
                                <th>Бренд</th>
                                <th>Номер</th>
                                <th>Наименование</th>
                                <th>Срок поставки</th>
                                <th>На складе</th>
                                <th>Цена закупки</th>
                                <th style=""text-align: center;"">Поставщик</th>
                                <th style=""text-align: center;"">Цена клиента</th>
                                <th style=""width: 15%; text-align: center;"">Заказ</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 242 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                              
                                foreach (var p in Model.GetModel<List<SearchPart>>())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 247 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 248 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 249 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.PartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 250 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.DeliveryDate.Date.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 251 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.QuantityInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 252 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.BuyingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <th>");
#nullable restore
#line 253 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                       Write(p.VendorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                        <td class=\"th-price\">\r\n                                            <input type=\"text\" class=\"input-field-price\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7252, "\"", 7281, 1);
#nullable restore
#line 256 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
WriteAttributeValue("", 7266, p.SellingPrice, 7266, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                                   value=\"", 7282, "\"", 7342, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </td>\r\n                                        <td align=\"center\">\r\n                                            <div class=\"input-cart\">\r\n\r\n\r\n");
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f05fd6db7656d9499e91006c93787df403684315358", async() => {
                WriteLiteral(@"
                                                    <input type=""text"" name=""quant"" class=""input-field inp-quant"" placeholder=""1"" value=""1"">
                                                    <input type=""hidden"" name=""partId"" class=""input-field inp-partId""");
                BeginWriteAttribute("value", " value=\"", 8242, "\"", 8259, 1);
#nullable restore
#line 268 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
WriteAttributeValue("", 8250, p.PartId, 8250, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                                                    <button class=\"cart-button\" type=\"submit\">Купить</button>\r\n");
                WriteLiteral("                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 266 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
AddHtmlAttributeValue("", 7971, p.PartId, 7971, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 277 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 281 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 284 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\AdminPanel\Search.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
