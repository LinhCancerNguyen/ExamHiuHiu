#pragma checksum "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46dcb63d8f6af527e40f05ea75140a71a875bc2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_Index), @"mvc.1.0.view", @"/Views/Result/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Result/Index.cshtml", typeof(AspNetCore.Views_Result_Index))]
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
#line 1 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\_ViewImports.cshtml"
using ExamCore;

#line default
#line hidden
#line 2 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\_ViewImports.cshtml"
using ExamCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46dcb63d8f6af527e40f05ea75140a71a875bc2c", @"/Views/Result/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeaaa03773907ab8e517f0c163b9bea13786a47", @"/Views/_ViewImports.cshtml")]
    public class Views_Result_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(77, 546, true);
            WriteLiteral(@"<div class=""col-12 stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Subject</th>
                            <th>Mark</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 21 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                         foreach (Result r in Model.Result)
                        {

#line default
#line hidden
            BeginContext(711, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n");
            EndContext();
#line 25 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                     foreach (User u in Model.User)
                                    {
                                        if (u.Id == r.User.Id)
                                        {
                                            

#line default
#line hidden
            BeginContext(1043, 36, false);
#line 29 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => u.Name));

#line default
#line hidden
            EndContext();
#line 29 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                                                                 
                                        }
                                    }

#line default
#line hidden
            BeginContext(1163, 77, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 34 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                     foreach (Subject s in Model.Subject)
                                    {
                                        if (s.Id == r.Subject.Id)
                                        {

#line default
#line hidden
            BeginContext(1464, 48, true);
            WriteLiteral("                                            <ul>");
            EndContext();
            BeginContext(1513, 36, false);
#line 38 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => s.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 7, true);
            WriteLiteral("</ul>\r\n");
            EndContext();
#line 39 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(1638, 113, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1752, 36, false);
#line 43 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => r.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1903, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "495a43607c1a4820ab8d6157575d4ba0", async() => {
                BeginContext(1945, 47, true);
                WriteLiteral("<label class=\"badge badge-warning\">Edit</label>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                                           WriteLiteral(r.Id);

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
            BeginContext(1996, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2111, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca1517fad3d442e9ed30409633f3cd3", async() => {
                BeginContext(2155, 48, true);
                WriteLiteral("<label class=\"badge badge-danger\">Delete</label>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                                                             WriteLiteral(r.Id);

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
            BeginContext(2207, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Result\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2310, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
