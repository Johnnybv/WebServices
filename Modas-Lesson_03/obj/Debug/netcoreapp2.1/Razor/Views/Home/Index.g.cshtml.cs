#pragma checksum "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a28738723b49094c54cc5cf1d624c100bd8cb01a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
using Modas.Models;

#line default
#line hidden
#line 2 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
using Modas.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28738723b49094c54cc5cf1d624c100bd8cb01a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/client.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(100, 326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c23369655cc641e89b575288740358df", async() => {
                BeginContext(106, 59, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <title>MODAS</title>\n    ");
                EndContext();
                BeginContext(165, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf60bf4ae4e145e68e12ae9c80880fae", async() => {
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
                BeginContext(215, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(220, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a00756cccef443ca14b7f8a95b596b1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(276, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(281, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ca3a37cf25e4762923d69c075a28e1d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(330, 89, true);
                WriteLiteral("\n    <style>\n        #flag:hover{\r\n            cursor : pointer;\r\n        }\n    </style>\n");
                EndContext();
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
            EndContext();
            BeginContext(426, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(427, 3295, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98286bbda32d41eeb3e41d9d75c80d46", async() => {
                BeginContext(433, 269, true);
                WriteLiteral(@"

    <div class=""container"">
        <table class=""table table-sm table-striped table-shadow"">
            <thead class=""bg-success text-white"">
                <tr><th>Flag</th><th>Date</th><th>Time</th><th>Location</th></tr>
            </thead>
            <tbody>
");
                EndContext();
#line 26 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                 foreach (var e in Model.Events)
                {

#line default
#line hidden
                BeginContext(769, 71, true);
                WriteLiteral("                    <tr>\n                        <td class=\"flagged\">\r\n");
                EndContext();
#line 30 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                             if (e.Flagged == false)
                            {

#line default
#line hidden
                BeginContext(923, 39, true);
                WriteLiteral(" <i class=\"far fa-flag\" id=\"flag\"></i> ");
                EndContext();
#line 31 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                    }
                            else {

#line default
#line hidden
                BeginContext(999, 39, true);
                WriteLiteral(" <i class=\"fas fa-flag\" id=\"flag\"></i> ");
                EndContext();
#line 32 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                         }

#line default
#line hidden
                BeginContext(1041, 59, true);
                WriteLiteral("                         </td>\n                        <td>");
                EndContext();
                BeginContext(1101, 52, false);
#line 34 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                       Write(String.Format("{0: ddd, MMM dd, yyyy}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(1153, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1188, 42, false);
#line 35 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                       Write(String.Format("{0:hh:mm tt}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1265, 15, false);
#line 36 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                       Write(e.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1280, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 38 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1330, 403, true);
                WriteLiteral(@"            </tbody>
        </table>
        <div class=""row mb-3"">
            <div class=""col"">
                <button disabled id=""first"" class=""btn btn-outline-secondary"" type=""button"" data-page=""1""><i class=""fas fa-angle-double-left""></i><span class=""d-none d-md-inline""> First</span></button>
                <button disabled id=""prev"" class=""btn btn-outline-secondary"" type=""button"" data-page=""");
                EndContext();
                BeginContext(1735, 29, false);
#line 44 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                                                  Write(Model.PagingInfo.PreviousPage);

#line default
#line hidden
                EndContext();
                BeginContext(1765, 199, true);
                WriteLiteral("\"><i class=\"fas fa-angle-left\"></i><span class=\"d-none d-md-inline\"> Prev</span></button>\n            </div>\n            <div class=\"col text-center text-secondary\">\n                <span id=\"start\">");
                EndContext();
                BeginContext(1966, 27, false);
#line 47 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                             Write(Model.PagingInfo.RangeStart);

#line default
#line hidden
                EndContext();
                BeginContext(1994, 23, true);
                WriteLiteral("</span>-<span id=\"end\">");
                EndContext();
                BeginContext(2019, 25, false);
#line 47 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                                  Write(Model.PagingInfo.RangeEnd);

#line default
#line hidden
                EndContext();
                BeginContext(2045, 60, true);
                WriteLiteral("</span>\n                of\n                <span id=\"total\">");
                EndContext();
                BeginContext(2107, 27, false);
#line 49 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                             Write(Model.PagingInfo.TotalItems);

#line default
#line hidden
                EndContext();
                BeginContext(2135, 170, true);
                WriteLiteral("</span>\n            </div>\n            <div class=\"col text-right\">\n                <button disabled id=\"next\" class=\"btn btn-outline-secondary\" type=\"button\" data-page=\"");
                EndContext();
                BeginContext(2307, 25, false);
#line 52 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                                                  Write(Model.PagingInfo.NextPage);

#line default
#line hidden
                EndContext();
                BeginContext(2333, 179, true);
                WriteLiteral("\"><span class=\"d-none d-md-inline\">Next </span><i class=\"fas fa-angle-right\"></i></button>\n                <button disabled id=\"last\" class=\"btn btn-outline-secondary\" data-page=\"");
                EndContext();
                BeginContext(2514, 27, false);
#line 53 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas-Lesson_03\Views\Home\Index.cshtml"
                                                                                    Write(Model.PagingInfo.TotalPages);

#line default
#line hidden
                EndContext();
                BeginContext(2542, 331, true);
                WriteLiteral(@"""><span class=""d-none d-md-inline"">Last </span><i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous""></script>
    ");
                EndContext();
                BeginContext(2873, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf7e1e2d5d7e41ecac5a6eadaec5e0c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2918, 797, true);
                WriteLiteral(@"
    <script>
        $(function () {
            initButtons();

            // event listeners for first/next/prev/last buttons
            $('#next, #prev, #first, #last').on('click', function () {
                location.href = ""page"" + $(this).data('page');
            });

            function initButtons() {
                // disable prev/first buttons when on first page
                $('#first, #prev').prop('disabled', $('#start').html() == ""1"");
                // disable next/last buttons when on last page
                $('#last, #next').prop('disabled', $('#end').html() == $('#total').html());
            }

            $('.flagged').on('click', function () {
                $('i', this).toggleClass(""far fa-flag fas fa-flag"");
            });
        });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(3722, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
