#pragma checksum "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f20b739f613645fbdc0c25198c8864eaa879ef"
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
#line 1 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
using Modas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f20b739f613645fbdc0c25198c8864eaa879ef", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Event>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c73fca81b664b4eb6ad7c1e008ebaeb", async() => {
                BeginContext(110, 551, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Modas</title>
    <!--Bootstrap-->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <!--Font Awesome-->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"" integrity=""sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/"" crossorigin=""anonymous"">
");
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
            BeginContext(668, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(670, 1101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b730606bdbf4463b2799b1b15452840", async() => {
                BeginContext(676, 116, true);
                WriteLiteral("\r\n    <table class=\"container table table-bordered\">\r\n        <tr><th>Date</th><th>Time</th><th>Location</th></tr>\r\n");
                EndContext();
#line 21 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
         foreach (var e in Model)
        {

#line default
#line hidden
                BeginContext(838, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(877, 52, false);
#line 24 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
               Write(String.Format("{0: ddd, MMM dd, yyyy}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(929, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(957, 42, false);
#line 25 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
               Write(String.Format("{0:hh:mm tt}", e.TimeStamp));

#line default
#line hidden
                EndContext();
                BeginContext(999, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1027, 15, false);
#line 26 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
               Write(e.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1042, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 28 "C:\Users\Asus\OneDrive - Waukesha County Technical College\WebServices\Modas\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1079, 685, true);
                WriteLiteral(@"    </table>
    <!--Jquery-->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha256-3edrmyuQ0w65f8gfBsqowzjJe2iM6n0nKciPUp8y+7E=""
            crossorigin=""anonymous""></script>
    <!--Popper-->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <!--Bootstrap-->
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
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
            BeginContext(1771, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
