#pragma checksum "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ead789bf101c101238081e739e1910a5aed634a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Class), @"mvc.1.0.view", @"/Views/Student/Class.cshtml")]
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
#line 1 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/_ViewImports.cshtml"
using ASP.Net_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/_ViewImports.cshtml"
using ASP.Net_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ead789bf101c101238081e739e1910a5aed634a", @"/Views/Student/Class.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57813776563c54affa2fa1cd2a44caa69c64d8fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Class : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.Net_MVC_Core.Models.Class>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"class container\">\n    <div class=\"row col-md-12 title\">\n        <span>Danh sách lớp học</span>\n    </div>\n    <div>\n        <button");
            BeginWriteAttribute("onclick", "  onclick=\"", 193, "\"", 257, 3);
            WriteAttributeValue("", 204, "location.href=\'", 204, 15, true);
#nullable restore
#line 7 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
WriteAttributeValue("", 219, Url.Action("CreateClass", "Student"), 219, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 256, "\'", 256, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    Thêm
        </button>
    </div>
    <div class=""tbody col-md-12"">
        <table>
            <tr class=""col-md-12"">
                <th class=""col-md-3"">Mã lớp</th>
                <th class=""col-md-6"">Tên lớp</th>
                <th class=""col-md-6"">Trạng thái</th>
                <th class=""col-md-3"">...</th>
            </tr>
");
#nullable restore
#line 19 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
              
                if(Model.Any())
                {
                    foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n\n                            <td class=\"col-md-3\">");
#nullable restore
#line 26 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                                            Write(item.code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"col-md-6\">");
#nullable restore
#line 27 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                                            Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"col-md-6\">\n");
#nullable restore
#line 29 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                                  
                                    if (item.status == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>disable</span>");
#nullable restore
#line 31 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                                                          ; }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>enable</span>");
#nullable restore
#line 33 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                                                         ; }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"col-md-3\">\n                                ");
#nullable restore
#line 38 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                           Write(Html.ActionLink("Sửa", "ClassEdit", "Student", new { id=item.id }, new {@class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 39 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                           Write(Html.ActionLink("Xóa", "ClassDelete", "Student", new { id = item.id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 42 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Class.cshtml"
                        
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.Net_MVC_Core.Models.Class>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
