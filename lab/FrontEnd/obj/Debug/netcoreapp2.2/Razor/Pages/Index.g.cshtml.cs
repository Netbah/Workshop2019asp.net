#pragma checksum "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2213514592eea075d5d90fad2de76d323914fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(FrontEnd.Pages.Pages_Index), null)]
namespace FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2213514592eea075d5d90fad2de76d323914fa", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a374d0d15cd4998cc4253f2a01ab7695a3d6cc4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Session", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Speaker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 33, true);
            WriteLiteral("\n<ul class=\"nav nav-pills mb-3\">\n");
            EndContext();
#line 8 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
     foreach (var day in Model.DayOffsets)
    {

#line default
#line hidden
            BeginContext(148, 62, true);
            WriteLiteral("        <li role=\"presentation\" class=\"nav-item\">\n            ");
            EndContext();
            BeginContext(210, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2213514592eea075d5d90fad2de76d323914fa4139", async() => {
                BeginContext(317, 25, false);
#line 11 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                                                                 Write(day.DayofWeek?.ToString());

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 220, "nav-link", 220, 8, true);
#line 11 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
AddHtmlAttributeValue(" ", 228, Model.CurrentDayOffset == day.Offset ? "active" : null, 229, 57, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-day", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                                             WriteLiteral(day.Offset);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["day"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-day", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["day"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(346, 15, true);
            WriteLiteral("\n        </li>\n");
            EndContext();
#line 13 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(367, 50, true);
            WriteLiteral("</ul>\n\n<div class=\"agenda\">\n    <h1>My Conference ");
            EndContext();
            BeginContext(418, 24, false);
#line 17 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                 Write(System.DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(442, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 19 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
     foreach (var timeSlot in Model.Sessions)
    {

#line default
#line hidden
            BeginContext(501, 12, true);
            WriteLiteral("        <h4>");
            EndContext();
            BeginContext(514, 31, false);
#line 21 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
       Write(timeSlot.Key?.ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(545, 32, true);
            WriteLiteral("</h4>\n        <div class=\"row\">\n");
            EndContext();
#line 23 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
             foreach (var session in timeSlot)
            {

#line default
#line hidden
            BeginContext(638, 153, true);
            WriteLiteral("                <div class=\"col-md-3 mb-4\">\n                    <div class=\"card shadow session h-100\">\n                        <div class=\"card-header\">");
            EndContext();
            BeginContext(792, 19, false);
#line 27 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                            Write(session.Track?.Name);

#line default
#line hidden
            EndContext();
            BeginContext(811, 106, true);
            WriteLiteral("</div>\n                        <div class=\"card-body\">\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(917, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2213514592eea075d5d90fad2de76d323914fa9342", async() => {
                BeginContext(967, 13, false);
#line 29 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                                               Write(session.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                           WriteLiteral(session.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(984, 145, true);
            WriteLiteral("</h5>\n                        </div>\n                        <div class=\"card-footer\">\n                            <ul class=\"list-inline mb-0\">\n");
            EndContext();
#line 33 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                 foreach (var speaker in session.Speakers)
                                {

#line default
#line hidden
            BeginContext(1238, 106, true);
            WriteLiteral("                                    <li class=\"list-inline-item\">\n                                        ");
            EndContext();
            BeginContext(1344, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2213514592eea075d5d90fad2de76d323914fa12491", async() => {
                BeginContext(1394, 12, false);
#line 36 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                                    Write(speaker.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                                                WriteLiteral(speaker.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1410, 43, true);
            WriteLiteral("\n                                    </li>\n");
            EndContext();
#line 38 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1487, 115, true);
            WriteLiteral("                            </ul>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 43 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1616, 15, true);
            WriteLiteral("        </div>\n");
            EndContext();
#line 45 "/Users/sergeybakhtoyarov/Documents/GitHub/ReadyWorkshop2019/lab/FrontEnd/Pages/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1637, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591