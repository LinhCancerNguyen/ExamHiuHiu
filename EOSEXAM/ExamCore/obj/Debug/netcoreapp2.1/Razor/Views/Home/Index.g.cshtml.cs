#pragma checksum "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eef31f61c467636e63dea43da8c75b086f57fdc0"
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
#line 1 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\_ViewImports.cshtml"
using ExamCore;

#line default
#line hidden
#line 2 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\_ViewImports.cshtml"
using ExamCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eef31f61c467636e63dea43da8c75b086f57fdc0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeaaa03773907ab8e517f0c163b9bea13786a47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamCore.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
  
    ViewBag.Title = "User";

#line default
#line hidden
            BeginContext(65, 157, true);
            WriteLiteral("<div class=\"panel panel-default\" style=\"width: 37%; margin: 20% 32%;\">\r\n    <div class=\"panel-heading\">Let\'s Begin  ^_^</div>\r\n    <div class=\"panel-body\">\r\n");
            EndContext();
#line 8 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
         using (Html.BeginForm("GetUser", "Quizz", FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(316, 157, false);
#line 10 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
       Write(Html.EditorFor(c => c.Email, new { htmlAttributes = new { @class = "form-control", @placeholder = "Email ...", @style = "width:100%; margin-left: 56px;" } }));

#line default
#line hidden
            EndContext();
            BeginContext(473, 166, true);
            WriteLiteral("<br />\r\n            <button type=\"submit\" id=\"Enter\" class=\"btn btn-info btn-lg\" style=\"width:100%;\"><span class=\"glyphicon glyphicon-user\"></span>   Enter</button>\r\n");
            EndContext();
#line 12 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(650, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 14 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
     if (ViewBag.Msg != null)
    {

#line default
#line hidden
            BeginContext(700, 47, true);
            WriteLiteral("        <div class=\"well well-sm well-danger\"> ");
            EndContext();
            BeginContext(748, 11, false);
#line 16 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
                                          Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(759, 9, true);
            WriteLiteral(" </div>\r\n");
            EndContext();
#line 17 "D:\ExamHiuHiu\EOSEXAM\ExamCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(775, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamCore.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
