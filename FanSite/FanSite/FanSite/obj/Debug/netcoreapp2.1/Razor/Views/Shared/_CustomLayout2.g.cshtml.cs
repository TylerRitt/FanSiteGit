#pragma checksum "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35068737270265f6e9ded06c3675e633da4dfd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CustomLayout2), @"mvc.1.0.view", @"/Views/Shared/_CustomLayout2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CustomLayout2.cshtml", typeof(AspNetCore.Views_Shared__CustomLayout2))]
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
#line 1 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\_ViewImports.cshtml"
using FanSite;

#line default
#line hidden
#line 2 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\_ViewImports.cshtml"
using FanSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35068737270265f6e9ded06c3675e633da4dfd6", @"/Views/Shared/_CustomLayout2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410e00963ed3ae69782d33fdd7c1b035617d65e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CustomLayout2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190dd30e41bb4856ada643d73e595edd", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 10, true);
                WriteLiteral("</title>\r\n");
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
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 616, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fedb94a1e1724fde954feffc03a52238", async() => {
                BeginContext(144, 84, true);
                WriteLiteral("\r\n    List of Stories:\r\n\r\n    <h2>This page is also using a custom Layout!!</h2>\r\n\r\n");
                EndContext();
#line 13 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
     foreach (Stories s in Model)
    {

#line default
#line hidden
                BeginContext(270, 12, true);
                WriteLiteral("        <h2>");
                EndContext();
                BeginContext(283, 6, false);
#line 15 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
       Write(s.Name);

#line default
#line hidden
                EndContext();
                BeginContext(289, 13, true);
                WriteLiteral("</h2><br />\r\n");
                EndContext();
                BeginContext(313, 15, false);
#line 17 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
   Write(ViewBag.s.Story);

#line default
#line hidden
                EndContext();
                BeginContext(328, 50, true);
                WriteLiteral(" <br />\r\n        <b>Comments</b>\r\n        <br />\r\n");
                EndContext();
#line 20 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
         foreach (Comment c in s.Comments)
        {
            

#line default
#line hidden
                BeginContext(446, 10, false);
#line 22 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
       Write(s.Comments);

#line default
#line hidden
                EndContext();
                BeginContext(456, 9, true);
                WriteLiteral(" <br />\r\n");
                EndContext();
#line 23 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"


        }

#line default
#line hidden
                BeginContext(480, 16, true);
                WriteLiteral("        <br />\r\n");
                EndContext();
                BeginContext(498, 58, true);
                WriteLiteral("        <a href=\"/Stories/AddComment\">Add A Comment!</a>\r\n");
                EndContext();
#line 29 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"

    }

#line default
#line hidden
                BeginContext(565, 155, true);
                WriteLiteral("\r\n    <br>\r\n    <a href=\"/Home\">Home</a>\r\n    <a href=\"/Sources/Links\">Links</a><br />\r\n    <a href=\"/Sources/Books\">Books</a>\r\n\r\n\r\n\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(721, 12, false);
#line 41 "C:\Users\Tyler\Desktop\FanSiteGit\FanSite\FanSite\FanSite\Views\Shared\_CustomLayout2.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(733, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(754, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591