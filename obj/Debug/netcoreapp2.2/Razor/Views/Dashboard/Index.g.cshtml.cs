#pragma checksum "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72af5fb07a730693a4b10556660911618511659d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\git\SGTubeMVC\Views\_ViewImports.cshtml"
using SGTubeMVC;

#line default
#line hidden
#line 2 "C:\git\SGTubeMVC\Views\_ViewImports.cshtml"
using SGTubeMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72af5fb07a730693a4b10556660911618511659d", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f438859aa07f85179a159d26d854696801c44a2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGTubeMVC.Models.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/list.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Buscar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(89, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72af5fb07a730693a4b10556660911618511659d7494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(143, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72af5fb07a730693a4b10556660911618511659d8746", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 71, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"content_search\">\r\n        ");
            EndContext();
            BeginContext(261, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72af5fb07a730693a4b10556660911618511659d10078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 70, true);
            WriteLiteral("\r\n\r\n        <div class=\"content\">\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(369, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72af5fb07a730693a4b10556660911618511659d11408", async() => {
                BeginContext(433, 87, true);
                WriteLiteral("\r\n                    <p>Utilize a caixa abaixo para pesquisa</p>\r\n                    ");
                EndContext();
                BeginContext(520, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72af5fb07a730693a4b10556660911618511659d11878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.search);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(581, 75, true);
                WriteLiteral("\r\n                    <button class=\"btn\">Buscar</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 91, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"content_history\">\r\n            ");
            EndContext();
            BeginContext(754, 654, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72af5fb07a730693a4b10556660911618511659d15596", async() => {
                BeginContext(822, 255, true);
                WriteLiteral("\r\n                <table id=\"historical\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th><p>Últimas Pesquisas</p></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
                EndContext();
#line 31 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                         foreach (var item in Model.history)
                        {

#line default
#line hidden
                BeginContext(1166, 78, true);
                WriteLiteral("                            <tr>\r\n                                <td><button>");
                EndContext();
                BeginContext(1245, 10, false);
#line 34 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1255, 51, true);
                WriteLiteral("</button></td>\r\n                            </tr>\r\n");
                EndContext();
#line 36 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1333, 68, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1408, 122, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"content_dashboard\">\r\n        <p>Videos</p>\r\n        <ul class=\"spot-list\">\r\n");
            EndContext();
#line 45 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
             foreach (var item in Model.videos)
            {

#line default
#line hidden
            BeginContext(1594, 83, true);
            WriteLiteral("                <li>\r\n                    <button id=\"idVideo\" style=\"display:none\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1677, "\"", 1701, 1);
#line 48 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1685, item.Id.VideoId, 1685, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 36, true);
            WriteLiteral("></button>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1738, "\"", 1777, 1);
#line 49 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1744, item.Snippet.Thumbnails.High.Url, 1744, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1778, 35, true);
            WriteLiteral(" alt=\"\" />\r\n                    <p>");
            EndContext();
            BeginContext(1814, 24, false);
#line 50 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                  Write(item.Snippet.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 29, true);
            WriteLiteral("</p>\r\n                </li>\r\n");
            EndContext();
#line 52 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1882, 70, true);
            WriteLiteral("        </ul>\r\n        <p>Canais</p>\r\n        <ul class=\"spot-list\">\r\n");
            EndContext();
#line 56 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
             foreach (var item in Model.channels)
            {

#line default
#line hidden
            BeginContext(2018, 83, true);
            WriteLiteral("                <li>\r\n                    <button id=\"idVideo\" style=\"display:none\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2101, "\"", 2127, 1);
#line 59 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2109, item.Id.ChannelId, 2109, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2128, 36, true);
            WriteLiteral("></button>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2164, "\"", 2203, 1);
#line 60 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2170, item.Snippet.Thumbnails.High.Url, 2170, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2204, 35, true);
            WriteLiteral(" alt=\"\" />\r\n                    <p>");
            EndContext();
            BeginContext(2240, 24, false);
#line 61 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                  Write(item.Snippet.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 29, true);
            WriteLiteral("</p>\r\n                </li>\r\n");
            EndContext();
#line 63 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2308, 84, true);
            WriteLiteral("        </ul>\r\n        <p>Listas de Reprodução</p>\r\n        <ul class=\"spot-list\">\r\n");
            EndContext();
#line 67 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
             foreach (var item in Model.playlists)
            {

#line default
#line hidden
            BeginContext(2459, 83, true);
            WriteLiteral("                <li>\r\n                    <button id=\"idVideo\" style=\"display:none\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2542, "\"", 2569, 1);
#line 70 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2550, item.Id.PlaylistId, 2550, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2570, 36, true);
            WriteLiteral("></button>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2606, "\"", 2645, 1);
#line 71 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2612, item.Snippet.Thumbnails.High.Url, 2612, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2646, 35, true);
            WriteLiteral(" alt=\"\" />\r\n                    <p>");
            EndContext();
            BeginContext(2682, 24, false);
#line 72 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
                  Write(item.Snippet.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2706, 29, true);
            WriteLiteral("</p>\r\n                </li>\r\n");
            EndContext();
#line 74 "C:\git\SGTubeMVC\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2750, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3185, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGTubeMVC.Models.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
