#pragma checksum "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f43f64de1d720d9a1ba08c8996bc5b19bf79a364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43f64de1d720d9a1ba08c8996bc5b19bf79a364", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd6e1ff3893fff77185bddb07e1a2399fb40ee0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListParts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f43f64de1d720d9a1ba08c8996bc5b19bf79a3646886", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css""
          integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900&display=swap""
          rel=""stylesheet"">
    <script src=""https://kit.fontawesome.com/0fb52fd33c.js"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f43f64de1d720d9a1ba08c8996bc5b19bf79a3647843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f43f64de1d720d9a1ba08c8996bc5b19bf79a3649821", async() => {
                WriteLiteral(@"
        <header class=""menu-bar"">
            <div class=""container-fluid  upper-menu"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12 align-items-center"">
                            <div class=""phone"">+7(921)100-00-00</div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""container-fluid mid-menu"">
                <div class=""container mid-menu"">
                    <div class=""row mid-inner-menu align-items-center"">

                        <div class=""col-12 col-md-1 col-xl-2"">
                            <a href=""/"">
                                <div class=""image-logo"">

                                </div>
                            </a>
                        </div>
                        <div class=""col-12 col-md-7 col-xl-6 order-1 order-md-0 searchline"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f43f64de1d720d9a1ba08c8996bc5b19bf79a36411087", async() => {
                    WriteLiteral("\r\n                                <input name=\"searchline\" placeholder=\"Введите номер запчасти...\" type=\"search\" id=\"searchline\"");
                    BeginWriteAttribute("value", " value=\"", 9355, "\"", 9363, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <button type=\"submit\">Поиск</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral("\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f43f64de1d720d9a1ba08c8996bc5b19bf79a36413523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                            <div class=""col-3 col-md-1 col-xl-1 order-0 order-md-1 iconCart"">
                                <i class=""fas fa-shopping-cart""></i>
                                <span class=""cart-total"">(1)</span>
                            </div>

                    </div>
                </div>
            </div>

            <div class=""container-fluid bottom-menu"">
                <div class=""container"">
                    <ul class=""main-menu"">
                        <li><a class=""menulink""");
                BeginWriteAttribute("href", " href=\"", 10730, "\"", 10737, 0);
                EndWriteAttribute();
                WriteLiteral(">Поиск</a></li>\r\n                        <li><a class=\"menulink\"");
                BeginWriteAttribute("href", " href=\"", 10802, "\"", 10809, 0);
                EndWriteAttribute();
                WriteLiteral(">О компании</a></li>\r\n                        <li><a class=\"menulink\"");
                BeginWriteAttribute("href", " href=\"", 10879, "\"", 10886, 0);
                EndWriteAttribute();
                WriteLiteral(">Доставка</a></li>\r\n                        <li><a class=\"menulink\"");
                BeginWriteAttribute("href", " href=\"", 10954, "\"", 10961, 0);
                EndWriteAttribute();
                WriteLiteral(">Оплата</a></li>\r\n                        <li><a class=\"menulink\"");
                BeginWriteAttribute("href", " href=\"", 11027, "\"", 11034, 0);
                EndWriteAttribute();
                WriteLiteral(">Возврат</a></li>\r\n                        <li><a class=\"menulink\"");
                BeginWriteAttribute("href", " href=\"", 11101, "\"", 11108, 0);
                EndWriteAttribute();
                WriteLiteral(">Контакты</a></li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n        </header>\r\n        <section>\r\n\r\n            ");
#nullable restore
#line 257 "C:\Users\Роман\source\repos\MyProject\Autoshop1\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        </section>
        <footer>
            <div class=""container-fluid"">
                <div class=""footer-menu"">
                    <div class=""container"">
                        <div class=""row footer-menu-col"">
                            <div class=""col-md-4 rowFooter1"">
                                <div class=""logo-footer"">
                                    <a href=""/"">
                                        <div class=""image-logo""></div>
                                    </a>
                                </div>
                                <div class=""footer-City"">Санкт-Петербург</div>
                                <div class=""footer-phone"">+7(921)100-00-00</div>

                            </div>
                            <div class=""col-xs-6 col-md-4 rowFooter2"">
                                <div>
                                    <h6 style=""margin-top: 10px;"">КАТАЛОГИ ТОВАРОВ</h6>
                                </div>

                        ");
                WriteLiteral("        <ul class=\"footer-menu1\">\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 12368, "\"", 12375, 0);
                EndWriteAttribute();
                WriteLiteral(">Масла</a></li>\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 12435, "\"", 12442, 0);
                EndWriteAttribute();
                WriteLiteral(">Аккумуляторы</a></li>\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 12509, "\"", 12516, 0);
                EndWriteAttribute();
                WriteLiteral(@">Лампы</a></li>
                                </ul>
                            </div>
                            <div class=""col-xs-6 col-md-4 rowFooter3"">
                                <div>
                                    <h6 style=""margin-top: 10px;"">ИНФОРМАЦИЯ</h6>
                                </div>
                                <ul class=""footer-menu1"">
                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 12944, "\"", 12951, 0);
                EndWriteAttribute();
                WriteLiteral(">Доставка</a></li>\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 13014, "\"", 13021, 0);
                EndWriteAttribute();
                WriteLiteral(">Оплата</a></li>\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 13082, "\"", 13089, 0);
                EndWriteAttribute();
                WriteLiteral(">Возврат товара</a></li>\r\n                                    <li><a");
                BeginWriteAttribute("href", " href=\"", 13158, "\"", 13165, 0);
                EndWriteAttribute();
                WriteLiteral(@">Контакты</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""footer-bottom"">
                    <div class=""container"">
                        2020 &copy; Автозапчасти
                    </div>
                </div>
            </div>
        </footer>

        <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""
                integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj""
                crossorigin=""anonymous""></script>

        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js""
                integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx""
                crossorigin=""anonymous""></script>
    
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
