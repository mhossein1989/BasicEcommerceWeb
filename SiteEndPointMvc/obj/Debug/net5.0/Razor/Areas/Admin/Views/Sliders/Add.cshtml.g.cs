#pragma checksum "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Sliders\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b387e056a5513a9cf565e26eff9871493a1824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sliders_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Sliders/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b387e056a5513a9cf565e26eff9871493a1824", @"/Areas/Admin/Views/Sliders/Add.cshtml")]
    public class Areas_Admin_Views_Sliders_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hosseinsa\source\repos\SadeghiBasicMarket\SiteEndPointMvc\Areas\Admin\Views\Sliders\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Areas/Admin/Views/Shared/_AdminThemeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""basic-elements"">

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title mb-0"">افزودن اسلایدر جدید</h4>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""px-3"">
                        <div class=""form"">
                            <div class=""form-body"">
                                <form method=""post"" class=""row""   enctype=""multipart/form-data"">
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                          
                                            <label for=""basicInput"">آدرس لینک</label>
                                            <input type=""text"" class=""form-control"" name=""link"">");
            WriteLiteral(@"
                                        </fieldset>
                                    </div>  
                                    
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                          
                                            <label for=""basicInput"">تصویر</label>
                                            <input type=""file"" name=""file"" />
                                        </fieldset>
                                    </div>

                                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <br />
                                            <button   class=""btn btn-success col-md-12"">آپلود تصویر</button>
                                        </fieldset>
                                    </div>
         ");
            WriteLiteral("                       </form>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
