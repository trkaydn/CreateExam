#pragma checksum "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a467467db2ca8d50d4441e73577e512c199b79cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\_ViewImports.cshtml"
using CreateExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\_ViewImports.cshtml"
using CreateExam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\_ViewImports.cshtml"
using CreateExam.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a467467db2ca8d50d4441e73577e512c199b79cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69bbbce37b24db2490ab7f31807650f1fee5e288", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Sınav Listesi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Sınav Listesi</h1>
    <br />
    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>Başlık</th>
            <th>Tarih</th>
            <th></th>
        </tr>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
             foreach (var exam in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
                   Write(exam.ExamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 495, "\"", 556, 1);
#nullable restore
#line 21 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
WriteAttributeValue("", 502, Url.Action("Index","TakeExam",new {@id=exam.ExamID }), 502, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
                                                                                    Write(Html.Raw(exam.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
                   Write(exam.CreateDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger text-white\"");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 756, 2);
            WriteAttributeValue("", 727, "/Home/DeleteExam/", 727, 17, true);
#nullable restore
#line 23 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
WriteAttributeValue("", 744, exam.ExamID, 744, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Tarik Aydin\Desktop\CreateExam\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
